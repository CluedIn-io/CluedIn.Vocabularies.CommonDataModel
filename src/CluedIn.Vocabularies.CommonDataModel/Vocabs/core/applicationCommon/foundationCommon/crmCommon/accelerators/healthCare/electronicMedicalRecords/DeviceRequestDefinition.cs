using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceRequestDefinitionVocabulary : SimpleVocabulary
    {
        public DeviceRequestDefinitionVocabulary()
        {
            VocabularyName = "Device Request Definition";
            KeyPrefix = "commonDataModel.devicerequestdefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceRequestDefinition";

            AddGroup("DeviceRequestDefinition Details for ElectronicMedicalRecords", group =>
            {
			    DefinitionType = group.Add(new VocabularyKey(nameof(DefinitionType), "Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceRequestDefinitionId = group.Add(new VocabularyKey(nameof(DeviceRequestDefinitionId), "Device Request Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DefinitionType { get; private set; }
        public VocabularyKey DeviceRequestDefinitionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}