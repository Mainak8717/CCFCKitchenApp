using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCKitchenApp
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			var tapGestureRecognizerLogin = new TapGestureRecognizer();
			tapGestureRecognizerLogin.NumberOfTapsRequired = 1;
			tapGestureRecognizerLogin.Tapped += (s, e) => {
				OnLoginButtonClicked();
			};
			LoginInLbl.GestureRecognizers.Add(tapGestureRecognizerLogin);	

		}
		void OnLoginButtonClicked()
		{
			Navigation.PushAsync(new CCFCKitchenAppMasterDetailPage());
		}
	}
}
