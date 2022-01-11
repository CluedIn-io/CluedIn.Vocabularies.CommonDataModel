using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationFormatEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationFormatEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseLocationFormatEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationformatentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationFormatEntity";

            AddGroup("Common Data Model WHSWarehouseLocationFormatEntity Details", group =>
            {
                LocationFormatId = group.Add(new VocabularyKey(nameof(LocationFormatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationFormatName = group.Add(new VocabularyKey(nameof(LocationFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LocationFormatId { get; private set; }
public VocabularyKey LocationFormatName { get; private set; }


    }
}