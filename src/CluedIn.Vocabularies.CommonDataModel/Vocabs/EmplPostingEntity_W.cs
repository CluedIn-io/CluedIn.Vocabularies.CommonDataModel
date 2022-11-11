using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmplPostingEntity_WVocabulary : SimpleVocabulary
    {
        public EmplPostingEntity_WVocabulary()
        {
            VocabularyName = "Common Data Model EmplPostingEntity_W";
            KeyPrefix = "commonDataModel.emplpostingentity_w";
            KeySeparator = ".";
            Grouping = "/EmplPostingEntity_W";

            AddGroup("Common Data Model EmplPostingEntity_W Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchy = group.Add(new VocabularyKey(nameof(DimensionHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Num = group.Add(new VocabularyKey(nameof(Num), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryLedgerDimension = group.Add(new VocabularyKey(nameof(SummaryLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(SummaryLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementByDimension = group.Add(new VocabularyKey(nameof(SettlementByDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey DimensionHierarchy { get; private set; }
        public VocabularyKey Num { get; private set; }
        public VocabularyKey SummaryLedgerDimension { get; private set; }
        public VocabularyKey SummaryLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SettlementByDimension { get; private set; }


    }
}