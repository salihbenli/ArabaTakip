using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AracIsManager : IAracıslemService
    {
        IAracislemleriDal _aracislemleriDal;

        public AracIsManager(IAracislemleriDal aracislemleriDal)
        {
            _aracislemleriDal = aracislemleriDal;
        }

        public void AracısAdd(AracIslemleri aracIslemleri)
        {
            _aracislemleriDal.Insert(aracIslemleri);
        }

        public AracIslemleri GetById(int id)
        {
            return _aracislemleriDal.Get(x => x.Arac_isId == id);
        }

        public List<AracIslemleri> GetList()
        {
            return _aracislemleriDal.List();
        }

        public void IslemDelete(AracIslemleri aracIslemleri)
        {
            _aracislemleriDal.Delete(aracIslemleri);
        }

        public void IslemUpdate(AracIslemleri aracIslemleri)
        {
            _aracislemleriDal.Update(aracIslemleri);
        }
    }
}
