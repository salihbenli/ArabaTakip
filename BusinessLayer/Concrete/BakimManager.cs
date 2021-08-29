using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class BakimManager : IBakimService
    {
        IBakimDal _bakimDal;

        public BakimManager(IBakimDal bakimDal)
        {
            _bakimDal = bakimDal;
        }

        public void BakimAdd(BakimOnarim bakimOnarim)
        {
            _bakimDal.Insert(bakimOnarim);
        }

        public void BakimDelete(BakimOnarim bakimOnarim)
        {
            _bakimDal.Delete(bakimOnarim);
        }

        public void BakimUpdate(BakimOnarim bakimOnarim)
        {
            _bakimDal.Update(bakimOnarim);
        }

        public BakimOnarim GetById(int id)
        {
            return _bakimDal.Get(x => x.Bakim_Id == id);
        }

        public List<BakimOnarim> GetList()
        {
            return _bakimDal.List();
        }
    }
}
