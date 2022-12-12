namespace WashingtonYandun_phone;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClickedAsync(object sender, EventArgs e)
    {
        bool wy_answer = await DisplayAlert(
            "Confirmacion",
            "Quiere proceder con la recarga?",
            "Si",
            "No"
            );

        if (wy_answer)
        {
            await DisplayAlert(
                "Listo!",
                "Recarga exitosa",
                "OK"
                );
        }
        else
        {
            await DisplayAlert(
                "Gracias!",
                "No recarga",
                "OK"
                );
        }
    }

    private void wy_change(object sender, CheckedChangedEventArgs e)
    {
        if (wy_t3.IsChecked)
        {
            wy_result.Text = $"ha seleccionado una recarga {wy_t3.Value} de dolares";
        }

        if (wy_t5.IsChecked)
        {
            wy_result.Text = $"ha seleccionado una recarga {wy_t5.Value} de dolares";
        }

        if (wy_t10.IsChecked)
        {
            wy_result.Text = $"ha seleccionado una recarga {wy_t10.Value} de dolares";
        }
    }
}

