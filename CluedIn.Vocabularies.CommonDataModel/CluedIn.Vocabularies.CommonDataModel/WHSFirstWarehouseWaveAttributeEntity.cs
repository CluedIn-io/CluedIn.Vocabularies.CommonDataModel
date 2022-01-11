using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSFirstWarehouseWaveAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSFirstWarehouseWaveAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSFirstWarehouseWaveAttributeEntity";
            KeyPrefix = "commonDataModel.whsfirstwarehousewaveattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSFirstWarehouseWaveAttributeEntity";

            AddGroup("Common Data Model WHSFirstWarehouseWaveAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AttributeValue { get; private set; }
public VocabularyKey AttributeDescription { get; private set; }


    }
}