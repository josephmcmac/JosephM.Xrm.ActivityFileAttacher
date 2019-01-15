using System.Collections.Generic;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Xrm;

namespace JosephM.Xrm.ActivityFileAttacher.Plugins.SharePoint
{
    public class ActivityFileAttacherSharepointService : SharePointService
    {
        public ActivityFileAttacherSharepointService(XrmService xrmService, ISharePointSettings sharepointSettings)
            : base(sharepointSettings, xrmService)
        {
        }

        public override IEnumerable<SharepointFolderConfig> SharepointFolderConfigs
        {
            get
            {

                return new SharepointFolderConfig[]
                {
                };
            }
        }
    }
}
