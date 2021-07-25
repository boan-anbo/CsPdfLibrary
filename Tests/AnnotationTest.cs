using CSPdfLibrary.Annotation;
using NUnit.Framework;

namespace CSPdfLibrary.Tests
{
    class AnnotationTest
    {
        [Test]
        public static void CheckIfDocumentHasAnyAnnotationss()
        {

            var testFile = @"C:\Script\CSPdfLibrary\Tests\test_no_comments.pdf";
            var noComments = Utils.IfDocumentHasAnnotations(testFile);
            Assert.AreEqual(false, noComments);
            var testFile2 = @"C:\Script\CSPdfLibrary\Tests\test_comments.pdf";
            var comments = Utils.IfDocumentHasAnnotations(testFile2);
            Assert.AreEqual(true, comments);
        }
    }
}