Imports ZXing

Public Class Form1

    Private Sub btnGenera_Click(sender As System.Object, e As System.EventArgs) Handles btnGenera.Click
        Dim Testo As String = "http://www.iprogrammatori.it"
        Dim GeneraBarcode As IBarcodeWriter = New BarcodeWriter() With {.Format = BarcodeFormat.QR_CODE}
        Dim bitmapBarcode As Bitmap
        Dim risultato = GeneraBarcode.Write(Testo)
        bitmapBarcode = New Bitmap(risultato)
        PictureBox1.Image = bitmapBarcode

          
    End Sub
End Class
