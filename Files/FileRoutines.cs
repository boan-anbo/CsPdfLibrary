using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSPdfLibrary.Files
{
    public class PdfDirectory
    {
        public static List<string> ListFilesWithAnnotationsInDirectory(string dirPath, bool includeSubdirectories=false)
        {
            var files = Directory.GetFiles(dirPath, "*.pdf", new EnumerationOptions{RecurseSubdirectories = includeSubdirectories});
            return files.Where(Annotation.Utils.IfDocumentHasAnnotations).ToList();
        }

        public static void MoveFilesWithAnnotationsToAnotherFolder(string sourceDirectory, string targetDirectory, bool includeSubdirectories)
        {
            var filesToMove = ListFilesWithAnnotationsInDirectory(sourceDirectory, includeSubdirectories);
            if (!Directory.Exists(targetDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
            }
            foreach (var fileToMove in filesToMove)
            {
                File.Move(fileToMove, targetDirectory + Path.GetFileName(fileToMove), true);
            }
        }
    }
}