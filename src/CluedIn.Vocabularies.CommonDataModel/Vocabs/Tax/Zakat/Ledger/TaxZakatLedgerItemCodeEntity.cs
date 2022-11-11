using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxZakatLedgerItemCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxZakatLedgerItemCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxZakatLedgerItemCodeEntity";
            KeyPrefix = "commonDataModel.taxzakatledgeritemcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxZakatLedgerItemCodeEntity";

            AddGroup("Common Data Model TaxZakatLedgerItemCodeEntity Details", group =>
            {
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemType = group.Add(new VocabularyKey(nameof(ItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAsset = group.Add(new VocabularyKey(nameof(IsAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLiability = group.Add(new VocabularyKey(nameof(IsLiability), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRevenue = group.Add(new VocabularyKey(nameof(IsRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCost = group.Add(new VocabularyKey(nameof(IsCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBalance = group.Add(new VocabularyKey(nameof(IsBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProfitLoss = group.Add(new VocabularyKey(nameof(IsProfitLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsAsset { get; private set; }
        public VocabularyKey IsLiability { get; private set; }
        public VocabularyKey IsRevenue { get; private set; }
        public VocabularyKey IsCost { get; private set; }
        public VocabularyKey IsBalance { get; private set; }
        public VocabularyKey IsProfitLoss { get; private set; }


    }
}