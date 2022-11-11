using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GBTParametersEntityVocabulary : SimpleVocabulary
    {
        public GBTParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model GBTParametersEntity";
            KeyPrefix = "commonDataModel.gbtparametersentity";
            KeySeparator = ".";
            Grouping = "/GBTParametersEntity";

            AddGroup("Common Data Model GBTParametersEntity Details", group =>
            {
                AcquisitionLedgerDimension = group.Add(new VocabularyKey(nameof(AcquisitionLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceSheet = group.Add(new VocabularyKey(nameof(BalanceSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashflowAdditional = group.Add(new VocabularyKey(nameof(CashflowAdditional), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashflowCodeFormat = group.Add(new VocabularyKey(nameof(CashflowCodeFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowDimension = group.Add(new VocabularyKey(nameof(CashFlowDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashflowMajorSheet = group.Add(new VocabularyKey(nameof(CashflowMajorSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangesOfOwnersEquity = group.Add(new VocabularyKey(nameof(ChangesOfOwnersEquity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationLedgerDimension = group.Add(new VocabularyKey(nameof(DepreciationLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposalLedgerDimension = group.Add(new VocabularyKey(nameof(DisposalLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetGroupCodeFormat = group.Add(new VocabularyKey(nameof(FixedAssetGroupCodeFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncomeSheet = group.Add(new VocabularyKey(nameof(IncomeSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Industry = group.Add(new VocabularyKey(nameof(Industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                key = group.Add(new VocabularyKey(nameof(key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrgNumber = group.Add(new VocabularyKey(nameof(OrgNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrgType = group.Add(new VocabularyKey(nameof(OrgType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERModelName = group.Add(new VocabularyKey(nameof(ERModelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcquisitionLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(AcquisitionLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DepreciationLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisposalLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DisposalLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AcquisitionLedgerDimension { get; private set; }
        public VocabularyKey BalanceSheet { get; private set; }
        public VocabularyKey CashflowAdditional { get; private set; }
        public VocabularyKey CashflowCodeFormat { get; private set; }
        public VocabularyKey CashFlowDimension { get; private set; }
        public VocabularyKey CashflowMajorSheet { get; private set; }
        public VocabularyKey ChangesOfOwnersEquity { get; private set; }
        public VocabularyKey DepreciationLedgerDimension { get; private set; }
        public VocabularyKey DisposalLedgerDimension { get; private set; }
        public VocabularyKey FixedAssetGroupCodeFormat { get; private set; }
        public VocabularyKey IncomeSheet { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey key { get; private set; }
        public VocabularyKey OrgNumber { get; private set; }
        public VocabularyKey OrgType { get; private set; }
        public VocabularyKey ERModelName { get; private set; }
        public VocabularyKey AcquisitionLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DepreciationLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DisposalLedgerDimensionDisplayValue { get; private set; }


    }
}