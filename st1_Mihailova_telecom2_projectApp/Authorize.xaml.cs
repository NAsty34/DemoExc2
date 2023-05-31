using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace st1_Mihailova_telecom2_projectApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Authorize : Window
    {
        string generateCode = Membership.GeneratePassword(8, 1);
        public Authorize()
        {
            InitializeComponent();
        }

        private void Click_Update_Code(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Код для входа в систему: {generateCode}","Code for lodin");
        }

        private void Click_Cancel(object sender, RoutedEventArgs e)
        {
            number.Clear();
            password.Clear();
            code.Clear();
        }

        private void Click_Login(object sender, RoutedEventArgs e)
        {
            if (code.Text == ""  && number.Text == "" && password.Text == "")
            {
                MessageBox.Show("Не все поля заполнены", "Error login");
            }
            else
            if (code.Text != generateCode)
            {
                MessageBox.Show("Неверный код", "Error code");
            }
            else
            {
                new MainForSubscribes().Show();
                Close();
            }
            
        }
    }
}
