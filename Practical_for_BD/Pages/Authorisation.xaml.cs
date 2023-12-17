using Practical_for_BD.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    /// Логика взаимодействия для Authorisation.xaml
    /// </summary>
    public partial class Authorisation : Page
    {
        public Authorisation()
        {
            InitializeComponent();
        }
        private void LoadForm(long ID)
        {
            switch (ID)
            {
                case 1:
                    NavigationService.Navigate(new Pages.Admin());
                    break;
                case 2:
                    NavigationService.Navigate(new Pages.SuperAdmin());
                    break;
                case 3:
                    NavigationService.Navigate(new Pages.Operator());
                    break;
                case 4:
                    NavigationService.Navigate(new Pages.Manager());
                    break;
            }
        }

        private int unsuccessful = 0;

        //private static Entity.Public_transportEntities firstDBEntities;

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            var db = Helper.GetContext();
            string surname = txtbSurname.Text.Trim();
            string name = txtbName.Text.Trim();
            string patronymic = txtbPatronymic.Text.Trim();
            //string phone_number = txtbPhoneNumber.Text.Trim();
            string password = pswbPassword.Password.Trim();

            var role_ID = db.Roles_and_permissions.ToList();
            var role = db.Roles.ToList();

            if (surname.Length > 0 && password.Length > 0)
            {
                string hashed = HashPassword_Lib.HashPassword_Class.HashPass(password);
                var user = Helper.GetContext().Users.Where(u => u.Surname == surname && u.Name == name && u.Patronymic == patronymic && u.Password == hashed).FirstOrDefault();

                if (unsuccessful < 1)
                {
                    if (user != null)
                    {
                        foreach (var r in role_ID)
                        {
                            foreach (var rol in role)
                            {
                                if (user.ID_Role_and_permission == r.ID && r.ID_Role == rol.ID)
                                {
                                    MessageBox.Show($"Вы вошли под ролью: {rol.User_name.ToString()}");
                                    LoadForm(rol.ID);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином  или паролем не найден!", "Внимание", MessageBoxButton.OK);
                        unsuccessful++;
                    }

                }
                else
                {
                    //string captha = textboxCaptcha.Text;
                    if (user != null)
                    {
                        foreach (var r in role_ID)
                        {
                            foreach (var rol in role)
                            {
                                if (user.ID_Role_and_permission == r.ID && r.ID_Role == rol.ID)
                                {
                                    MessageBox.Show($"Вы вошли под ролью: {rol.User_name.ToString()}");
                                    LoadForm(rol.ID);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином  или паролем не найден!", "Внимание", MessageBoxButton.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Не все обязательные поля заполнены! Заполните поля логин и пароль!", "Внимание!", MessageBoxButton.OK);
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
