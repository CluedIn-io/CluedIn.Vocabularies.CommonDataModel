using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFourthWarehouseWaveAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSFourthWarehouseWaveAttributeEntityVocabulary()
        {
            VocabularyName = "WHSFourthWarehouseWaveAttributeEntity";
            KeyPrefix = "commonDataModel.whsfourthwarehousewaveattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSFourthWarehouseWaveAttributeEntity";

            AddGroup("WHSFourthWarehouseWaveAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }


    }
}