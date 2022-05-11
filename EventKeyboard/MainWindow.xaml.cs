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

namespace EventKeyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if ((bool)chkIgnoreRepeat.IsChecked && e.IsRepeat) return;
            string message = "Event:" + e.RoutedEvent + "key:" + e.Key+"\n";
            Result.Text += message;

        }

        private void TextInputs(object sender, TextCompositionEventArgs e)
        {
            string message = "Event:" + e.RoutedEvent + "key:" + e.Text + "\n";
            Result.Text += message;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            string message = "Event:" + e.RoutedEvent + "\n";
            Result.Text += message;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
        }
    }
}
