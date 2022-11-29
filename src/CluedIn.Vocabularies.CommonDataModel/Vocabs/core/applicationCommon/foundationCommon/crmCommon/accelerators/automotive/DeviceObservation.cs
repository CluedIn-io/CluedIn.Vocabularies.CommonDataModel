using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceObservationVocabulary : SimpleVocabulary
    {
        public DeviceObservationVocabulary()
        {
            VocabularyName = "Device Observation";
            KeyPrefix = "commonDataModel.deviceobservation.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceObservation";

            AddGroup("DeviceObservation Details for Automotive", group =>
            {
			    DeviceObservationId = group.Add(new VocabularyKey(nameof(DeviceObservationId), "Device Observation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Severity = group.Add(new VocabularyKey(nameof(Severity), "Severity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceObservationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Severity { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}