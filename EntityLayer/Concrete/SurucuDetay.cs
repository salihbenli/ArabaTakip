using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SurucuDetay
    {
        [Key]
        public int SurucuId { get; set; }
        public int AracId { get; set; }
        public virtual AracTanimlama AracTanimlama { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        public string Ehliyet { get; set; }

    }
}
