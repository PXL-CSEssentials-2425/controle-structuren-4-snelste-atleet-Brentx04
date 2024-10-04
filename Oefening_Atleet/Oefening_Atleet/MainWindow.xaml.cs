using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oefening_Atleet
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            timeTextBox.Clear();
            resultsTextBox.Clear();

            nameTextBox.Focus();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            int fastestTime;
            string fastestName;

            int currentTime = int.Parse(timeTextBox.Text);

            if(fastestTime == 0 || currentTime < fastestTime)
            {
                fastestTime = currentTime;
                fastestName = nameTextBox.Text;
            }
        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
            resultsTextBox.Text + $"De snelste atleet is {fastestName} met een tijd van {fastestTime} seconden.";
        }
    }
}
