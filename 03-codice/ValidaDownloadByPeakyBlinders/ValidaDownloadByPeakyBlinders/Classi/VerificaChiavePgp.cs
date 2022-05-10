using System;
using System.Diagnostics;
using System.IO;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    internal class VerificaChiavePgp
    {
        public void VerificaFirma(string ChiavePubblica, string FileDaControllare, string Impronta)
        {
            try
            {
                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.CreateNoWindow = true;
                    pProcess.StartInfo.FileName = "cmd.exe";
                    pProcess.StartInfo.Arguments = "/k gpg --recv-keys " + Impronta;
                    pProcess.Start();
                    pProcess.WaitForExit(1000);
                }

                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.FileName = "cmd.exe";
                    pProcess.StartInfo.Arguments = "/k gpg --verify " + ChiavePubblica + " " + FileDaControllare;
                    pProcess.Start();
                    StreamReader streamReader = pProcess.StandardOutput;
                    pProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}