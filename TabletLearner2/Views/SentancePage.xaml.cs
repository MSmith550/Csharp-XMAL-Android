using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabletLearner2.Views
{

    public partial class SentancePage : ContentPage
    {
        Random rnd = new Random();
        int indexNumber;
        string sentance;
        string[] sentanceList = {"I am Sam.", "I do not like that Sam I Am", "Do you like green eggs and ham?", "I do not like them",
            "Would you like the here or there?", "I would not like them anywhere", "Would you like them in a house?" ,
            "Would you like them with a mouse?" ,"Would you eat them in a box", "Would you eat them with a fox", "In a car?", "You may like them",
            "I do not like them in a box", "I do not like them with a fox", "It is sunny outside", "Look out the window", "Lets read a book",
            "Lets play a game", "I am upset", "I want to play with you", "I have good friends"};
        public SentancePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(sentanceList.Length);
            sentance = sentanceList.GetValue(indexNumber).ToString();
            editor.Text = sentance;
        }
    }
}