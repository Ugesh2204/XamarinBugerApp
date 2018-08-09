using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BurgerBurger.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodListsPage : ContentPage
	{
		public FoodListsPage ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<FoodListModel>
            {
                new FoodListModel { FoodName ="Burger", ImageUrl="burger.png"},
                new FoodListModel { FoodName ="Pizza", ImageUrl = "pizza.png"},
                new FoodListModel { FoodName ="Sandwich", ImageUrl = "sandwich.png"},
                new FoodListModel { FoodName ="Coffee", ImageUrl = "coffee.png"},
                new FoodListModel { FoodName ="Beer", ImageUrl = "Beer.png"},
                new FoodListModel { FoodName ="Desserts", ImageUrl = "Desserts.png"}

            };
		}
	}
}