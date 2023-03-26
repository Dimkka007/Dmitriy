using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using f = System.Windows.Forms;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        
        private Menu menu = new Menu();
        public Admin(Menu selectmenu)
        {
            InitializeComponent();

            DataContext = menu;

            if(selectmenu != null)
                menu = selectmenu;

            Type.ItemsSource = TastyDinnerEntities.GetContext().TypeMenu.ToList();
            Polzovatel.ItemsSource = TastyDinnerEntities.GetContext().User.ToList();
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.ToList();
        }

        //Вывод листа с пользователями
        private void Polzovat(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Collapsed;
            AddMenu.Visibility = Visibility.Collapsed;
            Polzovatel.Visibility = Visibility.Visible;
        }

        //Вывод листа с ассортиментом
        private void MenuButton(object sender, RoutedEventArgs e)
        {
            Polzovatel.Visibility = Visibility.Collapsed;
            AddUs.Visibility = Visibility.Collapsed;
            Menu.Visibility = Visibility.Visible;
        }

        //Поиск
        private void AdminSearch(object sender, TextChangedEventArgs e)
        {
            if(Polzovatel.Visibility == Visibility.Visible)
            {
                Polzovatel.ItemsSource = TastyDinnerEntities.GetContext().User.Where(x => x.Name.Contains(Search1.Text)).ToList();
            }
            if(Menu.Visibility == Visibility.Visible)
            {
                Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Name.Contains(Search1.Text)).ToList();
            }
            
        }

        //Удаление
        private void Delete(object sender, RoutedEventArgs e)
        {

            if(Polzovatel.Visibility == Visibility.Visible)
            {
                var removeP = Polzovatel.SelectedItems.Cast<User>().ToList();
                if (MessageBox.Show($"Вы точно хотите удалить выбранный элемент?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        TastyDinnerEntities.GetContext().User.RemoveRange(removeP);
                        TastyDinnerEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        Polzovatel.ItemsSource = TastyDinnerEntities.GetContext().User.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
            if (Menu.Visibility == Visibility.Visible)
            {
                var removeM = Menu.SelectedItems.Cast<Menu>().ToList();
                if (MessageBox.Show($"Вы точно хотите удалить выбранный элемент?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        TastyDinnerEntities.GetContext().Menu.RemoveRange(removeM);
                        TastyDinnerEntities.GetContext().SaveChanges();
                        MessageBox.Show("Данные удалены!");
                        Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }

        }
        
        //Видимость добавления
        private void Add(object sender, RoutedEventArgs e)
        {
            
            if (Menu.Visibility == Visibility.Visible)
            {
                
                AddMenu.Visibility = Visibility.Visible;
                AddUs.Visibility = Visibility.Collapsed;
            }
            if (Polzovatel.Visibility == Visibility.Visible)
            {
                
                AddUs.Visibility = Visibility.Visible;
                AddMenu.Visibility = Visibility.Collapsed;
            }
        }

        //Сохранить информацию о пользователе
        User user = new User();
        private void Save(object sender, RoutedEventArgs e)
        {
            
            if (Na.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (Lo.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (Pa.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if(Proverka.Text != Pa.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            
            else
            {
                
                Manager manager = new Manager();
                manager.AddPerson(Na.Text, Lo.Text, Pa.Text);
                
                MessageBox.Show("Пользователь добавлен");
                Polzovatel.ItemsSource = TastyDinnerEntities.GetContext().User.ToList();
            }

        }

        //Добавить изображение
        private void AddImage(object sender, RoutedEventArgs e)
        {

            f.OpenFileDialog o = new f.OpenFileDialog();
            o.Filter = "| *.png; *.jpg;";
            if(o.ShowDialog() == f.DialogResult.OK)
            {
                TextBox1.Text = o.FileName;
                
            }
            
        }

        //Сохранить информацию о меню
        private void SaveMenu(object sender, RoutedEventArgs e)
        {

            if(Type.SelectedIndex<=0)
            {
                MessageBox.Show("Выберите тип блюда!");
                return;
            }
            if(Nam.Text == "")
            {
                MessageBox.Show("Выберите наименование!");
                return;
            }
            if (Wei.Text == "")
            {
                MessageBox.Show("Выберите вес блюда!");
                return;
            }
            if(Pri.Text == "")
            {
                MessageBox.Show("Выберите стоимость блюда!");
                return;
            }
            else
            {
                menu.Type = Type.SelectedIndex + 1;
                menu.Image = TextBox1.Text;
                TastyDinnerEntities.GetContext().Menu.Add(menu);
                TastyDinnerEntities.GetContext().SaveChanges();
                Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.ToList();
            }
           
        }

        //Выход
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход",
         MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                MessageBox.Show("До свидания");
                Manager.MainFrame.Navigate(new Authorization());

            }
        }

        private void Pri_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

    }
}
