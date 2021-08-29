using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AracTanimlama
    {
        [Key]
        public int AracId { get; set; }
        public string Arac_Plakasi { get; set; }
        public string Firma_arac_no { get; set; }
        public string Arac_markasi { get; set; }
        public string Arac_modeli { get; set; }
        public string Model_yili { get; set; }
    }
}
