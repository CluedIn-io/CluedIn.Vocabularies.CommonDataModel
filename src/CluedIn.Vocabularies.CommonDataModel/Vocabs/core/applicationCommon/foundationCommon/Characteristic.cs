using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class CharacteristicVocabulary : SimpleVocabulary
    {
        public CharacteristicVocabulary()
        {
            VocabularyName = "Characteristic";
            KeyPrefix = "commonDataModel.characteristic.foundationcommon";
            KeySeparator = ".";
            Grouping = "/Characteristic";

            AddGroup("Characteristic Details for FoundationCommon", group =>
            {
			    CharacteristicId = group.Add(new VocabularyKey(nameof(CharacteristicId), "Characteristic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CharacteristicType = group.Add(new VocabularyKey(nameof(CharacteristicType), "Characteristic Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CharacteristicId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CharacteristicType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}