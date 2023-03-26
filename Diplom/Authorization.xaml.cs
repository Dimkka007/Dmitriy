using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        User user = new User();
        public Authorization()
        {
            InitializeComponent();
            DataContext = user;



            
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            var enter = TastyDinnerEntities.GetContext().User.FirstOrDefault(x => x.Login == Login.Text && x.Password == Password.Text);
            if (enter == null)
            {
                MessageBox.Show("Не правильный логин или пароль");
                Login.Text = null;
                Password.Text = null;
                return;
            }
            if(enter.Type == 2)
            {
                MessageBox.Show("Здравствуйте " + enter.Name);
                Manager.MainFrame.Navigate(new Admin(null));
            }
            else
            {
                MessageBox.Show("Здравствуйте " + enter.Name);
                Manager.MainFrame.Navigate(new Asssortment(enter.Name));
            }
        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            Auto.Visibility = Visibility.Collapsed;
            Reg.Visibility = Visibility.Visible;
        }

        private void Authoriz(object sender, RoutedEventArgs e)
        {
            Reg.Visibility = Visibility.Collapsed;
            Auto.Visibility = Visibility.Visible;
        }

        private void AddBD(object sender, RoutedEventArgs e)
        {
            if (Imya.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (Loginn.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (Parol.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            else
            {
                user.Type = 1;
                MessageBox.Show("Пользователь добавлен");
                TastyDinnerEntities.GetContext().User.Add(user);
                TastyDinnerEntities.GetContext().SaveChanges();

            }
            Imya.Text = null;

            Loginn.Text = null;
            Parol.Text = null;
        }  
    }
}
