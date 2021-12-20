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

namespace Lab03___WpfApp
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

        private void ComboBox_SelectionChanged_Font(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (texBox != null)
            {
                texBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_Size(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (texBox != null)
            {
                texBox.FontSize = Convert.ToDouble(fontSize);
            }
        }

        private void ButtonClick_Boid(object sender, RoutedEventArgs e)
        {
            if (texBox == null)
            {
                return;
            }
            if (texBox.FontWeight > FontWeight.FromOpenTypeWeight(400))
            {
                texBox.FontWeight = FontWeight.FromOpenTypeWeight(400);
            }
            else
            {
                texBox.FontWeight = FontWeight.FromOpenTypeWeight(700);
            }
        }

        private void ButtonClick_Italic(object sender, RoutedEventArgs e)
        {
            if (texBox == null)
            {
                return;
            }
            if (texBox.FontStyle == FontStyles.Italic)
            {
                texBox.FontStyle = FontStyles.Normal;
            }
            else
            {
                texBox.FontStyle = FontStyles.Italic;
            }
        }

        private void ButtonClick_UnderLine(object sender, RoutedEventArgs e)
        {
            if(texBox == null)
            {
                return;
            }

            if (texBox.TextDecorations == TextDecorations.Underline)
            {
                texBox.TextDecorations = null;
            }
            else
            {
                texBox.TextDecorations = TextDecorations.Underline;
            }
        }

        private void RadioButton_Checked_Black(object sender, RoutedEventArgs e)
        {
            if (texBox == null)
            {
                return;
            }
            texBox.Foreground = Brushes.Black;
        }

        private void RadioButton_Checked_Red(object sender, RoutedEventArgs e)
        {
            if (texBox == null)
            {
                return;
            }

            texBox.Foreground = Brushes.Red;
        }
    }
}
