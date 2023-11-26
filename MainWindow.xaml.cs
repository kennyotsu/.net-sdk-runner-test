using System;
using System.Windows;


namespace LastDock
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
        private void Sum(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb_num1.Text, out int num1) && int.TryParse(tb_num2.Text, out int num2))
            {
                int result = num1 + num2;
                tb_result.Text = result.ToString();
            }
            else
            {
                tb_result.Text = "Брат, не буквы.";
            }
        }
    }
}
