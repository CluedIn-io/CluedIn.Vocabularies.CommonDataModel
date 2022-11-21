using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WMSWarehouseLocationParametersEntityVocabulary : SimpleVocabulary
    {
        public WMSWarehouseLocationParametersEntityVocabulary()
        {
            VocabularyName = "WMS Warehouse Location Parameters Entity";
            KeyPrefix = "commonDataModel.wmswarehouselocationparametersentity";
            KeySeparator = ".";
            Grouping = "/WMSWarehouseLocationParametersEntity";

            AddGroup("WMSWarehouseLocationParametersEntity Details", group =>
            {
                DefaultWarehouseLocationWidth = group.Add(new VocabularyKey(nameof(DefaultWarehouseLocationWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWarehouseLocationDepth = group.Add(new VocabularyKey(nameof(DefaultWarehouseLocationDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWarehouseLocationHeight = group.Add(new VocabularyKey(nameof(DefaultWarehouseLocationHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCheckDigitValue = group.Add(new VocabularyKey(nameof(DefaultCheckDigitValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreManualSortOrderCodesUsed = group.Add(new VocabularyKey(nameof(AreManualSortOrderCodesUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemArrivalJournalNameId = group.Add(new VocabularyKey(nameof(ItemArrivalJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionInputJournalNameId = group.Add(new VocabularyKey(nameof(ProductionInputJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DefaultWarehouseLocationWidth { get; private set; }
        public VocabularyKey DefaultWarehouseLocationDepth { get; private set; }
        public VocabularyKey DefaultWarehouseLocationHeight { get; private set; }
        public VocabularyKey DefaultCheckDigitValue { get; private set; }
        public VocabularyKey AreManualSortOrderCodesUsed { get; private set; }
        public VocabularyKey ItemArrivalJournalNameId { get; private set; }
        public VocabularyKey ProductionInputJournalNameId { get; private set; }
    }
}