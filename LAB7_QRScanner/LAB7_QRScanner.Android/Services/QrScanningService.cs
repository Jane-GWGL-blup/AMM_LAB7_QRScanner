using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAB7_QRScanner.Services;
using System.Threading.Tasks;
using ZXing.Mobile;
using LAB7_QRScanner.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(LAB7_QRScanner.Droid.Services.QrScanningService))]


namespace LAB7_QRScanner.Droid.Services
{
    public class QrScanningService: IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            //var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait...",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}