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

namespace WpfAp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class UserAdmin : Window
    {
        public UserAdmin()
        {
            InitializeComponent();
        }
        private void UserClicked(object sender, RoutedEventArgs e)
        {
            User_LoginSignUp subWindow = new User_LoginSignUp();
            this.Close();
            subWindow.Show();
        }
        private void AdminClicked(object sender, RoutedEventArgs e)
        {
            Admin_Login subWindow = new Admin_Login();
            this.Close();
            subWindow.Show();
        }
    }
}
