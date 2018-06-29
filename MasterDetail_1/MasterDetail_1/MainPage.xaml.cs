using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail_1
{
	public partial class MainPage : MasterDetailPage
    {
        string[] menuItems = { "Page1", "Page2", "Page3" };

        public MainPage()
		{
			InitializeComponent();

            masterListView.ItemsSource = menuItems;

            // first thing shown is a Detail Page.  Set this page here
            Detail = new NavigationPage(new Page1());
            IsPresented = false;  // present master page?
        }

        private void masterListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menuChoice = (string)e.SelectedItem;

            if(menuChoice == menuItems[0]) 
                Detail = new NavigationPage(new Page1());
            else if(menuChoice == menuItems[1]) 
                Detail = new NavigationPage(new Page2());
            else if(menuChoice == menuItems[2]) 
                Detail = new NavigationPage(new Page3());

            IsPresented = false;  // present master page?

            // To deselect the item (otherwise it's highlighted when clicked on)
            masterListView.SelectedItem = null;
        }
    }
}
