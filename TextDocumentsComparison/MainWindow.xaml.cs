using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ComparisonTextDocuments.Algorithms;


namespace TextDocumentsComparison
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        String textDoc1;
        String textDoc2;
        JaroWinkler jw = new JaroWinkler();
        Levenshtein levenshtein = new Levenshtein();
        NormalizedLevenshtein normalizedLevenshtein = new NormalizedLevenshtein();
        NGram nGram = new NGram();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void browserButton1_Click(object sender, RoutedEventArgs e)
        {
                Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
                openFileDialog1.Filter = "Text documents(.pdf) | *.pdf; *.txt; *.docx";
                Nullable<bool> result = openFileDialog1.ShowDialog();
                if(result == true)
                {
                     textBoxDoc1.Text = openFileDialog1.FileName;
                     textDoc1 = System.IO.File.ReadAllText(openFileDialog1.FileName);
                    
                }
         }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void browserButton2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            openFileDialog1.Filter = "Text documents (.pdf) |*.pdf;*.txt;*.docx";
            Nullable<bool> result = openFileDialog1.ShowDialog();
            if (result == true)
            {
                textBoxDoc2.Text = openFileDialog1.FileName;
                textDoc2 = System.IO.File.ReadAllText(openFileDialog1.FileName);
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultTexBox.Text = "";
            progressBar.Value = 0;
            if (jaroWinklerCheckBox.IsChecked.Value)
                {
                Thread.Sleep(100);
                resultTexBox.Text += "\n\nJARO WINKLER:\nDistance = " + jw.Distance(textDoc1, textDoc2) + "\nSimilarity = " + jw.Similarity(textDoc1, textDoc2) * 100 + "%";
            }
            progressBar.Value = 5;
            if (levenshteinCheckBox.IsChecked.Value)
            {
                Thread.Sleep(100);
                resultTexBox.Text += "\n\nLEVENSHTEIN:\nDistance = " + levenshtein.Distance(textDoc1, textDoc2);
            }
            progressBar.Value = 40;
            if (normalizedLevenshteinCheckBox.IsChecked.Value)
            {
                Thread.Sleep(100);
                resultTexBox.Text += "\n\nNORMALIZED LEVNSHTEIN:\nDistance = " + normalizedLevenshtein.Distance(textDoc1, textDoc2) + "\nSimilarity = " + normalizedLevenshtein.Similarity(textDoc1, textDoc2) * 100 + "%";
            }
            progressBar.Value = 65;
            if (nGramCheckBox.IsChecked.Value)
            {
                Thread.Sleep(100);
                resultTexBox.Text += "\n\nNGRAM:\nDistance = " + nGram.Distance(textDoc1, textDoc2);
            }
            progressBar.Value = 100;
        }

        private void jaroWinklerCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
