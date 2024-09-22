namespace MauiApp9;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		//MainPage = new StackLayoutDemo();
		//MainPage = new HorizontalStackLayoutDemo();
		//MainPage = new GridLayoutDemo();
		//MainPage = new AbsoluteLayoutDemo();
		MainPage = new CalculatorLayout();
	}
}
