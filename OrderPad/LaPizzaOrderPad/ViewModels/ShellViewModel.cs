using Caliburn.Micro;
using LaPizzaOrderPad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LaPizzaOrderPad.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {

        private BindableCollection<FoodOrder> _order = new BindableCollection<FoodOrder>();
        private FoodOrder _fullOrder;
        private string _foodItem;
        private double _price;

        public ShellViewModel()
        {
            Menu.Add(new FoodOrder { FoodItem = "Large", Price = 16.00 });
            Menu.Add(new FoodOrder { FoodItem = "Medium", Price = 14.50 });

        }
    }
}
