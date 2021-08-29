using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ISurucuService
    {
        List<SurucuDetay> GetList();
        void SurucuAdd(SurucuDetay surucuDetay);
        SurucuDetay GetById(int id);
        void SurucuDelete(SurucuDetay surucuDetay);
        void SurucuUpdate(SurucuDetay surucuDetay);
    }
}
