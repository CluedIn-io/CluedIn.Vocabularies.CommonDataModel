using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceRequestReasonReferenceVocabulary : SimpleVocabulary
    {
        public DeviceRequestReasonReferenceVocabulary()
        {
            VocabularyName = "Device Request Reason Reference";
            KeyPrefix = "commonDataModel.devicerequestreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceRequestReasonReference";

            AddGroup("DeviceRequestReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    DeviceRequestReasonReferenceId = group.Add(new VocabularyKey(nameof(DeviceRequestReasonReferenceId), "Device Request Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonReference = group.Add(new VocabularyKey(nameof(ReasonReference), "Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceRequestReasonReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonReference { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}