namespace opg7Menu;

public partial class MainPage : ContentPage
{
  

    public MainPage()
    {
        InitializeComponent();
    }


    private void MenuItem_OnClicked(object? sender, EventArgs e)
    {
        var menuItem = (MenuItem) sender;
        lbl.Text += menuItem.Text +"\n";
    }
}