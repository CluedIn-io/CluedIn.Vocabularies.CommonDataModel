using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehousePutawayClusterProfileWorkTemplateEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehousePutawayClusterProfileWorkTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehousePutawayClusterProfileWorkTemplateEntity";
            KeyPrefix = "commonDataModel.whswarehouseputawayclusterprofileworktemplateentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehousePutawayClusterProfileWorkTemplateEntity";

            AddGroup("Common Data Model WHSWarehousePutawayClusterProfileWorkTemplateEntity Details", group =>
            {
                PutawayWarehouseClusterProfileId = group.Add(new VocabularyKey(nameof(PutawayWarehouseClusterProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkTemplateWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PutawayWarehouseClusterProfileId { get; private set; }
public VocabularyKey WarehouseWorkTemplateWorkOrderType { get; private set; }
public VocabularyKey WarehouseWorkTemplateId { get; private set; }


    }
}