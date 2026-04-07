namespace opg1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnBigButtonClicked(object? sender, EventArgs e)
    {
        if (Box.IsChecked)
        {
            theButton.IsVisible = true;
        }
        else{ theButton.IsVisible = false;}
        
        
        SemanticScreenReader.Announce(theButton.Text);
    }

    private void TheButton_OnClicked(object? sender, EventArgs e)
    {
        if (theButton.IsPressed)
        {
            theButton.Text = "Remember you can have a great day if you make it a great day";
            theButton.TextColor = Colors.Red;
        }
      
    }
}