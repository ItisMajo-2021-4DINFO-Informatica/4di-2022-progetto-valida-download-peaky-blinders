using System;
using Microsoft.Win32;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    internal class CercaFile
    {
        public string RicercaFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return "Errore";
                }
            }
            catch(Exception ex)
            {
                return "Errore";
            }
        }
    }
}