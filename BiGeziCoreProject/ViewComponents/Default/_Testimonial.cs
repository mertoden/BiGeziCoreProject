﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiGeziCoreProject.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
