using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManParametersEntityVocabulary : SimpleVocabulary
    {
        public CredManParametersEntityVocabulary()
        {
            VocabularyName = "CredManParametersEntity";
            KeyPrefix = "commonDataModel.credmanparametersentity";
            KeySeparator = ".";
            Grouping = "/CredManParametersEntity";

            AddGroup("CredManParametersEntity Details", group =>
            {
                AllowBlankCreditLimitExpiryDate = group.Add(new VocabularyKey(nameof(AllowBlankCreditLimitExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowConfirmation = group.Add(new VocabularyKey(nameof(AllowConfirmation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowEditSalesOrder = group.Add(new VocabularyKey(nameof(AllowEditSalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoPost = group.Add(new VocabularyKey(nameof(AutoPost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvgBalOneMonth = group.Add(new VocabularyKey(nameof(AvgBalOneMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvgBalTwoMonths = group.Add(new VocabularyKey(nameof(AvgBalTwoMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvgCreditLimitPercentMonths = group.Add(new VocabularyKey(nameof(AvgCreditLimitPercentMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvgExposurePercentMonths = group.Add(new VocabularyKey(nameof(AvgExposurePercentMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockingCalcBase = group.Add(new VocabularyKey(nameof(BlockingCalcBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckAtPickingList = group.Add(new VocabularyKey(nameof(CheckAtPickingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckCashDiscIncrease = group.Add(new VocabularyKey(nameof(CheckCashDiscIncrease), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckPaymTermIncrease = group.Add(new VocabularyKey(nameof(CheckPaymTermIncrease), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CODPaymTerm = group.Add(new VocabularyKey(nameof(CODPaymTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CrossCompanyCreditCheck = group.Add(new VocabularyKey(nameof(CrossCompanyCreditCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DaySalesOutstandingOne = group.Add(new VocabularyKey(nameof(DaySalesOutstandingOne), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DaySalesOutstandingTwo = group.Add(new VocabularyKey(nameof(DaySalesOutstandingTwo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeleteBlockedLoadLines = group.Add(new VocabularyKey(nameof(DeleteBlockedLoadLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeAccountLessThan = group.Add(new VocabularyKey(nameof(ExcludeAccountLessThan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeCreditBalance = group.Add(new VocabularyKey(nameof(ExcludeCreditBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeOverdueLessThan = group.Add(new VocabularyKey(nameof(ExcludeOverdueLessThan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeSalesOrderLessThan = group.Add(new VocabularyKey(nameof(ExcludeSalesOrderLessThan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodFrom = group.Add(new VocabularyKey(nameof(PeriodFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTo = group.Add(new VocabularyKey(nameof(PeriodTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseReasonCancel = group.Add(new VocabularyKey(nameof(ReleaseReasonCancel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseReasonOrderModified = group.Add(new VocabularyKey(nameof(ReleaseReasonOrderModified), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseReasonReady = group.Add(new VocabularyKey(nameof(ReleaseReasonReady), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipCreditCheck = group.Add(new VocabularyKey(nameof(SkipCreditCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetAgeing = group.Add(new VocabularyKey(nameof(TargetAgeing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetDateTransactionDueDate = group.Add(new VocabularyKey(nameof(TargetDateTransactionDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarginCategoryHierarchyName = group.Add(new VocabularyKey(nameof(MarginCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimitExchRateTypeName = group.Add(new VocabularyKey(nameof(CreditLimitExchRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimitAllowManualEditing = group.Add(new VocabularyKey(nameof(CreditLimitAllowManualEditing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllowBlankCreditLimitExpiryDate { get; private set; }
        public VocabularyKey AllowConfirmation { get; private set; }
        public VocabularyKey AllowEditSalesOrder { get; private set; }
        public VocabularyKey AutoPost { get; private set; }
        public VocabularyKey AvgBalOneMonth { get; private set; }
        public VocabularyKey AvgBalTwoMonths { get; private set; }
        public VocabularyKey AvgCreditLimitPercentMonths { get; private set; }
        public VocabularyKey AvgExposurePercentMonths { get; private set; }
        public VocabularyKey BlockingCalcBase { get; private set; }
        public VocabularyKey CheckAtPickingList { get; private set; }
        public VocabularyKey CheckCashDiscIncrease { get; private set; }
        public VocabularyKey CheckPaymTermIncrease { get; private set; }
        public VocabularyKey CODPaymTerm { get; private set; }
        public VocabularyKey CrossCompanyCreditCheck { get; private set; }
        public VocabularyKey DaySalesOutstandingOne { get; private set; }
        public VocabularyKey DaySalesOutstandingTwo { get; private set; }
        public VocabularyKey DeleteBlockedLoadLines { get; private set; }
        public VocabularyKey ExcludeAccountLessThan { get; private set; }
        public VocabularyKey ExcludeCreditBalance { get; private set; }
        public VocabularyKey ExcludeOverdueLessThan { get; private set; }
        public VocabularyKey ExcludeSalesOrderLessThan { get; private set; }
        public VocabularyKey PeriodFrom { get; private set; }
        public VocabularyKey PeriodId { get; private set; }
        public VocabularyKey PeriodTo { get; private set; }
        public VocabularyKey ReleaseReasonCancel { get; private set; }
        public VocabularyKey ReleaseReasonOrderModified { get; private set; }
        public VocabularyKey ReleaseReasonReady { get; private set; }
        public VocabularyKey SkipCreditCheck { get; private set; }
        public VocabularyKey TargetAgeing { get; private set; }
        public VocabularyKey TargetDateTransactionDueDate { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey MarginCategoryHierarchyName { get; private set; }
        public VocabularyKey CreditLimitExchRateTypeName { get; private set; }
        public VocabularyKey CreditLimitAllowManualEditing { get; private set; }


    }
}