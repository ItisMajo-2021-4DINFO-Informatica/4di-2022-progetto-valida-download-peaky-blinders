using System;
using System.Diagnostics;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    internal class VerificaChiavePgp
    {
        public void VerificaFirma(string ChiavePubblica, string FileDaControllare, string Impronta)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/k gpg --recv-keys " + Impronta;
                process.StartInfo = startInfo;
                process.Start();

                Process process2 = new Process();
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process2.StartInfo.Arguments = "/k gpg --verify " + ChiavePubblica + " " + FileDaControllare;
                process2.Start();
            }
            catch (Exception)
            {
            }
        }
    }
}