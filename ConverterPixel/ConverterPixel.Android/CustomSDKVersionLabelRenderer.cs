using Android.Content;
using ConverterPixel;
using ConverterPixel.Droid;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSDKVersionLabel), typeof(CustomSDKVersionLabelRenderer))]
namespace ConverterPixel.Droid
{
	public class CustomSDKVersionLabelRenderer : LabelRenderer
	{
		public CustomSDKVersionLabelRenderer(Context context)
			: base(context)
		{
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (Control != null)
			{
				Control.Text = ((int)Android.OS.Build.VERSION.SdkInt).ToString();
			}
		}
	}
}