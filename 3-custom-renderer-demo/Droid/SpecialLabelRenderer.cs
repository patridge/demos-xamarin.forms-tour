using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using X.FRendererDemo.Droid;
using X.FRendererDemo;

[assembly: ExportRenderer (typeof (SpecialLabel), typeof (SpecialLabelRenderer))]
namespace X.FRendererDemo.Droid
{
	public class SpecialLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				Control.SetBackgroundColor (Android.Graphics.Color.Blue);
				Control.Text = "I'm on an Android device!";
			}
		}
	}
}
