namespace CustomPickerDemo.Portable.iOS
{
	using System;
	using System.Collections.Generic;

	using Foundation;
	using UIKit;

	public class ListPickerViewModel<TItem> : UIPickerViewModel
	{
		public TItem SelectedItem { get; private set; }

		IList<TItem> _items;
		public IList<TItem> Items
		{
			get { return _items; }
			set { _items = value; Selected(null, 0, 0); }
		}

		public UIColor TextColor { get; set; }

		public ListPickerViewModel()
		{
		}

		public ListPickerViewModel(IList<TItem> items, UIColor textColor)
		{
			Items = items;
			TextColor = textColor;
		}

		public event EventHandler<EventArgs> ValueChanged;

		public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
		{
			if (NoItem(0))
				return 1;
			return Items.Count;
		}

		public override string GetTitle(UIPickerView pickerView, nint row, nint component)
		{
			if (NoItem(row))
				return "";
			var item = Items[(int)row];
			return GetTitleForItem(item);
		}

		public override void Selected(UIPickerView pickerView, nint row, nint component)
		{
			if (NoItem(row))
				SelectedItem = default(TItem);
			else
			{
				SelectedItem = Items[(int)row];

				if (ValueChanged != null)
				{
					ValueChanged(this, new EventArgs());
				}
			}
		}

		public override nint GetComponentCount(UIPickerView pickerView)
		{
			return 1;
		}

		public override NSAttributedString GetAttributedTitle(UIPickerView pickerView, nint row, nint component)
		{
			string title = GetTitle(pickerView, row, component);
			return new NSAttributedString(title, null, TextColor);
		}

		public virtual string GetTitleForItem(TItem item)
		{
			return item.ToString();
		}

		bool NoItem(nint row)
		{
			return Items == null || row >= Items.Count;
		}
	}
}