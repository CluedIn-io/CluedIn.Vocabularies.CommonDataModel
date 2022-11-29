using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class RequirementCharacteristicVocabulary : SimpleVocabulary
    {
        public RequirementCharacteristicVocabulary()
        {
            VocabularyName = "Requirement Characteristic";
            KeyPrefix = "commonDataModel.requirementcharacteristic.scheduling";
            KeySeparator = ".";
            Grouping = "/RequirementCharacteristic";

            AddGroup("RequirementCharacteristic Details for Scheduling", group =>
            {
			    RequirementCharacteristicId = group.Add(new VocabularyKey(nameof(RequirementCharacteristicId), "Requirement Characteristic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequirementCharacteristicId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}