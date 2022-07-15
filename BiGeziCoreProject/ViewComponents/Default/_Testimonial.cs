using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiGeziCoreProject.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDL());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
