using System.Diagnostics;
using System.IO;

namespace PenUnitTesting.Utils
{
    public class TraceFunctions
    {
        public static void AddTextWriterTraceListener(string filePath)
        {
            var fileStream = new FileStream(filePath, FileMode.Append);
            var textWriter = new TextWriterTraceListener(fileStream);
            Trace.Listeners.Add(textWriter);
            Trace.AutoFlush = true;
        }
    }
}