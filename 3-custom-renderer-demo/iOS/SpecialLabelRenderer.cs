using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using X.FRendererDemo;
using X.FRendererDemo.iOS;
using UIKit;

[assembly: ExportRenderer (typeof (SpecialLabel), typeof (SpecialLabelRenderer))]
namespace X.FRendererDemo.iOS
{
	public class SpecialLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.BackgroundColor = UIColor.Red;
				Control.Text = "I'm on an iOS device!";
			}
		}
	}
}
