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
using System.Windows.Shapes;

namespace LearningAndTesting.Wpf
{
    /// <summary>
    /// Interaction logic for LearningCentre.xaml
    /// </summary>
    public partial class LearningCentre : Window
    {
        public LearningCentre()
        {
            InitializeComponent();
        }

        private void whatIsCSharpHL_Click(object sender, RoutedEventArgs e)
        {
            Question_WhatIsCSharp test = new Question_WhatIsCSharp();
            test.Show();
        }
    }
}
