using System;
using System.Threading;
using System.Windows.Forms;

namespace GetGuidForms
{
    class GuidOperations
    {
        public static string GuidGenerator()
        {
            Guid g = Guid.NewGuid();
            Thread thread = new Thread(() => Clipboard.SetText(g.ToString()));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
            return g.ToString();
        }
    }
}
