using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRebateParametersEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRebateParametersEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Rebate Parameters Entity";
            KeyPrefix = "commonDataModel.purchpurchaserebateparametersentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRebateParametersEntity";

            AddGroup("PurchPurchaseRebateParametersEntity Details", group =>
            {
                WillInvoiceProcessingCreateRebateClaim = group.Add(new VocabularyKey(nameof(WillInvoiceProcessingCreateRebateClaim), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateWeekStartingDay = group.Add(new VocabularyKey(nameof(RebateWeekStartingDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAccrualProcessingJournalNameId = group.Add(new VocabularyKey(nameof(RebateAccrualProcessingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRebateInvoicePostedManually = group.Add(new VocabularyKey(nameof(IsRebateInvoicePostedManually), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateLiabilityProcurementProductCategoryRecId = group.Add(new VocabularyKey(nameof(RebateLiabilityProcurementProductCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateLiabilityProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(RebateLiabilityProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccruedLiabilityMainAccountId = group.Add(new VocabularyKey(nameof(AccruedLiabilityMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccruedLiabilityMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(AccruedLiabilityMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterimExpenseMainAccountId = group.Add(new VocabularyKey(nameof(InterimExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterimExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(InterimExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WillInvoiceProcessingCreateRebateClaim { get; private set; }
        public VocabularyKey RebateWeekStartingDay { get; private set; }
        public VocabularyKey RebateAccrualProcessingJournalNameId { get; private set; }
        public VocabularyKey IsRebateInvoicePostedManually { get; private set; }
        public VocabularyKey RebateLiabilityProcurementProductCategoryRecId { get; private set; }
        public VocabularyKey RebateLiabilityProcurementProductCategoryName { get; private set; }
        public VocabularyKey AccruedLiabilityMainAccountId { get; private set; }
        public VocabularyKey AccruedLiabilityMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey InterimExpenseMainAccountId { get; private set; }
        public VocabularyKey InterimExpenseMainAccountIdDisplayValue { get; private set; }
    }
}