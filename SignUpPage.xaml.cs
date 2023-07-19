namespace UasKomberTemplate;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {


		Navigation.PushAsync(new LoginPage());
    }
}