using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseReplenishmentRequestTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseReplenishmentRequestTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseReplenishmentRequestTypeEntity";
            KeyPrefix = "commonDataModel.whswarehousereplenishmentrequesttypeentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseReplenishmentRequestTypeEntity";

            AddGroup("Common Data Model WHSWarehouseReplenishmentRequestTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeDescription { get; private set; }
public VocabularyKey TypeId { get; private set; }


    }
}