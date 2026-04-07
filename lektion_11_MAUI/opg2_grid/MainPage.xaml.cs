namespace opg2_grid;

public partial class MainPage : ContentPage
{
  

    public MainPage()
    {
        InitializeComponent();
    }


    private void Button_OnClicked(object? sender, EventArgs e)
    {
        if (upper.IsPressed)
        {
            (l1.Text, r1.Text) = (r1.Text, l1.Text);
        }

        if (lower.IsPressed)
        {
            (l2.Text, r2.Text) = (r2.Text, l2.Text);
        }
    }
}