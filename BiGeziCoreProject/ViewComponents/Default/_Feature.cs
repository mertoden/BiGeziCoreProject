using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiGeziCoreProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDL());
        public IViewComponentResult Invoke()
            {
            var values = featureManager.TGetList();
                 return View(values);
            }
    }
}
