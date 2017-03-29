using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fullbar
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		async void Tab_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new TabPage());
		}

		async void Car_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new TesteCarrousel());
		}

		async void Modal_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new PageModal());
		}

		async void Cont_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new Page1());
		}

	}
}
