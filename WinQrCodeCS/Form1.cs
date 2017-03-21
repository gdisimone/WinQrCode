using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;

namespace WinQrCodeCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            //string Testo = "A00001T";
            //IBarcodeWriter GeneraBarcode = new BarcodeWriter() { Format = BarcodeFormat.CODABAR};
            //Bitmap bitmapBarcode;
            //var risultato = GeneraBarcode.Write(Testo);
            //bitmapBarcode = new Bitmap(risultato);
            ////bitmapBarcode.Save("C:\\Users\\gios_\\Documents\\Visual Studio 2013\\Projects\\WinQrCode\\sample-barcode-image.png");
            //PictureBox1.Image = bitmapBarcode;


            // create a barcode reader instance
            IBarcodeReader reader = new BarcodeReader();
            // load a bitmap
            var barcodeBitmap = (Bitmap)Bitmap.FromFile("C:\\Users\\gios_\\Documents\\Visual Studio 2013\\Projects\\WinQrCode\\sample-barcode-image4.jpg");
            //LoadFrom("C:\\sample-barcode-image.png");
            // detect and decode the barcode inside the bitmap
            var result = reader.Decode(barcodeBitmap);
            // do something with the result
            if (result != null)
            {
                textDecoder2.Text = result.BarcodeFormat.ToString();
                textDecoder1.Text = result.Text;
            }

        }
    }
}
