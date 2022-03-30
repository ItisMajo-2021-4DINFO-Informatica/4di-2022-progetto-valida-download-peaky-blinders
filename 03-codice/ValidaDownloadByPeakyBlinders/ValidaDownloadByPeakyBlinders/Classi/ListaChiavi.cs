using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaDownloadByPeakyBlinders.Classi
{
    class ListaChiavi
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
