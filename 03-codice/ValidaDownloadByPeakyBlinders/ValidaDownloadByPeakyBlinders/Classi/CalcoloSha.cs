using System;
using System.IO;
using System.Security.Cryptography;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    internal class CalcoloSha
    {
        public string CalcoloAsh(string filename)
        {
            try
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
            catch (Exception)
            {
                return "ERRORE";
            }
        }
    }
}