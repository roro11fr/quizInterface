using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizInterface
{
    public partial class Form1 : Form
    {
        // quiz game variables

        int correctAnswer;
        int questionNumber = 1;
        int score, percentage, totalQuestions;
        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }

        private void checkAnswer(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "AI raspuns" + score + "atatea intrebari corecte" + Environment.NewLine +
                    "Procentul tau este" + percentage + Environment.NewLine +
                    "Click to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion (int gnum)
        {
            switch (gnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.descărcare;

                    lblQuestion1.Text = "Ce echipa este echipa din imagine?";

                    button1.Text = "MAnchester City";
                    button2.Text = "Bayern Munchen";
                    button3.Text = "Manchester UNited";
                    button4.Text = "Manchester United";

                    correctAnswer = 4;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.balonD_or;

                    lblQuestion1.Text = "Care este fotbalistul cu cele mai multe balone de aur?";

                    button1.Text = "Lionel Pessi";
                    button2.Text = "Cristiano Ronaldo";
                    button3.Text = "Pele";
                    button4.Text = "Maradona";

                    correctAnswer = 1;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.bani;

                    lblQuestion1.Text = "Care este fotbalistul cel mai scump din istorie?";

                    button1.Text = "Neymar Jr";
                    button2.Text = "Mbappe";
                    button3.Text = "Ronaldo";
                    button4.Text = "Messi";

                    correctAnswer = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.champleague1;

                    lblQuestion1.Text = "Cine este denumit Mister CHampions League?";

                    button1.Text = "Messi";
                    button2.Text = "Cristiano Ronaldo";
                    button3.Text = "Zidane";
                    button4.Text = "Benzema";

                    correctAnswer = 2;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.champleague2;

                    lblQuestion1.Text = "Care echipa are cele mai multe trofee Champ League?";

                    button1.Text = "Fc Varcelona";
                    button2.Text = "MAn Utd";
                    button3.Text = "Ac Milan";
                    button4.Text = "Ream Madrid";

                    correctAnswer = 4;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.goldenboy;

                    lblQuestion1.Text = "Cine a fost denumit Golden Boy in 2015?";

                    button1.Text = "Messi";
                    button2.Text = "Mbappe";
                    button3.Text = "Martial";
                    button4.Text = "Renato Sanches";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.dubai;

                    lblQuestion1.Text = "Care este fotbalistul cu cele mai multe d'or uri?";

                    button1.Text = "Ronaldo";
                    button2.Text = "Messi";
                    button3.Text = "Zidane";
                    button4.Text = "Roaldinho";

                    correctAnswer = 1;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.ozil;

                    lblQuestion1.Text = "La ce echipa nu a jucat Mesut Ozil";

                    button1.Text = "Fenerbache";
                    button2.Text = "Real Madrid";
                    button3.Text = "Arsenal";
                    button4.Text = "Bayern Munchen";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.balonD_or;

                    lblQuestion1.Text = "Care este tara cu cele mai multe world cup uri?";

                    button1.Text = "Argentina";
                    button2.Text = "Romania";
                    button3.Text = "Germania";
                    button4.Text = "Brazilia";

                    correctAnswer = 4;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.gunners;

                    lblQuestion1.Text = "Ce echipa este denumite 'The Gunners'?";

                    button1.Text = "Arsenal";
                    button2.Text = "Man Utd";
                    button3.Text = "Barcelona";
                    button4.Text = "Spurs";

                    correctAnswer = 1;

                    break;
            }
        }
    }
}
