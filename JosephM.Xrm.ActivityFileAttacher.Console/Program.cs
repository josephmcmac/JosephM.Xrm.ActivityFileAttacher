using JosephM.Xrm.ActivityFileAttacher.Plugins.Core;
using JosephM.Xrm.ActivityFileAttacher.Plugins.Xrm;
using System;

namespace JosephM.Xrm.ActivityFileAttacher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var settings = new ConsoleSettings(new[]
                {
                    new ConsoleSettings.SettingFile(typeof(XrmSetting)),
                });
                if (!settings.ConsoleArgs(args))
                {
                    var xrmSetting = settings.Resolve<XrmSetting>();
                    var controller = new LogController();
                    controller.AddUi(new ConsoleUserInterface(false));
                    var xrmService = new XrmService(xrmSetting, controller);
                    var me = xrmService.WhoAmI();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.XrmDisplayString());
            }
            Console.WriteLine("Press Any Key To Close");
            Console.ReadKey();
        }
    }
}
