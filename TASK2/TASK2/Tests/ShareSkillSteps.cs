//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using TASK2.Global;
using TASK2.Pages;

namespace TASK2.Tests
{
    class ShareSkillSteps:Base
    {
        [Test, Order(1)]
       
        public void AddSkill()
        {
            ShareSkill ShareSkillObj;
            ShareSkillObj = new ShareSkill();
            ShareSkillObj.Share_Skill();
        }

    }
}
