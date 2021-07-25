using NUnit.Framework;

namespace CSPdfLibrary.Tests
{
    class FileRoutinesTest
    {
        public FileRoutinesTest(bool includeSubdirectories)
        {
            _includeSubdirectories = includeSubdirectories;
        }

        private static bool _includeSubdirectories;

        [Test]
        public static void TestListAllFilesWithComentsInADirecotry()
        {
            var list = Files.PdfDirectory.ListFilesWithAnnotationsInDirectory(TestFolders.TestFolder, _includeSubdirectories);
            Assert.AreEqual(1, list.Count);

        }
    }
}