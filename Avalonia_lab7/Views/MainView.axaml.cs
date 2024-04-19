using Avalonia.Controls;

using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Diagnostics;

namespace Avalonia_lab7.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();

    }
    Dictionary<string, int> Czworki = new Dictionary<string, int>();
    public void metoda_click_button(object sender, RoutedEventArgs e)
    {
        for(int i = 0; i < Dane.Text.Length-3; i++)
        {
            string czworka = Dane.Text.Substring(i, 4);
            int v;
            if (Czworki.TryGetValue(czworka, out v))
            {
                Czworki[czworka]++;
            }
            else
            {
                Czworki[czworka] = 1;
            }
        }

        string output = "";
        foreach (string key in Czworki.Keys)
        {
            output = output + key + ":" + Czworki[key] + "  ";
        }
        Output.Text = output;

        Czworki.Clear();
    }
}
