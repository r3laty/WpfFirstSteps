using System;
using System.Linq;
using System.Windows;

namespace WpfLearning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _inputText = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Splitting text
        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            _inputText = SplittingTextBox.Text;
            var splittenText = SplitText(_inputText);
            
            SplittingListBox.ItemsSource = splittenText;
            SplittingListBox.Visibility = Visibility.Visible;
            ExitFromList.Visibility = Visibility.Visible;
        }
        private void ExitFromList_Click(object sender, RoutedEventArgs e)
        {
            SplittingListBox.Visibility = Visibility.Hidden;
            ExitFromList.Visibility = Visibility.Hidden;

            _inputText = string.Empty;
        }

        private string[] SplitText(string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        #endregion
        #region Reversing text
        private void ReverseButton_Click(object sender, RoutedEventArgs e)
        {
            _inputText = ReversingTextBox.Text;

            string reversedWords = ReverseWords(_inputText);

            MessageBox.Show(reversedWords);
            
            _inputText = string.Empty;
        }
        private string ReverseWords(string inputPhrase)
        {
            string[] words = SplitText(inputPhrase);
            Array.Reverse(words);

            return string.Join(" ", words);
        }

        #endregion


    }
}
