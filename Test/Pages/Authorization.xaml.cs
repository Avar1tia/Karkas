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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Test.Classes;

namespace Test.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
            connect.modeldb = new Models.dbEntities();
        }

        private void Vhod(object sender, RoutedEventArgs e)
        {
            var userObj = Classes.connect.modeldb.users.FirstOrDefault(x => x.login == Login.Text && Password.Password == x.password);
            if (userObj.it_type == 1)
            {
                manager.MainFrame.Navigate(new Admin());
            }
            if (userObj.it_type == 2)
            {
                manager.MainFrame.Navigate(new Manager());
            }
            if (userObj.it_type == 1)
            {
                manager.MainFrame.Navigate(new User());
            }
        }
    }
}
