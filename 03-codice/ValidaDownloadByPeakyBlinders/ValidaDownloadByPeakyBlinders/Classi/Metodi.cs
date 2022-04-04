﻿using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;
using PgpCore;

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

        public bool VerificaFirma(string firma, string filename)
        {
            bool controllo = true;
            return controllo;
        }
    }
}