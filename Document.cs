using iText.Kernel.Pdf;

namespace CSPdfLibrary.Document
{
    public class LoadDocument
    {

        public static PdfDocument LoadPdfToRead(string filePath)
        {
            var pdfReader = new PdfReader(filePath);
            var doc = new PdfDocument(pdfReader);
            return doc;
        }
    }
}