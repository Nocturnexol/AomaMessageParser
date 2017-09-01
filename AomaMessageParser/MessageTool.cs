using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AomaMessageParser
{
    internal static class MessageTool
    {
        internal static string Parse(byte[] srcBytes)
        {
            return "";
        }

        internal static byte[] Construct(MessageHeader header)
        {
            var model = header as AnalysisAlert;
            return null;
        }
    }
}
