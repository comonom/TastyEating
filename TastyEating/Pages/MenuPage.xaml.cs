using Microsoft.EntityFrameworkCore;
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
using TastyEating.Models;

namespace TastyEating.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            LvMain.ItemsSource = MyDbContext.Instance.Dishes.Include(s=>s.Category).ToArray();
            this.DataContext = new Context
            {
                Fullname = $"{MyDbContext.LocalUser.Surname} {MyDbContext.LocalUser.Name} {MyDbContext.LocalUser.Patronymic}",
            };
        }

        public class Context
        {
            public string Fullname { get; set; }
        }

    }
}
