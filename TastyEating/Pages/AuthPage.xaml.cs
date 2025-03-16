using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TastyEating.Models;
using TastyEating.Pages;

namespace TastyEating
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Authbtn_Click(object sender, RoutedEventArgs e)
        {
            if(Logintb.Text=="" || Passwordtb.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            var user = MyDbContext.Instance.Users.FirstOrDefault(f => f.Login == Logintb.Text && f.Password == Passwordtb.Text);
            if (user == null)
            {
                MessageBox.Show("Пользователя не существует!");
                return;
            }
            MyDbContext.LocalUser = user;
            NavigationService.Navigate(new MenuPage());
        }
    }
}
