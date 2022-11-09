using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSThirdWarehouseWaveAttributeEntityVocabulary : SimpleVocabulary
    {
        public WHSThirdWarehouseWaveAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSThirdWarehouseWaveAttributeEntity";
            KeyPrefix = "commonDataModel.whsthirdwarehousewaveattributeentity";
            KeySeparator = ".";
            Grouping = "/WHSThirdWarehouseWaveAttributeEntity";

            AddGroup("Common Data Model WHSThirdWarehouseWaveAttributeEntity Details", group =>
            {
                AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AttributeValue { get; private set; }
public VocabularyKey AttributeDescription { get; private set; }


    }
}