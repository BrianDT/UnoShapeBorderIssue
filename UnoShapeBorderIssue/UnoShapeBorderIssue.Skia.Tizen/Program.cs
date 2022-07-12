using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoShapeBorderIssue.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoShapeBorderIssue.App());
            host.Run();
        }
    }
}
