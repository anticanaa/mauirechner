using MauiAppRechner.ViewModel;

namespace MauiAppRechner
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new RechnerViewModel();
        }

    }

}
