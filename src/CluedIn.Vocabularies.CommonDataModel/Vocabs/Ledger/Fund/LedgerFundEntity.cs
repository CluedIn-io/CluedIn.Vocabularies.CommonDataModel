using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFundEntityVocabulary : SimpleVocabulary
    {
        public LedgerFundEntityVocabulary()
        {
            VocabularyName = "Ledger Fund Entity";
            KeyPrefix = "commonDataModel.ledgerfundentity";
            KeySeparator = ".";
            Grouping = "/LedgerFundEntity";

            AddGroup("LedgerFundEntity Details", group =>
            {
                FundClass = group.Add(new VocabularyKey(nameof(FundClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNonReportingFund = group.Add(new VocabularyKey(nameof(IsNonReportingFund), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundName = group.Add(new VocabularyKey(nameof(FundName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundNumber = group.Add(new VocabularyKey(nameof(FundNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMajor = group.Add(new VocabularyKey(nameof(IsMajor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundTypeId = group.Add(new VocabularyKey(nameof(FundTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideYearEndOption = group.Add(new VocabularyKey(nameof(OverrideYearEndOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearEndOption = group.Add(new VocabularyKey(nameof(YearEndOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundType = group.Add(new VocabularyKey(nameof(FundType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNTreasurerFundReport = group.Add(new VocabularyKey(nameof(PSNTreasurerFundReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FundClass { get; private set; }
        public VocabularyKey IsNonReportingFund { get; private set; }
        public VocabularyKey FundName { get; private set; }
        public VocabularyKey FundNumber { get; private set; }
        public VocabularyKey IsMajor { get; private set; }
        public VocabularyKey FundTypeId { get; private set; }
        public VocabularyKey OverrideYearEndOption { get; private set; }
        public VocabularyKey YearEndOption { get; private set; }
        public VocabularyKey FundType { get; private set; }
        public VocabularyKey PSNTreasurerFundReport { get; private set; }
    }
}