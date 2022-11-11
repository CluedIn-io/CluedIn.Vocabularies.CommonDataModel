using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesDocumentDefaultsEntityVocabulary : SimpleVocabulary
    {
        public SalesDocumentDefaultsEntityVocabulary()
        {
            VocabularyName = "SalesDocumentDefaultsEntity";
            KeyPrefix = "commonDataModel.salesdocumentdefaultsentity";
            KeySeparator = ".";
            Grouping = "/SalesDocumentDefaultsEntity";

            AddGroup("SalesDocumentDefaultsEntity Details", group =>
            {
                DefaultBillOfLadingCarrierName = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingCarrierName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBillOfLadingFreightChargeTerms = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingFreightChargeTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBillOfLadingFreightCountingRule = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingFreightCountingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBillOfLadingLanguageId = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBillOfLadingFreightingParty = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingFreightingParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBillOfLadingTrailerLoadingParty = group.Add(new VocabularyKey(nameof(DefaultBillOfLadingTrailerLoadingParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCreditNoteCustomerTransactionSettlementType = group.Add(new VocabularyKey(nameof(DefaultCreditNoteCustomerTransactionSettlementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultEnterprisePortalSalesOrderOriginCode = group.Add(new VocabularyKey(nameof(DefaultEnterprisePortalSalesOrderOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryReservationMethod = group.Add(new VocabularyKey(nameof(DefaultInventoryReservationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReturnOrderValidityPeriodDays = group.Add(new VocabularyKey(nameof(DefaultReturnOrderValidityPeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesOrderOriginCode = group.Add(new VocabularyKey(nameof(DefaultSalesOrderOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesOrderPoolId = group.Add(new VocabularyKey(nameof(DefaultSalesOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesOrderType = group.Add(new VocabularyKey(nameof(DefaultSalesOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesOrderValidityPeriodDays = group.Add(new VocabularyKey(nameof(DefaultSalesOrderValidityPeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesQuotationFollowUpPeriodDays = group.Add(new VocabularyKey(nameof(DefaultSalesQuotationFollowUpPeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesQuotationTypeId = group.Add(new VocabularyKey(nameof(DefaultSalesQuotationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSalesQuotationValidityPeriodDays = group.Add(new VocabularyKey(nameof(DefaultSalesQuotationValidityPeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillAutomaticInventoryReservationConsiderBatchAttributesByDefault = group.Add(new VocabularyKey(nameof(WillAutomaticInventoryReservationConsiderBatchAttributesByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateDate = group.Add(new VocabularyKey(nameof(ExchangeRateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDirectDeliveryChainCreationDeferred = group.Add(new VocabularyKey(nameof(IsDirectDeliveryChainCreationDeferred), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefaultBillOfLadingCarrierName { get; private set; }
        public VocabularyKey DefaultBillOfLadingFreightChargeTerms { get; private set; }
        public VocabularyKey DefaultBillOfLadingFreightCountingRule { get; private set; }
        public VocabularyKey DefaultBillOfLadingLanguageId { get; private set; }
        public VocabularyKey DefaultBillOfLadingFreightingParty { get; private set; }
        public VocabularyKey DefaultBillOfLadingTrailerLoadingParty { get; private set; }
        public VocabularyKey DefaultCreditNoteCustomerTransactionSettlementType { get; private set; }
        public VocabularyKey DefaultEnterprisePortalSalesOrderOriginCode { get; private set; }
        public VocabularyKey DefaultInventoryReservationMethod { get; private set; }
        public VocabularyKey DefaultReturnOrderValidityPeriodDays { get; private set; }
        public VocabularyKey DefaultSalesOrderOriginCode { get; private set; }
        public VocabularyKey DefaultSalesOrderPoolId { get; private set; }
        public VocabularyKey DefaultSalesOrderType { get; private set; }
        public VocabularyKey DefaultSalesOrderValidityPeriodDays { get; private set; }
        public VocabularyKey DefaultSalesQuotationFollowUpPeriodDays { get; private set; }
        public VocabularyKey DefaultSalesQuotationTypeId { get; private set; }
        public VocabularyKey DefaultSalesQuotationValidityPeriodDays { get; private set; }
        public VocabularyKey WillAutomaticInventoryReservationConsiderBatchAttributesByDefault { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }
        public VocabularyKey IsDirectDeliveryChainCreationDeferred { get; private set; }


    }
}