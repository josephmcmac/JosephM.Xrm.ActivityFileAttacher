using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JosephM.Xrm.ActivityFileAttacher.Plugins.Test
{
    //this class just for general debug purposes
    [TestClass]
    public class DebugTests : ActivityFileAttacherXrmTest
    {
        [TestMethod]
        public void Debug()
        {
            var me = XrmService.WhoAmI();
        }
    }
}