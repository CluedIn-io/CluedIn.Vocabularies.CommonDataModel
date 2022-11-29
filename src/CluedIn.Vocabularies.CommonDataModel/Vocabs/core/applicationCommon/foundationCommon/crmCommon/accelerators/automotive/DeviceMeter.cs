using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceMeterVocabulary : SimpleVocabulary
    {
        public DeviceMeterVocabulary()
        {
            VocabularyName = "Device Meter";
            KeyPrefix = "commonDataModel.devicemeter.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceMeter";

            AddGroup("DeviceMeter Details for Automotive", group =>
            {
			    DeviceMeterId = group.Add(new VocabularyKey(nameof(DeviceMeterId), "Device Meter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedMaximum = group.Add(new VocabularyKey(nameof(ExpectedMaximum), "Expected Maximum", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ExpectedMinimum = group.Add(new VocabularyKey(nameof(ExpectedMinimum), "Expected Minimum", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), "Is Primary", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Offset = group.Add(new VocabularyKey(nameof(Offset), "Offset", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceMeterId { get; private set; }
        public VocabularyKey ExpectedMaximum { get; private set; }
        public VocabularyKey ExpectedMinimum { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Offset { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}