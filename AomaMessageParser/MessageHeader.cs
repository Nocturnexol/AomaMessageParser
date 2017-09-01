using System.ComponentModel;

namespace AomaMessageParser
{
    internal abstract class MessageHeader
    {
        [DisplayName("消息ID")]
        internal ushort MessageId { get; set; }
        [DisplayName("消息体属性")]
        internal ushort Properties { get; set; }
        [DisplayName("协议版本号")]
        internal byte Version { get { return 1; } }
        [DisplayName("终端ID")]
        internal ulong TerminalId { get; set; }
        [DisplayName("消息流水号")]
        internal ushort SerialNum { get; set; }
        [DisplayName("消息总包数")]
        internal ushort TotalPack { get; set; }
        [DisplayName("包序号")]
        internal ushort PackNum { get; set; }
        [DisplayName("校验码")]
        internal byte CheckCode { get; set; }
        public abstract override string ToString();
    }
}
