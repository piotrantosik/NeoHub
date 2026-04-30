using DSC.TLink.ITv2.Enumerations;
using DSC.TLink.Serialization;

namespace DSC.TLink.ITv2.Messages
{
    /// <summary>
    /// Response for 0x4737 Access Code Attribute Read.
    /// Wire format: [NumberOfRecords:1] [UserNumber:1] [Reserved1:1] [Reserved2:1] [DataLength:1] [AttributeFlags:1]
    /// </summary>
    [ITv2Command(ITv2Command.Response_Access_Code_Attribute)]
    public record AccessCodeAttributeReadResponse : IMessageData
    {
        [CompactInteger]
        public int AccessCodeStart { get; init; }
        [CompactInteger]
        public int AccessCodeCount { get; init; }
        public byte DataWidth { get; init; }    //Should always be 1
        public PanelUserAttributes[] Attributes { get; init; } = Array.Empty<PanelUserAttributes>();
    }
}
