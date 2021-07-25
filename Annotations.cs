using System;
using System.Linq;
using iText.Kernel.Pdf;

namespace CSPdfLibrary.Annotation
{
    public class Utils
    {
        public static bool IfDocumentHasAnnotations(string filePath)
        {
            return IfDocumentHasAnnotations(Document.LoadDocument.LoadPdfToRead(filePath));
        }
        public static bool IfDocumentHasAnnotations(PdfDocument pdf)
        {
            var hasAnnotations = false;
            var pages = pdf.GetNumberOfPages();
            for (int i = 1; i < pages; i++)
            {
                var page = pdf.GetPage(i);
                if (page.GetAnnotations().Any())
                {
                    hasAnnotations = true;
                    break;
                };
            }
            return hasAnnotations;
        }
    }
}