using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceSafetyVocabulary : SimpleVocabulary
    {
        public DeviceSafetyVocabulary()
        {
            VocabularyName = "Device Safety";
            KeyPrefix = "commonDataModel.devicesafety.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceSafety";

            AddGroup("DeviceSafety Details for ElectronicMedicalRecords", group =>
            {
			    DeviceSafetyId = group.Add(new VocabularyKey(nameof(DeviceSafetyId), "Device Safety", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceSafetyId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}