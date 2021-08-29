using ArabaTakip.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ArabaTakip.Views
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