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

namespace Практическая_20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Гуреева Ирина Дмитриевна. \n20 практическая \n Найти произведение n целых случайных чисел X., распределенных в диапазоне от 0 до n. Вывести на экран на одной строке сгенерированные числа, на другой строке результат. \nНе замужем ", "Обо мне");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
            n.Clear();
            res.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int i, pros;
            bool f1;
            f1 = Int32.TryParse(n.Text, out int x);
            if (f1 == true)
            {
                for (i = 1; i <= x; i++)
                {
                    list.Items.Add(rnd.Next(1, x));
                }
                pros = 1;
                for (i = 0; i < list.Items.Count; i++)
                {
                    pros = pros * Convert.ToInt32(list.Items[i]);
                    res.Text = pros.ToString();
                }
            }
            else MessageBox.Show("Введите числа");
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                list.Items.RemoveAt(list.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Выберите элемент для удаления");
            }
        }
    }
}
