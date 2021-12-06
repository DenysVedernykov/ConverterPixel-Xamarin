using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ConverterPixel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            On<iOS>().SetUseSafeArea(true);

            InitializeComponent();
        }

        private void calc()
        {
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
