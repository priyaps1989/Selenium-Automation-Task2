using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK2.Global;
using TASK2.Pages;

namespace TASK2.Tests
{
    class ManageListingSteps: Base
    {
        [Test, Order(2)]

        public void ManageListing()
        {
            ManageListing ManageListObj;
            ManageListObj = new ManageListing();
            ManageListObj.View_Manage_List();
            ManageListObj.Edit_Manage_List();
            ManageListObj.Delete_Manage_List();

        }

    }
}
