using Practical_for_BD.Entity;
using System;
using System.Collections.Generic;
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

namespace Practical_for_BD.Pages
{
    /// <summary>
    /// Логика взаимодействия для Update.xaml
    /// </summary>
    public partial class Update : Page
    {
        private Users _context;

        public Update()
        {
            InitializeComponent();
            using (var db = new Public_transportEntities1())
            {
                Admin admin = new Admin();
                db.Genders.Load();
                db.Routes.Load();
                var users = db.Users.ToList();

                txtbSurname.Text = users.Select(x => x.Surname).FirstOrDefault().ToString();
                txtbName.Text = users.Select(x => x.Name).FirstOrDefault().ToString();
                txtbPatronimyc.Text = users.Select(x => x.Patronymic).FirstOrDefault().ToString();
                //txtbRoute.Text = users.Select(x =>x.Route).FirstOrDefault().ToString();
                cbRoutes.ItemsSource = Public_transportEntities1.GetContext().Routes.ToList();
            }
        }
        public Update(Users admin)
        {
            InitializeComponent();
            _context = admin;
            txtbSurname.Text = _context.Surname;
            txtbName.Text = _context.Name;
            txtbPatronimyc.Text = _context.Patronymic;
            cbRoutes.ItemsSource = Public_transportEntities1.GetContext().Routes.ToList();
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
