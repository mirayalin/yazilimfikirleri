﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class TopicController : Controller
    {
        // GET: Topic
        public ActionResult AddTopic()
        {
            return View();
        }
    }
}