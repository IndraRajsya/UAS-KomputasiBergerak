namespace UasKomberTemplate;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navPage = new NavigationPage(new LoginPage());

		navPage.BarBackground = Colors.Green;
		navPage.BarTextColor =  Colors.Wheat;
		
		

		MainPage = navPage;
	}
}
