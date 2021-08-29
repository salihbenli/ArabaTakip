using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IAractaService
    {
        List<AracTanimlama> GetList();
        void AractaAdd(AracTanimlama aracTanimlama);
        AracTanimlama GetById(int id);
        void IslemDelete(AracTanimlama aracTanimlama);
        void IslemtaUpdate(AracTanimlama aracTanimlama);
    }
}
