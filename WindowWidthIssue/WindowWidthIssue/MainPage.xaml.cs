namespace WindowWidthIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void MainPage_OnLoaded(object sender, EventArgs e) 
	{
		if (this.Width < 0)
			throw new Exception("Error");
	}
}

