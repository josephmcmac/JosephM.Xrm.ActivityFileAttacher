using JosephM.Xrm.ActivityFileAttacher.Plugins.Services;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Xrm;

namespace JosephM.Xrm.ActivityFileAttacher.Plugins.Workflows
{
    /// <summary>
    /// class for shared services or settings objects for workflow activities
    /// </summary>
    public abstract class ActivityFileAttacherWorkflowActivity<T> : XrmWorkflowActivityInstance<T>
        where T : XrmWorkflowActivityRegistration
    {
        private ActivityFileAttacherSettings _settings;
        public ActivityFileAttacherSettings ActivityFileAttacherSettings
        {
            get
            {
                if (_settings == null)
                    _settings = new ActivityFileAttacherSettings(XrmService);
                return _settings;
            }
        }

        private ActivityFileAttacherService _service;
        public ActivityFileAttacherService ActivityFileAttacherService
        {
            get
            {
                if (_service == null)
                    _service = new ActivityFileAttacherService(XrmService, ActivityFileAttacherSettings);
                return _service;
            }
        }
    }
}
