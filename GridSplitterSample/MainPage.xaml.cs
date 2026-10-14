using Syncfusion.Maui.GridSplitter;

namespace GridSplitter
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            gridSplitter.ResizeIconTemplate = new DataTemplate(() =>
            {
                return new Image
                {
                    Source ="oip.webp",
                    WidthRequest = 25,
                    HeightRequest = 15
                };
            });
        }
       
       
    }
}
