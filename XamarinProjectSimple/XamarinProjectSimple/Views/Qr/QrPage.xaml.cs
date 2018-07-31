using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Views.Qr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QrPage : ContentPage
	{
        //ZXingScannerView scannerView;
        //ZXingDefaultOverlay overlay;

        public QrPage() : base()
        {
            

            //Overlay = new ZXingDefaultOverlay
            //{
            //    TopText = "Hold your phone up to the barcode",
            //    BottomText = "Scanning will happen automatically",
            //    ShowFlashButton = zxing.HasTorch,
            //    AutomationId = "zxingDefaultOverlay",
            //};
            //Overlay.FlashButtonClicked += (sender, e) => {
            //    zxing.IsTorchOn = !zxing.IsTorchOn;
            //};

            InitializeComponent();

            scannerView.OnScanResult += (result) =>
                Device.BeginInvokeOnMainThread(async () => {

                    // Stop analysis until we navigate away so we don't keep reading barcodes
                    scannerView.IsAnalyzing = false;

                    // Show an alert
                    //await DisplayAlert("Scanned Barcode", result.Text, "OK");

                    successStack.Opacity = 1;
                    // Navigate away
                    //await Navigation.PopAsync();
                });

            //mainGrid.Children.Add(Overlay);


        }

        //public ZXingDefaultOverlay Overlay { get => overlay; set => overlay = value; }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            scannerView.IsScanning = true;
        }

        protected override void OnDisappearing()
        {
            scannerView.IsScanning = false;

            base.OnDisappearing();
        }
    }
}