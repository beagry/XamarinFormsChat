using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsChat
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			var chatPage = new ChatPage();
			await Navigation.PushAsync(chatPage);
		}
	}
}

