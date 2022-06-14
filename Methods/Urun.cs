using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public int StokAdedi { get; set; }
        public double Fiyati { get; set; }
        public string UrunAciklama { get; set; }
    }
}
