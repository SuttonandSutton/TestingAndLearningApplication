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

namespace LearningAndTesting.Wpf
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

        private void learningCentreButton_Click(object sender, RoutedEventArgs e)
        {
            LearningCentre lcb = new LearningCentre();
            lcb.Show();
        }

        private void testMCButton_Click(object sender, RoutedEventArgs e)
        {
            TestMultipleChoiceAnswers tmca = new TestMultipleChoiceAnswers();
            tmca.Show();
            
        }
    }
}
