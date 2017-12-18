using System;
using System.Threading;
using System.Windows.Forms;

namespace GetGuidForms
{
    class GuidOperations
    {
        public static string GuidGenerator()
        {
            string g = Guid.NewGuid().ToString();
            Thread thread = new Thread(() => Clipboard.SetText(g));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
            return g;
        }
    }
}
