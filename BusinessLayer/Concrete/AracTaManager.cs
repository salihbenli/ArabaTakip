using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AracTaManager : IAractaService
    {
        IAractanimlamaDal _aractanimlamaDal;

        public AracTaManager(IAractanimlamaDal aractanimlamaDal)
        {
            _aractanimlamaDal = aractanimlamaDal;
        }

        public void AractaAdd(AracTanimlama aracTanimlama)
        {
            _aractanimlamaDal.Insert(aracTanimlama);
        }

        public AracTanimlama GetById(int id)
        {
            return _aractanimlamaDal.Get(x => x.AracId == id);
        }

        public List<AracTanimlama> GetList()
        {
            return _aractanimlamaDal.List();
        }

        public void IslemDelete(AracTanimlama aracTanimlama)
        {
            _aractanimlamaDal.Delete(aracTanimlama);
        }

        public void IslemtaUpdate(AracTanimlama aracTanimlama)
        {
            _aractanimlamaDal.Update(aracTanimlama);
        }
    }
}
