using System;
using Xamarin.Forms;

namespace X.FUIdemo
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage ()
		{
			InitializeComponent ();
		}

		void DetailsListView_ItemTapped (object sender, EventArgs e)
		{
			DetailsListView.SelectedItem = null;
		}
	}
}
