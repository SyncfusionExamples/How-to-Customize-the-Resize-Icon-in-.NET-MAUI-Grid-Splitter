# How to Customize the Resize Icon in .NET MAUI Grid Splitter

This repository contains a sample that demonstrates how to customize the resize icon in the .NET MAUI Grid Splitter control. By default, the `SfGridSplitter` displays a standard resize handle between panes. However, you can replace the default resize icon with a custom image that better matches your application's design and branding requirements.

Customizing the resize icon helps improve the visual appearance of the splitter and provides a more personalized user experience. The `ResizeIconTemplate` property allows developers to define custom content that will be displayed as the resize handle. This content can be an image, icon, shape, or any other .NET MAUI view.

In this example, a custom image is assigned to the splitter's resize handle using a `DataTemplate`. When the application runs, the specified image is displayed between the panes, allowing users to identify and interact with the splitter more easily.

## Sample

### XAML

```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:gridSplitter="clr-namespace:Syncfusion.Maui.GridSplitter;assembly=Syncfusion.Maui.GridSplitter"
             x:Class="GridSplitter.MainPage">

    <gridSplitter:SfGridSplitter x:Name="gridSplitter">

        <gridSplitter:SplitterPane BackgroundColor="AntiqueWhite">
            <Label Text="Pane 1"
                   HorizontalTextAlignment="Center"
                   VerticalTextAlignment="Center" />
        </gridSplitter:SplitterPane>

        <gridSplitter:SplitterPane BackgroundColor="RosyBrown">
            <Label Text="Pane 2"
                   HorizontalTextAlignment="Center"
                   VerticalTextAlignment="Center" />
        </gridSplitter:SplitterPane>

    </gridSplitter:SfGridSplitter>

</ContentPage>
```

### C#

```csharp
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
```

## Explanation

The `ResizeIconTemplate` property is used to customize the resize handle displayed by the `SfGridSplitter`. The property accepts a `DataTemplate`, enabling developers to define custom visual content for the resize indicator.

In this example:

- The Grid Splitter contains two resizable panes.
- Each pane displays simple text content.
- A custom image named `dotnet_bot.png` is assigned to the resize icon.
- The image is displayed between the panes instead of the default resize handle.
- The custom icon retains the splitter's resizing functionality.
- Users can drag the custom icon to resize adjacent panes.

## Output

When the application runs, the following behavior can be observed:

- Two panes are displayed inside the Grid Splitter.
- A custom resize icon appears between the panes.
- The custom image replaces the default splitter resize icon.
- Users can drag the custom image to resize the panes.
- The pane sizes are updated dynamically during interaction.
- The customized resize handle improves the overall visual appearance of the layout.

## Use Cases

Custom resize icons can be useful in the following scenarios:

- Enterprise applications with custom branding requirements.
- Dashboard layouts with themed user interfaces.
- Design-focused applications that require a unique appearance.
- Applications that use icon libraries instead of standard controls.
- Products that need a consistent visual language across all UI elements.

## Conclusion

The .NET MAUI Grid Splitter provides the `ResizeIconTemplate` property to easily customize the appearance of the resize handle. By defining a custom `DataTemplate`, developers can replace the default resize icon with any image or visual element while preserving the built-in resizing behavior. This flexibility makes it easy to create visually appealing and branded application layouts.