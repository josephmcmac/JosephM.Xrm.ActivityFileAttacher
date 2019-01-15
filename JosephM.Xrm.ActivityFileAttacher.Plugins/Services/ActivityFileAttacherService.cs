using JosephM.Xrm.ActivityFileAttacher.Plugins.Xrm;

namespace JosephM.Xrm.ActivityFileAttacher.Plugins.Services
{
    /// <summary>
    /// A service class for performing logic
    /// </summary>
    public class ActivityFileAttacherService
    {
        private XrmService XrmService { get; set; }
        private ActivityFileAttacherSettings ActivityFileAttacherSettings { get; set; }

        public ActivityFileAttacherService(XrmService xrmService, ActivityFileAttacherSettings settings)
        {
            XrmService = xrmService;
            ActivityFileAttacherSettings = settings;
        }
    }
}
