using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceObservationTypeVocabulary : SimpleVocabulary
    {
        public DeviceObservationTypeVocabulary()
        {
            VocabularyName = "Device Observation Type";
            KeyPrefix = "commonDataModel.deviceobservationtype.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceObservationType";

            AddGroup("DeviceObservationType Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceObservationTypeId = group.Add(new VocabularyKey(nameof(DeviceObservationTypeId), "Device Observation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Severity = group.Add(new VocabularyKey(nameof(Severity), "Severity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceObservationTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Severity { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}