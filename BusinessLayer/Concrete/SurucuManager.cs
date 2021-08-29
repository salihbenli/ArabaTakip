using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class SurucuManager : ISurucuService
    {
        ISurucuDal _surucuDal;

        public SurucuManager(ISurucuDal surucuDal)
        {
            _surucuDal = surucuDal;
        }

        public SurucuDetay GetById(int id)
        {
            return _surucuDal.Get(x => x.SurucuId == id);
        }

        public List<SurucuDetay> GetList()
        {
            return _surucuDal.List();
        }

        public void SurucuAdd(SurucuDetay surucuDetay)
        {
            _surucuDal.Insert(surucuDetay);
        }

        public void SurucuDelete(SurucuDetay surucuDetay)
        {
            _surucuDal.Delete(surucuDetay);
        }

        public void SurucuUpdate(SurucuDetay surucuDetay)
        {
            _surucuDal.Update(surucuDetay);
        }
    }
}
