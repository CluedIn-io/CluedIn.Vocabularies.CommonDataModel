using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesQuotationHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public SalesQuotationHeaderV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesQuotationHeaderV2Entity";
            KeyPrefix = "commonDataModel.salesquotationheaderv2entity";
            KeySeparator = ".";
            Grouping = "/SalesQuotationHeaderV2Entity";

            AddGroup("Common Data Model SalesQuotationHeaderV2Entity Details", group =>
            {
                SalesQuotationNumber = group.Add(new VocabularyKey(nameof(SalesQuotationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationStatus = group.Add(new VocabularyKey(nameof(SalesQuotationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationTypeId = group.Add(new VocabularyKey(nameof(SalesQuotationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationExpiryDate = group.Add(new VocabularyKey(nameof(SalesQuotationExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationFollowUpActivity = group.Add(new VocabularyKey(nameof(QuotationFollowUpActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationFollowUpDate = group.Add(new VocabularyKey(nameof(SalesQuotationFollowUpDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankDocumentType = group.Add(new VocabularyKey(nameof(BankDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressRefTableId = group.Add(new VocabularyKey(nameof(AddressRefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressRefRecId = group.Add(new VocabularyKey(nameof(AddressRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(RequestingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersReference = group.Add(new VocabularyKey(nameof(CustomersReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(SalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryReasonCode = group.Add(new VocabularyKey(nameof(DeliveryReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportReason = group.Add(new VocabularyKey(nameof(ExportReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedDueDate = group.Add(new VocabularyKey(nameof(FixedDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedExchangeRate = group.Add(new VocabularyKey(nameof(FixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultShippingWarehouseId = group.Add(new VocabularyKey(nameof(DefaultShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultShippingSiteId = group.Add(new VocabularyKey(nameof(DefaultShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EUSalesListCode = group.Add(new VocabularyKey(nameof(EUSalesListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCustomerGroupId = group.Add(new VocabularyKey(nameof(ChargeCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(MultilineDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroupId = group.Add(new VocabularyKey(nameof(NumberSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentMethodName = group.Add(new VocabularyKey(nameof(CustomerPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentMethodSpecificationName = group.Add(new VocabularyKey(nameof(CustomerPaymentMethodSpecificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatPortId = group.Add(new VocabularyKey(nameof(IntrastatPortId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPostingProfileId = group.Add(new VocabularyKey(nameof(CustomerPostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptDateRequested = group.Add(new VocabularyKey(nameof(ReceiptDateRequested), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationName = group.Add(new VocabularyKey(nameof(SalesQuotationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderOriginCode = group.Add(new VocabularyKey(nameof(SalesOrderOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPoolId = group.Add(new VocabularyKey(nameof(SalesOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitId = group.Add(new VocabularyKey(nameof(SalesUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTransactionSettlementType = group.Add(new VocabularyKey(nameof(CustomerTransactionSettlementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestedShippingDate = group.Add(new VocabularyKey(nameof(RequestedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticsProcedureCode = group.Add(new VocabularyKey(nameof(IntrastatStatisticsProcedureCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesResponsible = group.Add(new VocabularyKey(nameof(SalesResponsible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaker = group.Add(new VocabularyKey(nameof(SalesTaker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(QuotationResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTakerPersonnelNumber = group.Add(new VocabularyKey(nameof(QuotationTakerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProspectId = group.Add(new VocabularyKey(nameof(ProspectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountPercentage = group.Add(new VocabularyKey(nameof(CashDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CampaignId = group.Add(new VocabularyKey(nameof(CampaignId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionCustomerGroupId = group.Add(new VocabularyKey(nameof(CommissionCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationConfirmationDate = group.Add(new VocabularyKey(nameof(SalesQuotationConfirmationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualEntryChangepolicy = group.Add(new VocabularyKey(nameof(ManualEntryChangepolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeleMarketingCallListId = group.Add(new VocabularyKey(nameof(TeleMarketingCallListId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCustomerFinalUser = group.Add(new VocabularyKey(nameof(IsCustomerFinalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFineCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFinancialInterestCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFinancialInterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpportunityId = group.Add(new VocabularyKey(nameof(OpportunityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratedSalesOrderNumber = group.Add(new VocabularyKey(nameof(GeneratedSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementId = group.Add(new VocabularyKey(nameof(ServiceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationDocumentConclusionName = group.Add(new VocabularyKey(nameof(QuotationDocumentConclusionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationDocumentIntroductionName = group.Add(new VocabularyKey(nameof(QuotationDocumentIntroductionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationDocumentTitleName = group.Add(new VocabularyKey(nameof(QuotationDocumentTitleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesQuotationTemplateActive = group.Add(new VocabularyKey(nameof(IsSalesQuotationTemplateActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationTemplateGroupId = group.Add(new VocabularyKey(nameof(SalesQuotationTemplateGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationTemplateName = group.Add(new VocabularyKey(nameof(SalesQuotationTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationReasonCode = group.Add(new VocabularyKey(nameof(QuotationReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPurchOperationTypeRecId = group.Add(new VocabularyKey(nameof(SalesPurchOperationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentOperationTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentOperationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreet = group.Add(new VocabularyKey(nameof(InvoiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedInvoiceAddress = group.Add(new VocabularyKey(nameof(FormattedInvoiceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceBuildingCompliment = group.Add(new VocabularyKey(nameof(InvoiceBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCity = group.Add(new VocabularyKey(nameof(InvoiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountyId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressDistrictName = group.Add(new VocabularyKey(nameof(InvoiceAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoiceAddressPrivate = group.Add(new VocabularyKey(nameof(IsInvoiceAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLatitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLongitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressPostBox = group.Add(new VocabularyKey(nameof(InvoiceAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStateId = group.Add(new VocabularyKey(nameof(InvoiceAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressTimeZone = group.Add(new VocabularyKey(nameof(InvoiceAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressZipCode = group.Add(new VocabularyKey(nameof(InvoiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetInKana = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCityInKana = group.Add(new VocabularyKey(nameof(InvoiceAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalAmount = group.Add(new VocabularyKey(nameof(QuotationTotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalChargesAmount = group.Add(new VocabularyKey(nameof(QuotationTotalChargesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalDiscountAmount = group.Add(new VocabularyKey(nameof(QuotationTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationTotalTaxAmount = group.Add(new VocabularyKey(nameof(QuotationTotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuotationHeaderTaxAmount = group.Add(new VocabularyKey(nameof(QuotationHeaderTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreTotalsCalculated = group.Add(new VocabularyKey(nameof(AreTotalsCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidTo = group.Add(new VocabularyKey(nameof(InvoiceValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceValidFrom = group.Add(new VocabularyKey(nameof(InvoiceValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyFixedExchangeRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyFixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationCalculatedTotalsRecId = group.Add(new VocabularyKey(nameof(SalesQuotationCalculatedTotalsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesQuotationNumber { get; private set; }
        public VocabularyKey SalesQuotationStatus { get; private set; }
        public VocabularyKey SalesQuotationTypeId { get; private set; }
        public VocabularyKey SalesQuotationExpiryDate { get; private set; }
        public VocabularyKey QuotationFollowUpActivity { get; private set; }
        public VocabularyKey SalesQuotationFollowUpDate { get; private set; }
        public VocabularyKey BankDocumentType { get; private set; }
        public VocabularyKey AddressRefTableId { get; private set; }
        public VocabularyKey AddressRefRecId { get; private set; }
        public VocabularyKey RequestingCustomerAccountNumber { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey LineDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomersReference { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey SalesOrderPromisingMethod { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey TotalDiscountPercentage { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryReasonCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey TotalDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey ExportReason { get; private set; }
        public VocabularyKey FixedDueDate { get; private set; }
        public VocabularyKey FixedExchangeRate { get; private set; }
        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey DefaultShippingWarehouseId { get; private set; }
        public VocabularyKey DefaultShippingSiteId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey EUSalesListCode { get; private set; }
        public VocabularyKey ChargeCustomerGroupId { get; private set; }
        public VocabularyKey MultilineDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey NumberSequenceGroupId { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey CustomerPaymentMethodName { get; private set; }
        public VocabularyKey CustomerPaymentMethodSpecificationName { get; private set; }
        public VocabularyKey IntrastatPortId { get; private set; }
        public VocabularyKey CustomerPostingProfileId { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey ReceiptDateRequested { get; private set; }
        public VocabularyKey SalesQuotationName { get; private set; }
        public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
        public VocabularyKey SalesOrderOriginCode { get; private set; }
        public VocabularyKey SalesOrderPoolId { get; private set; }
        public VocabularyKey SalesUnitId { get; private set; }
        public VocabularyKey CustomerTransactionSettlementType { get; private set; }
        public VocabularyKey RequestedShippingDate { get; private set; }
        public VocabularyKey IntrastatStatisticsProcedureCode { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey SalesResponsible { get; private set; }
        public VocabularyKey SalesTaker { get; private set; }
        public VocabularyKey QuotationResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey QuotationTakerPersonnelNumber { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ProspectId { get; private set; }
        public VocabularyKey CashDiscountPercentage { get; private set; }
        public VocabularyKey CampaignId { get; private set; }
        public VocabularyKey CommissionCustomerGroupId { get; private set; }
        public VocabularyKey SalesQuotationConfirmationDate { get; private set; }
        public VocabularyKey ManualEntryChangepolicy { get; private set; }
        public VocabularyKey TeleMarketingCallListId { get; private set; }
        public VocabularyKey IsCustomerFinalUser { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey CustomerPaymentFineCode { get; private set; }
        public VocabularyKey CustomerPaymentFinancialInterestCode { get; private set; }
        public VocabularyKey OpportunityId { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressCityInKana { get; private set; }
        public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
        public VocabularyKey GeneratedSalesOrderNumber { get; private set; }
        public VocabularyKey ServiceAgreementId { get; private set; }
        public VocabularyKey QuotationDocumentConclusionName { get; private set; }
        public VocabularyKey QuotationDocumentIntroductionName { get; private set; }
        public VocabularyKey QuotationDocumentTitleName { get; private set; }
        public VocabularyKey IsSalesQuotationTemplateActive { get; private set; }
        public VocabularyKey SalesQuotationTemplateGroupId { get; private set; }
        public VocabularyKey SalesQuotationTemplateName { get; private set; }
        public VocabularyKey QuotationReasonCode { get; private set; }
        public VocabularyKey SalesPurchOperationTypeRecId { get; private set; }
        public VocabularyKey FiscalDocumentOperationTypeId { get; private set; }
        public VocabularyKey InvoiceAddressStreet { get; private set; }
        public VocabularyKey FormattedInvoiceAddress { get; private set; }
        public VocabularyKey InvoiceBuildingCompliment { get; private set; }
        public VocabularyKey InvoiceAddressCity { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceAddressCountyId { get; private set; }
        public VocabularyKey InvoiceAddressDistrictName { get; private set; }
        public VocabularyKey IsInvoiceAddressPrivate { get; private set; }
        public VocabularyKey InvoiceAddressLatitude { get; private set; }
        public VocabularyKey InvoiceAddressLongitude { get; private set; }
        public VocabularyKey InvoiceAddressPostBox { get; private set; }
        public VocabularyKey InvoiceAddressStateId { get; private set; }
        public VocabularyKey InvoiceAddressStreetNumber { get; private set; }
        public VocabularyKey InvoiceAddressTimeZone { get; private set; }
        public VocabularyKey InvoiceAddressZipCode { get; private set; }
        public VocabularyKey InvoiceAddressStreetInKana { get; private set; }
        public VocabularyKey InvoiceAddressCityInKana { get; private set; }
        public VocabularyKey QuotationTotalAmount { get; private set; }
        public VocabularyKey QuotationTotalChargesAmount { get; private set; }
        public VocabularyKey QuotationTotalDiscountAmount { get; private set; }
        public VocabularyKey QuotationTotalTaxAmount { get; private set; }
        public VocabularyKey QuotationHeaderTaxAmount { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey AreTotalsCalculated { get; private set; }
        public VocabularyKey InvoiceValidTo { get; private set; }
        public VocabularyKey InvoiceValidFrom { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ReportingCurrencyFixedExchangeRate { get; private set; }
        public VocabularyKey SalesQuotationCalculatedTotalsRecId { get; private set; }


    }
}