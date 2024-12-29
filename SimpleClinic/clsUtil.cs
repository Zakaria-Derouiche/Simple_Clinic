using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    internal class clsUtil
    {
        public static string GenerateGUID()
        {

            Guid newGuid = Guid.NewGuid();

            return newGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating folder: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public static string GetFileExtention(string sourceFile)
        {
            FileInfo fileInfo = new FileInfo(sourceFile);
            string Extention = fileInfo.Extension;
            return Extention;
        }

        public static string GetFileName(string sourceFile)
        {
            FileInfo fileInfo = new FileInfo(sourceFile);
            string FileName = fileInfo.Name;
            return FileName;
        }
        public static void DeleteFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    File.Delete(FilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
           
            string fileName = sourceFile;
            FileInfo fi = new FileInfo(fileName);
            string extn = fi.Extension;
            return GenerateGUID() + extn;
        }

        public static bool CopyImageToImageToDisplayFolder(ref string sourceFile)
        {
            

            string DestinationFolder = clsGlobal.DesplayedImageFolder;
            if (!CreateFolderIfDoesNotExist(DestinationFolder))
            {
                return false;
            }

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, destinationFile, true);

            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            sourceFile = destinationFile;
            return true;
        }
    }
}
