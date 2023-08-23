using poc_maui.Views;

namespace poc_maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
       
        MainPage = new AppShell();

        // Use this to check code with DataTemplateSelector
        //MainPage = new CollectionWithTemplatePage();
	}
}

