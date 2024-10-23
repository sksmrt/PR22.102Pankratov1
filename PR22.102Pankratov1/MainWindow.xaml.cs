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

namespace PR22._102Pankratov1
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

        private void CheckDigits_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;

            if (input.Length != 12)
            {
                MessageBox.Show("Введите корректное двенадцатизначное число.");
                return;
            }

            try
            {
                int[] digits = new int[12];

                for (int i = 0; i < 12; i++)
                {
                    digits[i] = int.Parse(input[i].ToString());
                }

                int FirstThree = digits[0] * digits[1] * digits[2];

                int LastNine = 0;
                for (int i = 3; i < 12; i++)
                {
                    LastNine += digits[i];
                }

                if (FirstThree == LastNine)
                {
                    ResultTextBox.Text = "Произведение первых 3 цифр равно сумме последних 9 цифр.";
                }
                else
                {
                    ResultTextBox.Text = "Произведение первых 3 цифр не равно сумме последних 9 цифр";
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
