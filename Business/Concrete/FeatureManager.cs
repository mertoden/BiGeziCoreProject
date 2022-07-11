using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FeatureManager: IFeatureService
    {
        IFeatureDL _featureDL;


        public FeatureManager(IFeatureDL featureDL)
        {
            _featureDL = featureDL;
        }

        public void TAdd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDL.GetList();
        }

        public void TUpdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
