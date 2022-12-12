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
        //wy_result.Text = "Hola mundo";
        //var s = sender.ToString();

    }
}

