# How to Customize the Resize Icon in .NET MAUI Grid Splitter

The .NET MAUI `SfGridSplitter` control provides a resize indicator that helps users identify the draggable area between adjacent panes. While the default resize icon is suitable for most applications, some scenarios require a custom visual appearance to align with application branding or design requirements. By customizing the resize icon, developers can provide a unique visual experience while retaining the splitter's built-in resizing functionality.

This example demonstrates how to replace the default resize icon by assigning a custom `DataTemplate` to the `ResizeIconTemplate` property. The template displays an image as the resize indicator, allowing the splitter to present a customized appearance.

## Step 1: Define the Grid Splitter Layout in XAML

The following XAML creates an `SfGridSplitter` with two resizable panes. The `x:Name` attribute allows the splitter instance to be accessed from the code-behind, where the custom resize icon template is configured.

```xaml
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
```

## Step 2: Customize the Resize Icon in C#

The following code assigns a custom `DataTemplate` to the `ResizeIconTemplate` property. The template displays the `dotnet_bot.png` image as the resize indicator, replacing the default resize icon displayed by the splitter.

```csharp
public MainPage()
{
    InitializeComponent();

    gridSplitter.ResizeIconTemplate = new DataTemplate(() =>
    {
        return new Image
        {
            Source = "dotnet_bot.png",
            WidthRequest = 86,
            HeightRequest = 98
        };
    });
}
```

## Output

- Displays two panes separated by a draggable splitter.
- Replaces the default resize icon with a custom image.
- Shows the specified image as the splitter's resize indicator.
- Preserves the pane resizing behavior.
- Enables a customized visual appearance for the splitter.
- Allows the resize handle to match application-specific branding and design requirements.

Using the `ResizeIconTemplate` property, you can customize the resize indicator of the `SfGridSplitter` to create a more engaging and visually consistent user experience while maintaining the control's built-in resizing functionality.
