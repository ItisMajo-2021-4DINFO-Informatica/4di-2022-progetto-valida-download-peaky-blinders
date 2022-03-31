using System.Collections.Generic;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    internal class ListaChiavi
    {
        public List<CollezioneChiavi> ColleChiavi { get; set; }

        public ListaChiavi()
        {
            ColleChiavi = new List<CollezioneChiavi>();
        }

        public void AggiungiDocumento(CollezioneChiavi chiavi)
        {
            ColleChiavi.Add(chiavi);
        }
    }
}