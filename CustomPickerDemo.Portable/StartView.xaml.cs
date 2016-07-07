namespace CustomPickerDemo.Portable
{
	using Xamarin.Forms;

	public partial class StartView : ContentPage
	{
		public StartView()
		{
			InitializeComponent();

			BindingContext = new StartViewModel();
		}
	}
}