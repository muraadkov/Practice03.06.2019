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

namespace Practice03._06._2019
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var firstDomain = AppDomain.CreateDomain("Factorial File");
            if (int.TryParse(countOfFactorial.Text, out int count)) {
            firstDomain.ExecuteAssembly(firstDomain.BaseDirectory + "Factorial.exe", new string[] { "1", $"{count}" });
            }
        }

        private void Download_Click(object sender, RoutedEventArgs e)
        {
           
            var firstDomain = AppDomain.CreateDomain("Download File");
            if(urlOfFile.Text != string.Empty || nameOfFile.Text != string.Empty) {
            firstDomain.ExecuteAssembly(firstDomain.BaseDirectory + "DownloadFile.exe", new string[] { $"{urlOfFile.Text}", $"{nameOfFile.Text}" });
            }
        }
    }
}
