using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Models
{
    public class MyModel
    {
        [AllowHtml]
        public string MyAttribute { get; set; }
    }    
}