///Kyler Campbell
/// June 2, 2018
/// MathTutor
/// Create prgram that ansers simple math equations with numbers 1-10
/// 
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

namespace u5Quadratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create 2 random numbers and a random sign
        Random rnumber = new Random();
        int number_1;
        int number_2;
        int rnumber_Sign;


        // 4 signs from string
        string[] MathSign = new string[4];



        public MainWindow()
        {
            // Different math signs
            MathSign[0] = "+";
            MathSign[1] = "-";
            MathSign[2] = "*";
            MathSign[3] = "/";



            InitializeComponent();


            MakeQuestion();
        }
        public void MakeQuestion()
        {

            // generate number from 1-10 and a sign from ethier +,-,*,/
            number_1 = rnumber.Next(1, 11);
            number_2 = rnumber.Next(1, 11);
            rnumber_Sign = rnumber.Next(0, 4);
            //Create question
            string randomQuestion = number_1.ToString() + MathSign[rnumber_Sign] + number_2.ToString();
            Question.Text = randomQuestion;

        }







        //When Clicked
        private void btn_Click(object sender, RoutedEventArgs e)
        {

            string str_MathAnswer;
            int int_MathAnswer;


            //If its an addition question
            if (MathSign[rnumber_Sign] == "+")
            {
                int_MathAnswer = number_1 + number_2;
                str_MathAnswer = int_MathAnswer.ToString();
                if (AnswerBox.Text == str_MathAnswer)
                {
                    MessageBox.Show("Correct");
                    MakeQuestion();
                }
                else
                {
                    MessageBox.Show("Incorrect");
                }
            }

            //If the question is subtraction
            if (MathSign[rnumber_Sign] == "-")
            {
                int_MathAnswer = number_1 - number_2;
                str_MathAnswer = int_MathAnswer.ToString();
                if (AnswerBox.Text == str_MathAnswer)
                {
                    MessageBox.Show("Correct");
                    MakeQuestion();
                }
                else
                {
                    MessageBox.Show("Incorrect");
                }
            }

            //If the question is division
            if (MathSign[rnumber_Sign] == "/")
            {
                int_MathAnswer = number_1 / number_2;
                str_MathAnswer = int_MathAnswer.ToString();
                if (AnswerBox.Text == str_MathAnswer)
                {
                    MessageBox.Show("Correct");
                    MakeQuestion();
                }
                else
                {
                    MessageBox.Show("Incorrect");
                }
            }

            //If the question is multiplication
            if (MathSign[rnumber_Sign] == "*")
            {
                int_MathAnswer = number_1 * number_2;
                str_MathAnswer = int_MathAnswer.ToString();
                if (AnswerBox.Text == str_MathAnswer)
                {
                    MessageBox.Show("Correct");
                    MakeQuestion();
                }
                else
                {
                    MessageBox.Show("Incorrect");
                }
            }





        }
    }
}