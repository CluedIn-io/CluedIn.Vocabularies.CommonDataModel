using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRInstallmentPlanCustomerPaymentEntityVocabulary : SimpleVocabulary
    {
        public MCRInstallmentPlanCustomerPaymentEntityVocabulary()
        {
            VocabularyName = "MCR Installment Plan Customer Payment Entity";
            KeyPrefix = "commonDataModel.mcrinstallmentplancustomerpaymententity";
            KeySeparator = ".";
            Grouping = "/MCRInstallmentPlanCustomerPaymentEntity";

            AddGroup("MCRInstallmentPlanCustomerPaymentEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCheckAuthorized = group.Add(new VocabularyKey(nameof(IsCheckAuthorized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckNumber = group.Add(new VocabularyKey(nameof(CheckNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentType = group.Add(new VocabularyKey(nameof(CustomerPaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPlanRefund = group.Add(new VocabularyKey(nameof(IsPlanRefund), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrepay = group.Add(new VocabularyKey(nameof(IsPrepay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorizationRetryNumber = group.Add(new VocabularyKey(nameof(AuthorizationRetryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOnAccountAuthorized = group.Add(new VocabularyKey(nameof(IsOnAccountAuthorized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSchedId = group.Add(new VocabularyKey(nameof(PaymentSchedId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentAmount = group.Add(new VocabularyKey(nameof(PercentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedAmount = group.Add(new VocabularyKey(nameof(PostedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UniqueCreditCardId = group.Add(new VocabularyKey(nameof(UniqueCreditCardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreditCardProcessed = group.Add(new VocabularyKey(nameof(IsCreditCardProcessed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailGiftCardId = group.Add(new VocabularyKey(nameof(RetailGiftCardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailStoreCardTypeId = group.Add(new VocabularyKey(nameof(RetailStoreCardTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailStoreTenderTypeId = group.Add(new VocabularyKey(nameof(RetailStoreTenderTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentSalesOrderId = group.Add(new VocabularyKey(nameof(InstallmentSalesOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentPaymentScheduleId = group.Add(new VocabularyKey(nameof(InstallmentPaymentScheduleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalRefundSalesOrderId = group.Add(new VocabularyKey(nameof(OriginalRefundSalesOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalRefundPaymentScheduleId = group.Add(new VocabularyKey(nameof(OriginalRefundPaymentScheduleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalRefundLineNumber = group.Add(new VocabularyKey(nameof(OriginalRefundLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey IsCheckAuthorized { get; private set; }
        public VocabularyKey CheckNumber { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey CustomerPaymentType { get; private set; }
        public VocabularyKey IsPlanRefund { get; private set; }
        public VocabularyKey IsPrepay { get; private set; }
        public VocabularyKey AuthorizationRetryNumber { get; private set; }
        public VocabularyKey IsOnAccountAuthorized { get; private set; }
        public VocabularyKey PaymentSchedId { get; private set; }
        public VocabularyKey PercentAmount { get; private set; }
        public VocabularyKey PostedAmount { get; private set; }
        public VocabularyKey UniqueCreditCardId { get; private set; }
        public VocabularyKey IsCreditCardProcessed { get; private set; }
        public VocabularyKey RetailGiftCardId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey RetailStoreCardTypeId { get; private set; }
        public VocabularyKey RetailStoreTenderTypeId { get; private set; }
        public VocabularyKey RetailChannelId { get; private set; }
        public VocabularyKey InstallmentSalesOrderId { get; private set; }
        public VocabularyKey InstallmentPaymentScheduleId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey OriginalRefundSalesOrderId { get; private set; }
        public VocabularyKey OriginalRefundPaymentScheduleId { get; private set; }
        public VocabularyKey OriginalRefundLineNumber { get; private set; }
    }
}