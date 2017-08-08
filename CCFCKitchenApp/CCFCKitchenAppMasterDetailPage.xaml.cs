using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCKitchenApp
{
	public partial class CCFCKitchenAppMasterDetailPage : MasterDetailPage
	{
		public List<SideMenuItemModel> menuList { get; set; }

		public CCFCKitchenAppMasterDetailPage()
		{
			InitializeComponent();
			BindingContext = new MenuViewModel();
			NavigationPage.SetHasNavigationBar(this, false);
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(CCFCKitchenAppPage)));
			navigationDrawerList.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
			{
				var item = (SideMenuItemModel)e.SelectedItem;
				Type page = item.TargetType;

				if (item.Title.Equals("Logout"))
				{
					//Application.Current.MainPage = new SS_LoginPage();
					Navigation.PopToRootAsync();
				}
				else
				{
					Detail = new NavigationPage((Page)Activator.CreateInstance(page));
					IsPresented = false;
				}
			};
		}
	}
}
