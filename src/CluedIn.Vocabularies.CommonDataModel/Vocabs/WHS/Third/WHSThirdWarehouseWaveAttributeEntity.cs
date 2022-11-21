using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSThirdWarehouseWaveAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSThirdWarehouseWaveAttributeEntityVocabulary()
        {
            VocabularyName = "WHS Third Warehouse Wave Attribute Entity";
            KeyPrefix = "commonDataModel.whsthirdwarehousewaveattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSThirdWarehouseWaveAttributeEntity";

            AddGroup("WHSThirdWarehouseWaveAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
    }
}