using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace JayBugTracker.Models
{
    public class Admin
    {
        public string User { get; set; }
        public MultiSelectList Role { get; set; }
        public string[] SelectedRoles { get; set; }
    }

}