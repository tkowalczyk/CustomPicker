# CustomPicker
Sample project shows how to use UIPickerView in Xamarin.Forms.
This is only iOS version which is working based on `CustomRenderer`.

# Properties

All of the defined properties are bindable so you can easily use them in MVVM based applications.

- `ItemsSource` object of `IEnumerable` type,
- `SelectedItem`,
- `IsTransparent` defines if the background of the control should be transparent,
- `TextColor` defines text color for the control.

# Usage

	<?xml version="1.0" encoding="UTF-8"?>
	<ContentPage 
		xmlns="http://xamarin.com/schemas/2014/forms" 
		xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
		x:Class="CustomPickerDemo.Portable.StartView"
		xmlns:local="clr-namespace:CustomPickerDemo.Portable.CustomControls;assembly=CustomPickerDemo.Portable">
	<ContentPage.Content>

		<StackLayout
				VerticalOptions="Center">

			<local:CustomObjectPicker
					ItemsSource="{Binding ObjectList}"
					SelectedItem="{Binding SelectedItem}"
					IsTransparent="true"
					TextColor="Blue"
					/>

			<Button
					Text="Check"
					Command="{Binding CheckSelectedCommand}"/>
			
		</StackLayout>
		
	</ContentPage.Content>
</ContentPage>

# Screen

![](https://github.com/tkowalczyk/CustomPicker/blob/master/screen/screen.png)

# Author
Tomasz Kowalczyk
