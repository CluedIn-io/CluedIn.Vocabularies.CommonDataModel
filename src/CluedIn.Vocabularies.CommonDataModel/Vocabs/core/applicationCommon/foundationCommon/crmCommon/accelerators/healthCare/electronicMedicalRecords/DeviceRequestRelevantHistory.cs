using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceRequestRelevantHistoryVocabulary : SimpleVocabulary
    {
        public DeviceRequestRelevantHistoryVocabulary()
        {
            VocabularyName = "Device Request Relevant History";
            KeyPrefix = "commonDataModel.devicerequestrelevanthistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceRequestRelevantHistory";

            AddGroup("DeviceRequestRelevantHistory Details for ElectronicMedicalRecords", group =>
            {
			    DevicerequestrelevanthistoriesId = group.Add(new VocabularyKey(nameof(DevicerequestrelevanthistoriesId), "Device Request Relevant History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DevicerequestrelevanthistoriesId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}