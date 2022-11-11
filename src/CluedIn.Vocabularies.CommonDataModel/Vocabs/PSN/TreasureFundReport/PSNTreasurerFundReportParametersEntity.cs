using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNTreasurerFundReportParametersEntityVocabulary : SimpleVocabulary
    {
        public PSNTreasurerFundReportParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSNTreasurerFundReportParametersEntity";
            KeyPrefix = "commonDataModel.psntreasurerfundreportparametersentity";
            KeySeparator = ".";
            Grouping = "/PSNTreasurerFundReportParametersEntity";

            AddGroup("Common Data Model PSNTreasurerFundReportParametersEntity Details", group =>
            {
                TreasurerDimensionFocus = group.Add(new VocabularyKey(nameof(TreasurerDimensionFocus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupByFundType = group.Add(new VocabularyKey(nameof(GroupByFundType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeFundName = group.Add(new VocabularyKey(nameof(IncludeFundName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeClosingTransactions = group.Add(new VocabularyKey(nameof(IncludeClosingTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuppressZeroAmountAccounts = group.Add(new VocabularyKey(nameof(SuppressZeroAmountAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuppressMainAccount = group.Add(new VocabularyKey(nameof(SuppressMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TreasurerDimensionFocus { get; private set; }
        public VocabularyKey GroupByFundType { get; private set; }
        public VocabularyKey IncludeFundName { get; private set; }
        public VocabularyKey IncludeClosingTransactions { get; private set; }
        public VocabularyKey SuppressZeroAmountAccounts { get; private set; }
        public VocabularyKey SuppressMainAccount { get; private set; }
        public VocabularyKey ID { get; private set; }


    }
}