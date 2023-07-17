using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabletLearner2.Views
{

    public partial class WordsPage : ContentPage
    {
        Random rnd = new Random();
        int indexNumber;
        string heartWord;
        //need to have 5 lists. pre-k, k, 1, 2, 3
        string[] heartWordsList = {"The", "My", "Is", "I", "In", "A", "For", "Am", "Here", "At", "It", "Be", "And", "Go", "Like", "To", "Not", "You", "Do",
            "To", "Can", "Are", "Did", "Will", "With", "Me", "No", "Say", "All", "Was", "So", "Now", "Have", "Come", "They", "This", "Said", "Down",
            "That", "Ate", "Our", "Where", "Must", "He", "Who", "What", "We", "She", "But", "There", "Own", "Make", "Want", "Saw", "Please", "Good",
            "New", "One", "Out", "Two", "Cat", "Fly", "Ship", "Flower", "Cat", "Bat", "Car", "Sun", "Big", "Light"};

        
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
    }
}