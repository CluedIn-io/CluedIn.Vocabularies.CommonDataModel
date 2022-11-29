using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceRequestReasonCodeVocabulary : SimpleVocabulary
    {
        public DeviceRequestReasonCodeVocabulary()
        {
            VocabularyName = "Device Request Reason Code";
            KeyPrefix = "commonDataModel.devicerequestreasoncode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceRequestReasonCode";

            AddGroup("DeviceRequestReasonCode Details for ElectronicMedicalRecords", group =>
            {
			    DeviceRequestReasonCodeId = group.Add(new VocabularyKey(nameof(DeviceRequestReasonCodeId), "Device Request Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceRequestReasonCodeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}