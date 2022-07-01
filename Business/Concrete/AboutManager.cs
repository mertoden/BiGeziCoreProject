using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDL _aboutDL;

        public AboutManager(IAboutDL aboutDL)
        {
            _aboutDL = aboutDL;
        }

        public void TAdd(About t)
        {
            _aboutDL.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDL.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
           return _aboutDL.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDL.Update(t);
        }
    }
}
