using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg7Menu;

public partial class opg8 : ContentPage
{
    
    public opg8()
    {
        InitializeComponent();
       
    }

    private void RadioButton_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        if(e.Value)
        {
            var rb = (RadioButton)sender!;
            radio.Text = "radiobutton: " + rb.Content.ToString() +" ";  
        }
    }

    private void CHB_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        string result = "checkboxes: ";

        if (Lemon.IsChecked) result += "Lemon ";
        if (Orange.IsChecked) result += "Orange ";
        if (Banana.IsChecked) result += "Banana ";

        chb.Text = result;
    }
}