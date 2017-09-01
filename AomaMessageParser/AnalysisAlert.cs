using System;
using System.ComponentModel;

namespace AomaMessageParser
{
    internal sealed class AnalysisAlert : MessageHeader
    {
        [DisplayName("时间")]
        internal ulong DateTime { get; set; }
        [DisplayName("事件类型")]
        internal byte EventType { get; set; }
        [DisplayName("厂商")]
        internal byte Manufacturer { get; set; }
        [DisplayName("文件名长度")]
        internal byte FileNameLength { get; set; }
        [DisplayName("文件名")]
        internal byte[] FileName { get; set; }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
