using System;
using Xamarin.Forms;

namespace CCFCKitchenApp
{
	public partial class CCFCKitchenAppPage : ContentPage
	{
		public CCFCKitchenAppPage()
		{
			InitializeComponent();
			Title = "Home";
			var tapGestureRecognizer = new TapGestureRecognizer();

			tapGestureRecognizer.Tapped += (s, e) => {
				OnTapGestureRecognizerTapped(s,e);
			};

			drinksItemImg.GestureRecognizers.Add(tapGestureRecognizer);
			foodItemImg.GestureRecognizers.Add(tapGestureRecognizer);
			dessertsItemImg.GestureRecognizers.Add(tapGestureRecognizer);
			beveragesItemImg.GestureRecognizers.Add(tapGestureRecognizer);

		}

		void OnTapGestureRecognizerTapped(object sender, EventArgs args){
			var imageSender = (Image)sender;
			Navigation.PushAsync(new CCFCKitchenAppFoodPage());
		}
	}
}
