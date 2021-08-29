using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
namespace DataAccessLayer.EntityFramwork
{
    public class EfBakimDal : GenericRepository<BakimOnarim>, IBakimDal
    {
    }
}
