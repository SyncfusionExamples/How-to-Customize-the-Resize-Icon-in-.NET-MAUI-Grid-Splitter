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
                    Source = "dotnet_bot.png",
                    WidthRequest = 50,
                    HeightRequest = 50
                };
            });
        }
       
       
    }
}
