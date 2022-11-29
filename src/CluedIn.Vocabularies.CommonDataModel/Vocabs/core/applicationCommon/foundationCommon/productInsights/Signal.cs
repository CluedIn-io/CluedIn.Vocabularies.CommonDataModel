using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProductInsights
{
    public class SignalVocabulary : SimpleVocabulary
    {
        public SignalVocabulary()
        {
            VocabularyName = "Signal";
            KeyPrefix = "commonDataModel.signal.productinsights";
            KeySeparator = ".";
            Grouping = "/Signal";

            AddGroup("Signal Details for ProductInsights", group =>
            {
			    SignalTime = group.Add(new VocabularyKey(nameof(SignalTime), "Signal Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timezone = group.Add(new VocabularyKey(nameof(Timezone), "Timezone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Signal Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Signal Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServerTime = group.Add(new VocabularyKey(nameof(ServerTime), "Server Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartNumber = group.Add(new VocabularyKey(nameof(PartNumber), "Part Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceId = group.Add(new VocabularyKey(nameof(DeviceId), "Device Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SignalTime { get; private set; }
        public VocabularyKey Timezone { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey ServerTime { get; private set; }
        public VocabularyKey PartNumber { get; private set; }
        public VocabularyKey DeviceId { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
    }
}