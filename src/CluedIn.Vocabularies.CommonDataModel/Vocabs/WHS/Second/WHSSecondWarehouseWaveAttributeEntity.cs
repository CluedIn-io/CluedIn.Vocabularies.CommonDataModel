using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSSecondWarehouseWaveAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSSecondWarehouseWaveAttributeEntityVocabulary()
        {
            VocabularyName = "WHS Second Warehouse Wave Attribute Entity";
            KeyPrefix = "commonDataModel.whssecondwarehousewaveattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSSecondWarehouseWaveAttributeEntity";

            AddGroup("WHSSecondWarehouseWaveAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
    }
}