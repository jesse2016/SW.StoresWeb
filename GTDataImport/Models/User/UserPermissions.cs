using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GTDataImport.Models.User
{
    public class UserPermissions
    {
        public List<HomeMenus> homeMenus { get; set; }
        public List<SideMenus> sideMenus { get; set; }
        public List<OverViewMenus> overViewMenus { get; set; }
        public List<ErpHomeMenus> erpHomeMenus { get; set; }
    }
}