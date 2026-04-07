namespace opg6DockLayout;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();
    }

   
    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Button b = (Button) sender!;
        Editor.Text +=b.Text + "\n";
    }
}