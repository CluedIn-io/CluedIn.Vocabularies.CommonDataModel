using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSValidWarehouseWorkClassPutLocationTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSValidWarehouseWorkClassPutLocationTypeEntityVocabulary()
        {
            VocabularyName = "WHSValidWarehouseWorkClassPutLocationTypeEntity";
            KeyPrefix = "commonDataModel.whsvalidwarehouseworkclassputlocationtypeentity";
            KeySeparator = ".";
            Grouping = "/WHSValidWarehouseWorkClassPutLocationTypeEntity";

            AddGroup("WHSValidWarehouseWorkClassPutLocationTypeEntity Details", group =>
            {
                WarehouseWorkClassId = group.Add(new VocabularyKey(nameof(WarehouseWorkClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseLocationTypeId = group.Add(new VocabularyKey(nameof(WarehouseLocationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseWorkClassId { get; private set; }
        public VocabularyKey WarehouseLocationTypeId { get; private set; }


    }
}