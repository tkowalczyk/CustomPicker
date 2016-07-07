using System;
using System.ComponentModel;
using System.Linq;

using CustomPickerDemo.Portable.CustomControls;
using CustomPickerDemo.Portable.iOS;

using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomObjectPicker), typeof(CustomObjectPickerRenderer))]
namespace CustomPickerDemo.Portable.iOS
{
	public class CustomObjectPickerRenderer : ViewRenderer<CustomObjectPicker, UIPickerView>
	{
		CustomObjectPicker picker;
		ListPickerViewModel<CustomObject> viewModel;

		public CustomObjectPickerRenderer()
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<CustomObjectPicker> e)
		{
			base.OnElementChanged(e);

			var view = e.NewElement as CustomObjectPicker;

			if (e.NewElement == null)
			{
				return;
			}

			if (Control == null);
			{
				this.SetNativeControl(new UIPickerView());
			}

			this.SetModel(view);

			this.SetVisibilty(view);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			picker = Element;

			if (e.PropertyName == CustomObjectPicker.IsVisibleProperty.PropertyName)
				SetVisibilty(picker);

			this.SetModel(picker);
		}

		private void SetModel(CustomObjectPicker view)
		{
			viewModel = new ListPickerViewModel<CustomObject>(
				view.ItemsSource.ToList(), 
				view.TextColor.ToUIColor());
			
			viewModel.ValueChanged += (object s, EventArgs e) =>
			{
				Element.SelectedItem = viewModel.SelectedItem;
			};

			Control.Model = viewModel;
		}

		private void SetVisibilty(CustomObjectPicker view)
		{
			if (view.IsTransparent)
				Control.BackgroundColor = UIColor.Clear;
		}
	}
}