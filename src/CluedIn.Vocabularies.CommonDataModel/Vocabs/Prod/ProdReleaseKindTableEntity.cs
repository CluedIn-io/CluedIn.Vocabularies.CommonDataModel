using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdReleaseKindTableEntityVocabulary : SimpleVocabulary
    {
        public ProdReleaseKindTableEntityVocabulary()
        {
            VocabularyName = "Prod Release Kind Table Entity";
            KeyPrefix = "commonDataModel.prodreleasekindtableentity";
            KeySeparator = ".";
            Grouping = "/ProdReleaseKindTableEntity";

            AddGroup("ProdReleaseKindTableEntity Details", group =>
            {
                Scrap = group.Add(new VocabularyKey(nameof(Scrap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefectiveProduct = group.Add(new VocabularyKey(nameof(DefectiveProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossAccount = group.Add(new VocabularyKey(nameof(LossAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossPhysLedgerDimension = group.Add(new VocabularyKey(nameof(LossPhysLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingRule = group.Add(new VocabularyKey(nameof(CostingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseKindId = group.Add(new VocabularyKey(nameof(ReleaseKindId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossAccountDisplayValue = group.Add(new VocabularyKey(nameof(LossAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LossPhysLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LossPhysLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Scrap { get; private set; }
        public VocabularyKey Warehouse { get; private set; }
        public VocabularyKey DefectiveProduct { get; private set; }
        public VocabularyKey LossAccount { get; private set; }
        public VocabularyKey LossPhysLedgerDimension { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CostingRule { get; private set; }
        public VocabularyKey ReleaseKindId { get; private set; }
        public VocabularyKey LossAccountDisplayValue { get; private set; }
        public VocabularyKey LossPhysLedgerDimensionDisplayValue { get; private set; }
    }
}