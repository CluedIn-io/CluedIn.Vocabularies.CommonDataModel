using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseDispositionCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseDispositionCodeEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Disposition Code Entity";
            KeyPrefix = "commonDataModel.whswarehousedispositioncodeentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseDispositionCodeEntity";

            AddGroup("WHSWarehouseDispositionCodeEntity Details", group =>
            {
                DispositionCode = group.Add(new VocabularyKey(nameof(DispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignedProductInventoryStatusId = group.Add(new VocabularyKey(nameof(AssignedProductInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnDispositionCode = group.Add(new VocabularyKey(nameof(ReturnDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseWorkTemplateCode = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DispositionCode { get; private set; }
        public VocabularyKey AssignedProductInventoryStatusId { get; private set; }
        public VocabularyKey ReturnDispositionCode { get; private set; }
        public VocabularyKey WarehouseWorkTemplateCode { get; private set; }
    }
}