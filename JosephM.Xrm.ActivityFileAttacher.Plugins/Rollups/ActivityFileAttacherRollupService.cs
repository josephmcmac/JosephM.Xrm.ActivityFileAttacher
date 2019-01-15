using Microsoft.Xrm.Sdk;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Xrm;
using Schema;
using System;
using System.Collections.Generic;

namespace JosephM.Xrm.ActivityFileAttacher.Plugins.Rollups
{
    public class ActivityFileAttacherRollupService : RollupService
    {
        public ActivityFileAttacherRollupService(XrmService xrmService)
            : base(xrmService)
        {
        }

        private IEnumerable<LookupRollup> _Rollups = new LookupRollup[]
        {
        };

        public override IEnumerable<LookupRollup> AllRollups => _Rollups;
    }
}