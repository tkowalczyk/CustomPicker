namespace CustomPickerDemo.Portable.CustomControls
{
	using System.Collections.Generic;

	using Xamarin.Forms;

	public class CustomObjectPicker : View
	{
		public static readonly BindableProperty ItemsSourceProperty =
		BindableProperty.Create("ItemsSource", typeof(IEnumerable<CustomObject>), typeof(CustomObjectPicker), null);

		public IEnumerable<CustomObject> ItemsSource
		{
			get { return (IEnumerable<CustomObject>)GetValue(ItemsSourceProperty); }
			set { SetValue(ItemsSourceProperty, value); }
		}

		public static readonly BindableProperty SelectedItemProperty =
			BindableProperty.Create("SelectedItem", typeof(object), typeof(CustomObjectPicker), null, BindingMode.TwoWay);

		public object SelectedItem
		{
			get { return (object)GetValue(SelectedItemProperty); }
			set { SetValue(SelectedItemProperty, value); }
		}

		public static readonly BindableProperty IsTransparentProperty =
			BindableProperty.Create("IsTransparent", typeof(bool), typeof(CustomObjectPicker), true);

		public bool IsTransparent
		{
			get { return (bool)GetValue(IsTransparentProperty); }
			set { SetValue(IsTransparentProperty, value); }
		}

		public static readonly BindableProperty TextColorProperty =
			BindableProperty.Create("TextColor", typeof(Color), typeof(CustomObjectPicker), Color.Default);

		public Color TextColor
		{
			get { return (Color)GetValue(TextColorProperty); }
			set { SetValue(TextColorProperty, value); }
		}
	}
}