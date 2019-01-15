using JosephM.Xrm.ActivityFileAttacher.Plugins.Services;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Rollups;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Xrm;
using JosephM.Xrm.ActivityFileAttacher.Plugins.SharePoint;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Localisation;

namespace JosephM.Xrm.ActivityFileAttacher.Plugins.Plugins
{
    /// <summary>
    /// class for shared services or settings objects for plugins
    /// </summary>
    public abstract class ActivityFileAttacherEntityPluginBase : XrmEntityPlugin
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

        private ActivityFileAttacherRollupService _RollupService;
        public ActivityFileAttacherRollupService ActivityFileAttacherRollupService
        {
            get
            {
                if (_RollupService == null)
                    _RollupService = new ActivityFileAttacherRollupService(XrmService);
                return _RollupService;
            }
        }

        private ActivityFileAttacherSharepointService _sharePointService;
        public ActivityFileAttacherSharepointService ActivityFileAttacherSharepointService
        {
            get
            {
                if (_sharePointService == null)
                    _sharePointService = new ActivityFileAttacherSharepointService(XrmService, new ActivityFileAttacherSharePointSettings(XrmService));
                return _sharePointService;
            }
        }

        private LocalisationService _localisationService;
        public LocalisationService LocalisationService
        {
            get
            {
                if (_localisationService == null)
                    _localisationService = new LocalisationService(new LocalisationSettings());
                return _localisationService;
            }
        }
    }
}
