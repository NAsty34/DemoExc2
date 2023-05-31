using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace st1_Mihailova_telecom2_projectApp
{
    /// <summary>
    /// Логика взаимодействия для MainForSubscribes.xaml
    /// </summary>
    public partial class MainForSubscribes : Window
    {
        st1_Mihailova_telecomEntities telecomEntities = new st1_Mihailova_telecomEntities();
        public MainForSubscribes()
        {
            InitializeComponent();
        }

        private void DataGridClients_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from user in telecomEntities.Subscriber
                        orderby user.Name
                        select new
                        {
                            ФИО = user.FirstName + " " + user.Name + " " + user.LastName,
                            Абоненский_Номер = user.NumberSubscriber,
                            Лицевой_счёт = user.PersonalAccount,
                            Услуги = user.Services1.Name
                        };
            DataGridClients.ItemsSource = query.ToList();
        }
    }
}
