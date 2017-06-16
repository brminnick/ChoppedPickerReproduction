using Xamarin.Forms;

namespace ChoppedPickerReproduction
{
    public class PickerPage : ContentPage
    {
        public PickerPage()
        {
            var viewModel = new PickerViewModel();
            BindingContext = viewModel;

            var picker = new Picker
            {
                HorizontalOptions = LayoutOptions.End
            };
            picker.SetBinding(Picker.ItemsSourceProperty, nameof(viewModel.PickerNumberList));
            picker.SetBinding(Picker.SelectedIndexProperty, nameof(viewModel.SelectedNumberIndex));

            var puzzleTextLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Number",
                FontAttributes = FontAttributes.Bold
            };

			var layout = new StackLayout
			{
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
            layout.Children.Add(puzzleTextLabel);
            layout.Children.Add(picker);

            Content = layout;
        }
    }
}
