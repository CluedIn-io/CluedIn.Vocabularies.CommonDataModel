using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanDefinitionVocabulary : SimpleVocabulary
    {
        public CarePlanDefinitionVocabulary()
        {
            VocabularyName = "Care Plan Definition";
            KeyPrefix = "commonDataModel.careplandefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanDefinition";

            AddGroup("CarePlanDefinition Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanDefinitionId = group.Add(new VocabularyKey(nameof(CarePlanDefinitionId), "Care Plan Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefinitionType = group.Add(new VocabularyKey(nameof(DefinitionType), "Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanDefinitionId { get; private set; }
        public VocabularyKey DefinitionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}