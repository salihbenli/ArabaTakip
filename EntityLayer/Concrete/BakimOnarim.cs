using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BakimOnarim
    {
        [Key]
        public int Bakim_Id { get; set; }
        public int AracId { get; set; }
        public virtual AracTanimlama AracTanimlama { get; set; }
        public string Bakim_tarihi { get; set; }
        public string Bakim_KMsi { get; set; }
        public string Tutar { get; set; }
        public string Firma_servis { get; set; }
        public string Aciklamalar { get; set; }
    }
}
