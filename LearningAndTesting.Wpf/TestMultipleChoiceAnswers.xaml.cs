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
    /// Interaction logic for TestMultipleChoiceAnswers.xaml
    /// </summary>
    public partial class TestMultipleChoiceAnswers : Window
    {
        /// <summary>
        /// Here I instanciate 5 questions derived from the Questions class
        /// -- These will be placed into a Class array and will be randomly chosen --
        /// </summary>
        public QuestionsMcAnswers question1 = new QuestionsMcAnswers();
        public QuestionsMcAnswers question2 = new QuestionsMcAnswers();
        public QuestionsMcAnswers question3 = new QuestionsMcAnswers();
        public QuestionsMcAnswers question4 = new QuestionsMcAnswers();
        public QuestionsMcAnswers question5 = new QuestionsMcAnswers();
    

        public TestMultipleChoiceAnswers()
        {
            InitializeComponent();


            // Creating an array
            QuestionsMcAnswers[] questionsList = { question1, question2 };

            MessageBox.Show(questionsList.ToString());

            // Setting the properties for the 5 potential questions

            //QUESTION 1
            question1.QuestionText = "What programming paradigm is C# mainly focused for?";
            question1.AnswerA = "Functional";
            question1.AnswerB = "Procedural";
            question1.AnswerC = "Object-Oriented";
            question1.CorrectAnswer = question1.AnswerC;

            //QUESTION 2
            question2.QuestionText = "Which of the following is not a type of number in C#";
            question2.AnswerA = "Float";
            question2.AnswerB = "Bool";
            question2.AnswerC = "Long";
            question2.CorrectAnswer = question2.AnswerB;
        }

        public void generateQuestion()
        {
            Random random = new Random();
            
            
        }
    }
}
