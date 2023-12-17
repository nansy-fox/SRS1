using Practical_for_BD.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity;
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
using static System.Net.Mime.MediaTypeNames;

namespace Practical_for_BD.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
             
            using (var db = new Public_transportEntities1())
            {
                db.Genders.Load();
                db.Routes.Load();
                //var users = db.Users.ToList();
                DGUsers.ItemsSource = db.Users.ToList();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Update());
        }

    }
}
