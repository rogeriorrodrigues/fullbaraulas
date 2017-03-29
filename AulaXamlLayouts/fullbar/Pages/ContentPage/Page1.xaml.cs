using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fullbar
{
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();

		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{

			await Navigation.PushModalAsync(new NavigationPage(new PageModal()), true);

		}
	}
}
