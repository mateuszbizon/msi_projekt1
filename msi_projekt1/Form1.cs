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
                score += 3;       
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
                    question.Text = "Pytanie 1: \n Ile godzin dziennie spędzasz przy komputerze?";
                    button1.Text = "Odpowiedz A: 0 - 2h";
                    button2.Text = "Odpowiedz B: 2 - 5h";
                    button3.Text = "Odpowiedz C: +5h";
                    break;

                case 2:
                    question.Text = "Pytanie 2: \n Na co przeznaczasz czas przy komputerze";
                    button1.Text = "Odpowiedz A: Praca";
                    button2.Text = "Odpowiedz B: Nauka";
                    button3.Text = "Odpowiedz C: Rozrywka";
                    break;

                case 3:
                    question.Text = "Pytanie 3: \n Jak reagujesz gdy ktoś odciąga Cie od komputera?";
                    button1.Text = "Odpowiedz A: Odchodzę bez problemu";
                    button2.Text = "Odpowiedz B: Ociągam się ale odchodzę";
                    button3.Text = "Odpowiedz C: Bardzo się denerwuję";
                    break;

                case 4:
                    question.Text = "Pytanie 4: \n Czy potrafisz znaleźć sobie inne zajęcie gdy nie masz dostępu do komputera?";
                    button1.Text = "Odpowiedz A: Bardzo czeęsto i bez problemu";
                    button2.Text = "Odpowiedz B: Nie zawsze";
                    button3.Text = "Odpowiedz C: Nigdy";
                    break;

                case 5:
                    question.Text = "Pytanie 5: \n Czy zdarza Ci się nie robić jakieś ważnej rzeczy np. odrobić zadanie domowe?";
                    button1.Text = "Odpowiedz A: Nie, nigdy";
                    button2.Text = "Odpowiedz B: Tak, czasami";
                    button3.Text = "Odpowiedz C: Tak, bardzo często";
                    break;
            }

        }

        private void showFinalAnswer(int score)
        {
            if (score < 10)
            {
                MessageBox.Show(
                    "Quiz zakończony!" + Environment.NewLine +
                    "Nie jesteś uzależniony. Gratulacje!" + Environment.NewLine +
                    "Wcisnij OK aby zagrać ponownie"
                    );
            }

            if (score >= 10 && score < 15)
            {
                MessageBox.Show(
                    "Quiz zakończony!" + Environment.NewLine +
                    "Jesteś uzależniony w niewielkim stopniu. Popracuj nad sobą!" + Environment.NewLine +
                    "Wcisnij OK aby zagrać ponownie"
                    );
            }

            if (score >= 15)
            {
                MessageBox.Show(
                    "Quiz zakończony!" + Environment.NewLine +
                    "Jesteś uzależniony. Natychmiast zacznij zmieniać swoje nawyki!" + Environment.NewLine +
                    "Wcisnij OK aby zagrać ponownie"
                    );
            }
        }
    }
}
