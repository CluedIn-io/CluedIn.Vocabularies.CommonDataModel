using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkClassEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkClassEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Work Class Entity";
            KeyPrefix = "commonDataModel.whswarehouseworkclassentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkClassEntity";

            AddGroup("WHSWarehouseWorkClassEntity Details", group =>
            {
                ClassId = group.Add(new VocabularyKey(nameof(ClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassDescription = group.Add(new VocabularyKey(nameof(ClassDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ClassId { get; private set; }
        public VocabularyKey ClassDescription { get; private set; }
        public VocabularyKey WorkOrderType { get; private set; }
    }
}