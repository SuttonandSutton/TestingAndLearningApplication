using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAndTesting.Wpf
{
   public class QuestionsMcAnswers
    {
        private string questionText;

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; }
        }

        private string answerA;

        public string AnswerA
        {
            get { return answerA; }
            set { answerA = value; }
        }

        private string answerB;

        public string AnswerB
        {
            get { return answerB; }
            set { answerB = value; }
        }

        private string answerC;

        public string AnswerC
        {
            get { return answerC; }
            set { answerC = value; }
        }

        private string correctAnswer;

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }


    }
}
