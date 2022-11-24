using Xamarin.Essentials;
using Xamarin.Forms;

namespace ConverterPixel
{
	public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            calc();
        }

        private void calc()
        {
            // Get Metrics
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            // Orientation (Landscape, Portrait, Square, Unknown)
            var orientation = mainDisplayInfo.Orientation;

            // Rotation (0, 90, 180, 270)
            var rotation = mainDisplayInfo.Rotation;

            // Width (in pixels)
            var width = mainDisplayInfo.Width;

            // Height (in pixels)
            var height = mainDisplayInfo.Height;

            // Screen density
            var density = mainDisplayInfo.Density;

            widthInPixel.Text = "Width device (Pixel): " + width;
            heightInPixel.Text = "Height device (Pixel): " + height;
            densityLabel.Text = "Density: " + density;
            
            deviceInfoLabel.Text = $"{DeviceInfo.DeviceType} | {DeviceInfo.Platform} | {DeviceInfo.Idiom} | {DeviceInfo.Manufacturer} | {DeviceInfo.Model} | {DeviceInfo.Name} | {DeviceInfo.Version}";

            double sample;

            var deviceWidth = stackLayout.Width;
            var deviceHeight = stackLayout.Height;

            var trueParse = double.TryParse(entryWidthLayout.Text, out sample);
            trueParse &= double.TryParse(entryHeightLayout.Text, out sample);
            trueParse &= double.TryParse(entryInputPixel.Text, out sample);

            if (trueParse)
            {
                var widthLayout = double.Parse(entryWidthLayout.Text);
                var heightLayout = double.Parse(entryHeightLayout.Text);
                var inputPixel = double.Parse(entryInputPixel.Text);

                var scaleX = deviceWidth / widthLayout;
                var scaleY = deviceHeight / heightLayout;

                if (switcher.IsChecked)
                {
                    var tmp = (scaleX * inputPixel).ToString();

                    labelResult.Text = tmp.Length > 8 ? tmp.Substring(0, 8) : tmp;
                }
                else
                {
                    var tmp = (scaleY * inputPixel).ToString();

                    labelResult.Text = tmp.Length > 8 ? tmp.Substring(0, 8) : tmp;
                }
            }
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            calc();
        }

        private void Entry_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            calc();
        }

        private void Entry_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            calc();
        }

        private void switch_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            calc();
        }
	}
}
