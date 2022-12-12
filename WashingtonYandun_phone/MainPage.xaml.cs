namespace WashingtonYandun_phone;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			wy_recharge.Text = $"Clicked {count} time";
		else
            wy_recharge.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(wy_recharge.Text);
	}
}

