using System;
using System.Collections.Generic;
using System.ComponentModel;
using TabletLearner2.Models;
using TabletLearner2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabletLearner2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}