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

namespace Test_WPF
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

        private void CheckAnswers_Click(object sender, RoutedEventArgs e)
        {
            int score = 0;

            if (q1Answer2.IsChecked == true)
            {
                score++;
            }

            if (q2Answer2.IsChecked == true)
            {
                score++;
            }

            if (q3Answer2.IsChecked == true)
            {
                score++;
            }

            if (q4Answer2.IsChecked == true)
            {
                score++;
            }

            if (q5Answer1.IsChecked == true)
            {
                score++;
            }

            if (q6Answer3.IsChecked == true)
            {
                score++;
            }

            resultLabel.Content = $"Вы ответили правильно на {score} из 6 вопросов.";

        }
    }
}
