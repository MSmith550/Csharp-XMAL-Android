using System.ComponentModel;
using TabletLearner2.ViewModels;
using Xamarin.Forms;

namespace TabletLearner2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}