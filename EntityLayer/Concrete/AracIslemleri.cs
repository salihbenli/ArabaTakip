using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AracIslemleri
    {
        [Key]  
        public int Arac_isId { get; set; }
        public int AracId { get; set; }
        public virtual AracTanimlama AracTanimlama { get; set; }
        public string Sigorta_islemleri { get; set; }
        public string Ceza_islemleri { get; set; }
        public string Kaza_islemleri { get; set; }
        public string Arac_muayeneleri { get; set; }
        public string OGS_HGS_giderleri { get; set; }
    }
}
