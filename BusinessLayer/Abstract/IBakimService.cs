using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IBakimService
    {
        List<BakimOnarim> GetList();
        void BakimAdd(BakimOnarim bakimOnarim);
        BakimOnarim GetById(int id);
        void BakimDelete(BakimOnarim bakimOnarim);
        void BakimUpdate(BakimOnarim bakimOnarim);
    }
}
