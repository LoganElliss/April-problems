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

namespace April_9_12_Problems
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

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (Imput.Text == "2018") try
                {
                    System.IO.StreamReader streamReader =
                        new System.IO.StreamReader("2018.txt");
                    while (!streamReader.EndOfStream)
                    {
                        MessageBox.Show(streamReader.ReadLine());
                    }
                    streamReader.Close();

                }

                catch (Exception ex) { }
            if (Imput.Text == "2017") try
            {
                    System.IO.StreamReader streamReader =
                        new System.IO.StreamReader("2017.txt");
                    while (!streamReader.EndOfStream)
                    {
                        MessageBox.Show(streamReader.ReadLine());
                    }
                    streamReader.Close();
            }
                catch (Exception ex) { }

        }
    }
}
