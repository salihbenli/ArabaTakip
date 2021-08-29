using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramwork
{
    public class EfSurucuDal : GenericRepository<SurucuDetay>, ISurucuDal 
    {
    }
}
