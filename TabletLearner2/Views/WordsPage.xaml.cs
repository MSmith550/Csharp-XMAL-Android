using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TabletLearner2.Views
{

    public partial class WordsPage : ContentPage
    {
        Random rnd = new Random();
        int indexNumber;
        string heartWord;
        //need to have 5 lists. pre-k, k, 1, 2, 3
        string[] heartWordsList = {"The", "Of", "You", "And", "To", "How", "Out", "In", "Is", "For", "That", "It", "Their", "He", "Was", "His", "On", "Are", "Want",
                                "As", "With", "This", "They", "If", "Will", "At", "Be", "Or", "Have", "From", "Up", "One", "Had", "By", "But", "Not", "May", "What",
                                "All", "Were", "We", "When", "No", "Your", "Can", "Said", "There", "Down", "Now", "An", "Come"," Which"," She", "Do", "Came","These",
                                "him", "any", "very", "think", "because", "then", "put", "about", "good", "going", "own" , "so", "has", "old", "around", "walk", "only",
                                "them", "take", "saw", "too", "again", "our", "her", "go", "little", "every", "who", "both", "would", "see", "ask", "pretty", "been",
                                "does", "make", "could", "over", "away", "goes", "write", "like", "look", "where", "here", "long", "know", "after", "before", "always"};

        
        public WordsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            indexNumber = rnd.Next(heartWordsList.Length);
            heartWord = heartWordsList.GetValue(indexNumber).ToString();
            editor.Text = heartWord;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            // Get the text from the Label
            string textToSpeak = editor.Text;

            // Specify the speech rate (0.5 is slower, 2.0 is faster)
            float speechRate = 0.1f; // Adjust this value as needed


            // Speak the text using TextToSpeech API
            await TextToSpeech.SpeakAsync(textToSpeak, new SpeechOptions
            {
                Pitch = speechRate // Set the speech rate
            });

        }
    }
}