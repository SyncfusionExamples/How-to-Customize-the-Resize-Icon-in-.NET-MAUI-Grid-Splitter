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
                    Source ="resize_horizontal.jpg",
                    WidthRequest = 50,
                    HeightRequest = 50
                };
            });
        }
       
       
    }
}
