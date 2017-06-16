using Xamarin.Forms;

namespace ChoppedPickerReproduction
{
    public class App : Application
    {
        public App() => MainPage = new NavigationPage(new PickerPage());
    }
}
