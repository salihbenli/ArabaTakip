using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAracıslemService
    {
        List<AracIslemleri> GetList();
        void AracısAdd(AracIslemleri aracIslemleri);
        AracIslemleri GetById(int id);
        void IslemDelete(AracIslemleri aracIslemleri);
        void IslemUpdate(AracIslemleri aracIslemleri);

    }
}
