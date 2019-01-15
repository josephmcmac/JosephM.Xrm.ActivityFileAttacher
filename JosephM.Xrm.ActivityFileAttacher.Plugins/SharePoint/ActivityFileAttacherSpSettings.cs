using System;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Xrm;

namespace JosephM.Xrm.ActivityFileAttacher.Plugins.SharePoint
{
    public class ActivityFileAttacherSharePointSettings : ISharePointSettings
    {
        public ActivityFileAttacherSharePointSettings(XrmService xrmService)
        {
            XrmService = xrmService;
        }

        private string _username;
        public string UserName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private XrmService XrmService { get; }
    }
}
