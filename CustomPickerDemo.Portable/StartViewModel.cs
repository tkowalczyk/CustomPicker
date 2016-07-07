namespace CustomPickerDemo.Portable
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using System.Windows.Input;

	using Xamarin.Forms;

	public class StartViewModel
	{
		public IEnumerable<CustomObject> ObjectList { get; set; }
		public CustomObject SelectedItem { get; set; }

		public StartViewModel()
		{
			ObjectList = new List<CustomObject>()
			{
				new CustomObject()
				{
					Key = 1,
					Value = "one"
				},
				new CustomObject()
				{
					Key = 2,
					Value = "two"
				},
				new CustomObject()
				{
					Key = 3,
					Value = "three"
				},
				new CustomObject()
				{
					Key = 4,
					Value = "four"
				}
			};

			SelectedItem = ObjectList.FirstOrDefault();
		}

		private ICommand checkSelectedCommand;
		public ICommand CheckSelectedCommand
		{
			get { return checkSelectedCommand ?? (checkSelectedCommand = new Command(async () => await CheckSelected())); }
		}

		private async Task CheckSelected()
		{
			var whatIsSelected = SelectedItem;
			await Task.FromResult(0);
		}
	}
}