using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabletLearner2.Views
{
    public partial class MathPage : ContentPage
    {
        Random rnd = new Random();
        int randomNumber1, randomNumber2, randomNumber3, answer, temp, indexNumber;
        string randomMathWord;
        string[] mathWordsList = {"How much is a dime?",
            "How much is a nickel?",
            "If sally has 3 apples and ben has 7 aples, How many apples do they have total?",
            "If you have 10 pencils and give 4 away, how many do you have left?",
            "If there are 3 birds in a tree and 3 more bird join them, how many birds are in the tree total?",
            "If you have 10 hearts and take 3 damage, how many hearts do you have left?",
            "How much is a penny?",
            "how much is 1 quarter and 2 dimes?",
            "how much is a quarter?",
            "If there is 10 apples in a tree and 4 fall down, how many are left in the tree?",
            "Sam has 10 stamps and Dan has 15 stamps, how many more stamps do they need to have 50?",
            "How much do you have if you take 4 away from 30?",
            "Ed has 100 stamps and he gave dave 30 of them, how many stamps does Ed have left?",
            "If Sam has 20 shoes, how many more does he need to have 50?",
            "What 2 numbers can be added together to reach 82?",
            "What is left if you take away 27 from 63?",
            "What do you have when you have 38 and add 42 to it?"};
        
        void level_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int Level = (int)level.Value;
            Levelset.Text = "Current Level set to: " + Level.ToString();
        }

        void SubtractionButton_Clicked(object sender, EventArgs e)
        {
            int Level = (int)level.Value;
            if (Level == 0)
            {
                randomNumber1 = rnd.Next(0, 10);
                randomNumber2 = rnd.Next(0, 10);
                if (randomNumber2 > randomNumber1)
                {
                    temp = randomNumber2;
                    randomNumber2 = randomNumber1;
                    randomNumber1 = temp;
                }
                editor.Text = randomNumber1.ToString() + " - " + randomNumber2.ToString() + " = ?";
                SubtractionAnswerButton.IsEnabled = true;
            }
            else if (Level == 1)
            {
                randomNumber1 = rnd.Next(0, 30);
                randomNumber2 = rnd.Next(0, 30);
                if (randomNumber2 > randomNumber1)
                {
                    temp = randomNumber2;
                    randomNumber2 = randomNumber1;
                    randomNumber1 = temp;
                }
                editor.Text = randomNumber1.ToString() + " - " + randomNumber2.ToString() + " = ?";
                SubtractionAnswerButton.IsEnabled = true;
            }
            else if (Level == 2)
            {
                randomNumber1 = rnd.Next(0, 50);
                randomNumber2 = rnd.Next(0, 50);
                if (randomNumber2 > randomNumber1)
                {
                    temp = randomNumber2;
                    randomNumber2 = randomNumber1;
                    randomNumber1 = temp;
                }
                editor.Text = randomNumber1.ToString() + " - " + randomNumber2.ToString() + " = ?";
                SubtractionAnswerButton.IsEnabled = true;
            }
        }

        void AdditionButton_Clicked(object sender, EventArgs e)
        {
            int Level = (int)level.Value;
            if (Level == 0)
            {
                randomNumber1 = rnd.Next(0, 10);
                randomNumber2 = rnd.Next(0, 10);
                editor.Text = randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = ?";
                AnswerButton.IsEnabled = true;
            }
            else if (Level == 1)
            {
                randomNumber1 = rnd.Next(0, 50);
                randomNumber2 = rnd.Next(0, 50);
                editor.Text = randomNumber1.ToString() + " + " + randomNumber2.ToString() + " = ?";
                AnswerButton.IsEnabled = true;
            }
            else if (Level == 2)
            {
                randomNumber1 = rnd.Next(0, 30);
                randomNumber2 = rnd.Next(0, 30);
                randomNumber3 = rnd.Next(0, 30);
                editor.Text = randomNumber1.ToString() + " + " + randomNumber2.ToString() + " + " + randomNumber3.ToString() + " = ?";
                AnswerButton.IsEnabled = true;
            }
        }

        void AdditionAnswer_Clicked(object sender, EventArgs e)
        {
            int Level = (int)level.Value;
            int userAnswer = Int32.Parse(usersAnswer.Text.ToString());
            if (Level == 0 || Level == 1)
            {
                answer = randomNumber1 + randomNumber2;
                if (userAnswer == answer)
                {
                    editor.Text = "The Answer is: " + answer + " correct";
                    AnswerButton.IsEnabled = false;
                }
                else
                {
                    editor.Text = "The Answer is: " + answer + " not correct";
                    AnswerButton.IsEnabled = false;
                }
            }
            else if (Level == 2)
            {
                answer = randomNumber1 + randomNumber2 + randomNumber3;
                if (userAnswer == answer)
                {
                    editor.Text = "The Answer is: " + answer + " correct";
                    AnswerButton.IsEnabled = false;
                }
                else
                {
                    editor.Text = "The Answer is: " + answer + " not correct";
                    AnswerButton.IsEnabled = false;
                }
            }
        }

        void SubtractionAnswer_Clicked(object sender, EventArgs e)
        {
            //int Level = (int)level.Value;
            int userAnswer = Int32.Parse(usersAnswer.Text.ToString());
            answer = randomNumber1 - randomNumber2;
            if (userAnswer == answer)
            {
                editor.Text = "The Answer is: " + answer + " correct";
                SubtractionAnswerButton.IsEnabled = false;
            }
            else
            {
                editor.Text = "The Answer is: " + answer + " not correct";
                SubtractionAnswerButton.IsEnabled = false;
            }
            
        }

        void MultiplacationButton_Clicked(object sender, EventArgs e) 
        {
            int Level = (int)level.Value;
            if (Level == 0)
            {
                randomNumber1 = rnd.Next(0, 10);
                randomNumber2 = rnd.Next(0, 10);
                editor.Text = randomNumber1.ToString() + " x " + randomNumber2.ToString() + " = ?";
                MultiplacationAnswerButton.IsEnabled = true;
            }
            else if (Level == 1)
            {
                randomNumber1 = rnd.Next(0, 10);
                randomNumber2 = rnd.Next(0, 20);
                editor.Text = randomNumber1.ToString() + " x " + randomNumber2.ToString() + " = ?";
                MultiplacationAnswerButton.IsEnabled = true;
            }
            else if (Level == 2)
            {
                randomNumber1 = rnd.Next(0, 20);
                randomNumber2 = rnd.Next(0, 20);
                editor.Text = randomNumber1.ToString() + " x " + randomNumber2.ToString() + " = ?";
                MultiplacationAnswerButton.IsEnabled = true;
            }
        }

        void MultiplacationAnswer_Clicked(object sender, EventArgs e) 
        {
            //int Level = (int)level.Value;
            int userAnswer = Int32.Parse(usersAnswer.Text.ToString());
            answer = randomNumber1 * randomNumber2;
            if (userAnswer == answer)
            {
                editor.Text = "The Answer is: " + answer + " correct";
                MultiplacationAnswerButton.IsEnabled = false;
            }
            else
            {
                editor.Text = "The Answer is: " + answer + " not correct";
                MultiplacationAnswerButton.IsEnabled = false;
            }

        }

        void MathWord_Clicked(object sender, EventArgs e)
        {
            
            indexNumber = rnd.Next(mathWordsList.Length);
            randomMathWord = mathWordsList.GetValue(indexNumber).ToString();
            editor.Text = randomMathWord;
        }

        void DoubleQuestion_Clicked(object sender, EventArgs e)
        {
            randomNumber1 = rnd.Next(0, 10);
            editor.Text = randomNumber1.ToString() + " + " + randomNumber1.ToString() + " = ?";
            DoubleQuestionAnswerButton.IsEnabled = true;
        }

        void DoubleQuestionAnswer_Clicked(object sender, EventArgs e)
        {
            int userAnswer = Int32.Parse(usersAnswer.Text.ToString());
            answer = randomNumber1 + randomNumber1;
            if (userAnswer == answer)
            {
                editor.Text = "The Answer is: " + answer + " correct";
                DoubleQuestionAnswerButton.IsEnabled = false;
            }
            else
            {
                editor.Text = "The Answer is: " + answer + " not correct";
                DoubleQuestionAnswerButton.IsEnabled = false;
            }
        }

        public MathPage()
        {
            InitializeComponent();
        }

    }
}