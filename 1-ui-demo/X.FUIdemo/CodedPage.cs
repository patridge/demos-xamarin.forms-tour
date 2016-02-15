using Xamarin.Forms;
using System;

namespace X.FUIdemo
{
	public class CodedPage : ContentPage
	{
		public event EventHandler<SomeItem> ItemSelected = delegate {};

		Label _SomeLabel { get; set; }

		ListView _ItemsListView { get; set; }

		public CodedPage ()
		{
			_SomeLabel = new Label {
				XAlign = TextAlignment.Center,
			};
			_SomeLabel.SetBinding (Label.TextProperty, nameof (SomeViewModel.SomeLabel));

			var listViewItemTemplate = new DataTemplate (typeof(ImageCell));
			_ItemsListView = new ListView (ListViewCachingStrategy.RecycleElement) {
				ItemTemplate = listViewItemTemplate,
			};
			_ItemsListView.SetBinding (ListView.ItemsSourceProperty, nameof (SomeViewModel.SomeItems));
			listViewItemTemplate.SetBinding (ImageCell.TextProperty, nameof (SomeItem.ItemName));
			listViewItemTemplate.SetBinding (ImageCell.ImageSourceProperty, nameof (SomeItem.ImageUrl));
			_ItemsListView.ItemTapped += async (sender, e) => {
				var item = ((SomeItem)e.Item);
				ItemSelected (this, item);
				_ItemsListView.SelectedItem = null;
			};

			Padding = new Thickness (0, 20, 0, 0);
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Fill,
				HorizontalOptions = LayoutOptions.Fill,
				Children = {
					_SomeLabel,
					_ItemsListView,
				}
			};
		}
	}
}
