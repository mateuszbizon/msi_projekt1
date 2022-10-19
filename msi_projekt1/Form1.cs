using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msi_projekt1
{
    public partial class Form1 : Form
    {
        int answerA = 1;
        int answerB = 2;
        int answerC = 3;
        int questionNumber = 1;
        int score;
        int totalQuestions = 5;

        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == answerA)
            {
                score++;
            }

            if (buttonTag == answerB)
            {
                score += 2;
            }

            if (buttonTag == answerC)
            {
                score += 4;       
            }

            if(questionNumber == totalQuestions)
            {            
                showFinalAnswer(score);
                questionNumber = 0;
                score = 0;
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int number)
        {
            switch (number) 
            {
                case 1:
                    question.Text = "Pytanie 1";
                    button1.Text = "Odpowiedz a";
                    button2.Text = "Odpowiedz b";
                    button3.Text = "Odpowiedz c";
                    break;

                case 2:
                    question.Text = "Pytanie 2";
                    button1.Text = "Odpowiedz a";
                    button2.Text = "Odpowiedz b";
                    button3.Text = "Odpowiedz c";
                    break;

                case 3:
                    question.Text = "Pytanie 3";
                    button1.Text = "Odpowiedz a";
                    button2.Text = "Odpowiedz b";
                    button3.Text = "Odpowiedz c";
                    break;

                case 4:
                    question.Text = "Pytanie 4";
                    button1.Text = "Odpowiedz a";
                    button2.Text = "Odpowiedz b";
                    button3.Text = "Odpowiedz c";
                    break;

                case 5:
                    question.Text = "Pytanie 5";
                    button1.Text = "Odpowiedz a";
                    button2.Text = "Odpowiedz b";
                    button3.Text = "Odpowiedz c";
                    break;
            }

        }

        private void showFinalAnswer(int score)
        {
            if (score < 10)
            {
                MessageBox.Show(
                    "Quiz zakończony!" + Environment.NewLine +
                    "Wyswietlam wariant 1" + Environment.NewLine +
                    "Wcisnij OK aby zagrać ponownie"
                    );
            }

            if (score >= 10 && score < 20)
            {
                MessageBox.Show(
                    "Quiz zakończony!" + Environment.NewLine +
                    "Wyswietlam wariant 2" + Environment.NewLine +
                    "Wcisnij OK aby zagrać ponownie"
                    );
            }

            if (score >= 20)
            {
                MessageBox.Show(
                    "Quiz zakończony!" + Environment.NewLine +
                    "Wyswietlam wariant 3" + Environment.NewLine +
                    "Wcisnij OK aby zagrać ponownie"
                    );
            }
        }
    }
}
