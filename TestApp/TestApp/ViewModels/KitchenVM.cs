using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TestApp.Models;

namespace TestApp.ViewModels
{
    class KitchenVM
    {
		private ObservableCollection<Meals> _colMeals;

		public ObservableCollection<Meals> ColMeals
		{
			get { return _colMeals; }
			set { _colMeals = value; }
		}
		private ObservableCollection<Contents> _colContent;

		public ObservableCollection<Contents> ColContent
		{
			get { return _colContent; }
			set { _colContent = value; }
		}
		private ObservableCollection<Recips> _colRecips;

		public ObservableCollection<Recips> ColRecips
		{
			get { return _colRecips; }
			set { _colRecips = value; }
		}

		public KitchenVM()
		{
			ColContent = new ObservableCollection<Contents>();
			ColContent.Add(new Contents(1, "How to make a better kitchen", "Lession 1", "Mask.png"));
			ColContent.Add(new Contents(1, "How to make a better kitchen", "Lession 2", "Chef.png"));
			ColContent.Add(new Contents(1, "How to make a better kitchen", "Lession 3", "Mask.png"));
			ColContent.Add(new Contents(1, "How to make a better kitchen", "Lession 4", "Chef.png"));
			ColContent.Add(new Contents(1, "How to make a better kitchen", "Lession 5", "Mask.png"));

			ColMeals = new ObservableCollection<Meals>();
			ColMeals.Add(new Meals(1, "Monday", "Bengus Sardiness", "Group.png"));
			ColMeals.Add(new Meals(2, "Tuesday", "Stir-Fried Tofu", "Rounded.png"));
			ColMeals.Add(new Meals(3, "Wendsday", "Bengus Sardiness", "Group.png"));
			ColMeals.Add(new Meals(4, "Thursday", "Stir-Fried Tofu", "Rounded.png"));
			ColMeals.Add(new Meals(5, "Friday", "Bengus Sardiness", "Group.png"));
			ColMeals.Add(new Meals(6, "Saturday", "Stir-Fried Tofu", "Rounded.png"));

			ColRecips = new ObservableCollection<Recips>();
			ColRecips.Add(new Recips(1, "Taba ng talangka", "Mask1.png"));
			ColRecips.Add(new Recips(1, "Pancit palabok", "Mask2.png"));
			ColRecips.Add(new Recips(1, "Taba ng talangka", "Mask1.png"));
			ColRecips.Add(new Recips(1, "Pancit palabok", "Mask2.png"));
			ColRecips.Add(new Recips(1, "Taba ng talangka", "Mask1.png"));
			ColRecips.Add(new Recips(1, "Pancit palabok", "Mask2.png"));
		}
	}
}
