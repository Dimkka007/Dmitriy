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


namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Asssortment.xaml
    /// </summary>
    public partial class Asssortment : Page
    {
        Menu menu = new Menu();
        public Asssortment(string name)
        {
            InitializeComponent();
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.ToList();
            DataContext = menu;
            qwe.Text = name;
            
            
        }
        

        //Добавление в корзину
        Chek asd = new Chek();
        int sum = 0;
        private void AddBasket(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Menu list = button.DataContext as Menu;
            Basket.Items.Add(list);
            asd.ChekList.Items.Add(list);
            
            int it = Convert.ToInt32(list.Price);
            sum += it;
            Itog.Text = sum.ToString();
        }

        //Фильтрация
        private void VseFilt(object sender, RoutedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.ToList();
        }

        private void SalFilt(object sender, RoutedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Type == 1).ToList();
        }

        private void SupFilt(object sender, RoutedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Type == 2).ToList();
        }

        private void GorFilt(object sender, RoutedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Type == 3).ToList();
        }

        private void GarFilt(object sender, RoutedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Type == 4).ToList();
        }

        private void HlebFilt(object sender, RoutedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Type == 5).ToList();
        }

        private void NapFilt(object sender, RoutedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Type == 6).ToList();
        }

        //Поиск
        private void SearchAssort(object sender, TextChangedEventArgs e)
        {
            Menu.ItemsSource = TastyDinnerEntities.GetContext().Menu.Where(x => x.Name.Contains(Search.Text)).ToList();
        }

        //Вывод чека
        private void Oplata(object sender, RoutedEventArgs e)
        {
            if(Basket.Items.Count <= 0)
            {
                MessageBox.Show("Корзина пуста");
                return;
            }
            else
            {
                
                asd.Priceqwe.Text = sum.ToString() + "₽";


                


                asd.Show();
                Manager.MainFrame.Navigate(new Asssortment(""));
                qwe.Text = Menu.Name;
            }
            
        }


        //Информация
        bool x;
        private void Info(object sender, RoutedEventArgs e)
        {
            if(x)
            {
                Information.Visibility = Visibility.Visible;
            }
            else
            {
                Information.Visibility = Visibility.Collapsed;
            }
            x = !x;
        }


        //Кнопка выйти
        private void Exit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход",
         MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                MessageBox.Show("До свидания");
                Manager.MainFrame.Navigate(new Authorization());

            }
        }

        //Калькулятор
        Calculation calculation = new Calculation();
        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            calculation.Show();

        }

        private void Basket_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DependencyObject obj = (DependencyObject)e.OriginalSource;

            while (obj != null && obj != Basket)
            {
                if (obj.GetType() == typeof(ListViewItem))
                {
                    MessageBoxResult result = MessageBox.Show("Удалить выбранный элемент?", "Удаление",
         MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        
                        
                        

                        int a = Convert.ToInt32(PriceBox.Text);
                        
                        sum = sum - a;
                        Itog.Text = sum.ToString();

                        for(int i = 0; i < Basket.SelectedItems.Count; i++)
                        {
                            asd.ChekList.Items.RemoveAt(Basket.SelectedIndex);
                            Basket.Items.Remove(Basket.SelectedItems[i]);


                        }
                        

                        
                    }
                    
                }
                obj = VisualTreeHelper.GetParent(obj);
            }
            

        }
    }
}
