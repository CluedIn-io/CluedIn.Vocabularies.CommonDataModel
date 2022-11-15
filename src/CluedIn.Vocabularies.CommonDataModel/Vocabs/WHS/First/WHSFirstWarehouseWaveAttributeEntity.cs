using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFirstWarehouseWaveAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSFirstWarehouseWaveAttributeEntityVocabulary()
        {
            VocabularyName = "WHS First Warehouse Wave Attribute Entity";
            KeyPrefix = "commonDataModel.whsfirstwarehousewaveattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSFirstWarehouseWaveAttributeEntity";

            AddGroup("WHSFirstWarehouseWaveAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AttributeValue { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
    }
}