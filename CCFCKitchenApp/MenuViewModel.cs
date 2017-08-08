using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CCFCKitchenApp
{
	public class MenuViewModel
	{
		public ObservableCollection<SideMenuItemModel> MenuItems
		{
			get;
		}
		public MenuViewModel()
		{
			MenuItems = new ObservableCollection<SideMenuItemModel>();

			var page1 = new SideMenuItemModel() { Title = "Home", Icon = "SideMenu_Home.png"};
			var page2 = new SideMenuItemModel() { Title = "Menu", Icon = "SideMenu_Checklist.png" };
			var page3 = new SideMenuItemModel() { Title = "Orders", Icon = "SideMenu_LegalHelp.png" };
			var page4 = new SideMenuItemModel() { Title = "Basket", Icon = "SideMenu_Video.png"};
			var page5 = new SideMenuItemModel() { Title = "History", Icon = "SideMenu_FollowUp.png"};
			var page6 = new SideMenuItemModel() { Title = "Logout", Icon = "SideMenu_ContactUs.png"};


			// Adding menu items to menuList
			MenuItems.Add(page1);
			MenuItems.Add(page2);
			MenuItems.Add(page3);
			MenuItems.Add(page4);
			MenuItems.Add(page5);
			MenuItems.Add(page6);

		}
	}
}