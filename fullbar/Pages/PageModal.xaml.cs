using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fullbar
{
	public partial class PageModal : ContentPage
	{
		public PageModal()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync(true);
		}
	}
}
