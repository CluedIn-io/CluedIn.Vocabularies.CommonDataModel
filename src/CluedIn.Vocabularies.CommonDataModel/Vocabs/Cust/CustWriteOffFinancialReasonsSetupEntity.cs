using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustWriteOffFinancialReasonsSetupEntityVocabulary : SimpleVocabulary
    {
        public CustWriteOffFinancialReasonsSetupEntityVocabulary()
        {
            VocabularyName = "Cust Write Off Financial Reasons Setup Entity";
            KeyPrefix = "commonDataModel.custwriteofffinancialreasonssetupentity";
            KeySeparator = ".";
            Grouping = "/CustWriteOffFinancialReasonsSetupEntity";

            AddGroup("CustWriteOffFinancialReasonsSetupEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffReason = group.Add(new VocabularyKey(nameof(WriteOffReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffDescription = group.Add(new VocabularyKey(nameof(WriteOffDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffLedgerDimension = group.Add(new VocabularyKey(nameof(WriteOffLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(WriteOffLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey WriteOffReason { get; private set; }
        public VocabularyKey WriteOffDescription { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey WriteOffLedgerDimension { get; private set; }
        public VocabularyKey WriteOffLedgerDimensionDisplayValue { get; private set; }
    }
}