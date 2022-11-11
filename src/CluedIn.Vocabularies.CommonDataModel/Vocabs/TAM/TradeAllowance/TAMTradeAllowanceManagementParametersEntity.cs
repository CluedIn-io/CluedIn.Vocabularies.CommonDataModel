using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceManagementParametersEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceManagementParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMTradeAllowanceManagementParametersEntity";
            KeyPrefix = "commonDataModel.tamtradeallowancemanagementparametersentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceManagementParametersEntity";

            AddGroup("Common Data Model TAMTradeAllowanceManagementParametersEntity Details", group =>
            {
                DeductionLedgerJournalName = group.Add(new VocabularyKey(nameof(DeductionLedgerJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCustomerHierarchyName = group.Add(new VocabularyKey(nameof(DefaultCustomerHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OneTimePromotionTradeAllowanceTemplateId = group.Add(new VocabularyKey(nameof(OneTimePromotionTradeAllowanceTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillFundAnalyticsIncludeClosedTradeAllowanceAgreement = group.Add(new VocabularyKey(nameof(WillFundAnalyticsIncludeClosedTradeAllowanceAgreement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LumpSumExpenseMainAccountId = group.Add(new VocabularyKey(nameof(LumpSumExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LumpSumProcurementCategoryId = group.Add(new VocabularyKey(nameof(LumpSumProcurementCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementStatus = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesRebateProgramTypeId = group.Add(new VocabularyKey(nameof(DefaultSalesRebateProgramTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LumpSumExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(LumpSumExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LumpSumProcurementCategoryName = group.Add(new VocabularyKey(nameof(LumpSumProcurementCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DeductionLedgerJournalName { get; private set; }
        public VocabularyKey DefaultCustomerHierarchyName { get; private set; }
        public VocabularyKey OneTimePromotionTradeAllowanceTemplateId { get; private set; }
        public VocabularyKey WillFundAnalyticsIncludeClosedTradeAllowanceAgreement { get; private set; }
        public VocabularyKey LumpSumExpenseMainAccountId { get; private set; }
        public VocabularyKey LumpSumProcurementCategoryId { get; private set; }
        public VocabularyKey TradeAllowanceAgreementStatus { get; private set; }
        public VocabularyKey DefaultSalesRebateProgramTypeId { get; private set; }
        public VocabularyKey LumpSumExpenseMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey LumpSumProcurementCategoryName { get; private set; }


    }
}