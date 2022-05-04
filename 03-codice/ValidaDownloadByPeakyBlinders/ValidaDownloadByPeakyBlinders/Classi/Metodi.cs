using DidiSoft.Pgp;
using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    internal class Metodi
    {
        public string CalcoloAsh(string filename)
        {
            using (var Sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = Sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "");
                }
            }
        }

        public string CercaFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                return openFileDialog.FileName;
            }
            else { return "Errore"; }
        }

        public string VerificaFirma(string firma, string filename)
        {
            PGPLib pgp = new PGPLib();
            SignatureCheckResult signatureCheck =
                pgp.VerifyFile(filename,
                               firma);

            if (signatureCheck == SignatureCheckResult.SignatureVerified)
            {
                return ("Signare OK").ToString();
            }
            else if (signatureCheck == SignatureCheckResult.SignatureBroken)
            {
                return ("Signare of the message is either broken or forged").ToString();
            }
            else if (signatureCheck == SignatureCheckResult.PublicKeyNotMatching)
            {
                return ("The provided public key doesn't match the signature").ToString();
            }
            else if (signatureCheck == SignatureCheckResult.NoSignatureFound)
            {
                return ("This message is not digitally signed").ToString();
            }
            return ("ERRORE").ToString();
        }
    }
}