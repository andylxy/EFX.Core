﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Tibos.Service;
using Tibos.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Collections;
using Tibos.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment hostingEnv;
        private IViewRenderService _viewRenderService;
        public HomeController(IHostingEnvironment env, IViewRenderService viewSendeRenderService)
        {
            _viewRenderService = viewSendeRenderService;
            hostingEnv = env;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
