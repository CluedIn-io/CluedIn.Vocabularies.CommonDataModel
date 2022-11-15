using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseAgreementConfirmationHeaderEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseAgreementConfirmationHeaderEntityVocabulary()
        {
            VocabularyName = "Purch Purchase Agreement Confirmation Header Entity";
            KeyPrefix = "commonDataModel.purchpurchaseagreementconfirmationheaderentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseAgreementConfirmationHeaderEntity";

            AddGroup("PurchPurchaseAgreementConfirmationHeaderEntity Details", group =>
            {
                BuyingLegalEntityRecId = group.Add(new VocabularyKey(nameof(BuyingLegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyingLegalEntityId = group.Add(new VocabularyKey(nameof(BuyingLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAgreementId = group.Add(new VocabularyKey(nameof(PurchaseAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementVendorAccountNumber = group.Add(new VocabularyKey(nameof(AgreementVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorReference = group.Add(new VocabularyKey(nameof(VendorReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAgreementClassificationRecId = group.Add(new VocabularyKey(nameof(PurchaseAgreementClassificationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAgreementClassificationName = group.Add(new VocabularyKey(nameof(PurchaseAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementStatus = group.Add(new VocabularyKey(nameof(AgreementStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultEffectiveDate = group.Add(new VocabularyKey(nameof(DefaultEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultExpirationDate = group.Add(new VocabularyKey(nameof(DefaultExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCommitmentType = group.Add(new VocabularyKey(nameof(DefaultCommitmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalDocumentReference = group.Add(new VocabularyKey(nameof(ExternalDocumentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentTitle = group.Add(new VocabularyKey(nameof(DocumentTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreparerRecId = group.Add(new VocabularyKey(nameof(PreparerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreparerPersonPartyNumber = group.Add(new VocabularyKey(nameof(PreparerPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInterestBasedOnCentralEuropeanBank = group.Add(new VocabularyKey(nameof(IsInterestBasedOnCentralEuropeanBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumContractAmount = group.Add(new VocabularyKey(nameof(MaximumContractAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumContractAmount = group.Add(new VocabularyKey(nameof(MinimumContractAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementClassification = group.Add(new VocabularyKey(nameof(ProcurementClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingPurpose = group.Add(new VocabularyKey(nameof(PurchasingPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAgreementRenewable = group.Add(new VocabularyKey(nameof(IsAgreementRenewable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentMethodName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentMethodSpecificationName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodSpecificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderPoolId = group.Add(new VocabularyKey(nameof(PurchaseOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorBankAccountId = group.Add(new VocabularyKey(nameof(VendorBankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeVendorGroupId = group.Add(new VocabularyKey(nameof(ChargeVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryName = group.Add(new VocabularyKey(nameof(DeliveryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressAgreementSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressAgreementSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidFrom = group.Add(new VocabularyKey(nameof(DeliveryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidTo = group.Add(new VocabularyKey(nameof(DeliveryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddress = group.Add(new VocabularyKey(nameof(DeliveryPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationNumber = group.Add(new VocabularyKey(nameof(ConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAgreementConfirmationNumber = group.Add(new VocabularyKey(nameof(PurchaseAgreementConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationCreationDateTime = group.Add(new VocabularyKey(nameof(ConfirmationCreationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BuyingLegalEntityRecId { get; private set; }
        public VocabularyKey BuyingLegalEntityId { get; private set; }
        public VocabularyKey PurchaseAgreementId { get; private set; }
        public VocabularyKey AgreementVendorAccountNumber { get; private set; }
        public VocabularyKey VendorReference { get; private set; }
        public VocabularyKey PurchaseAgreementClassificationRecId { get; private set; }
        public VocabularyKey PurchaseAgreementClassificationName { get; private set; }
        public VocabularyKey AgreementStatus { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DefaultEffectiveDate { get; private set; }
        public VocabularyKey DefaultExpirationDate { get; private set; }
        public VocabularyKey DefaultCommitmentType { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ExternalDocumentReference { get; private set; }
        public VocabularyKey DocumentTitle { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey PreparerRecId { get; private set; }
        public VocabularyKey PreparerPersonPartyNumber { get; private set; }
        public VocabularyKey IsInterestBasedOnCentralEuropeanBank { get; private set; }
        public VocabularyKey MaximumContractAmount { get; private set; }
        public VocabularyKey MinimumContractAmount { get; private set; }
        public VocabularyKey ProcurementClassification { get; private set; }
        public VocabularyKey PurchasingPurpose { get; private set; }
        public VocabularyKey IsAgreementRenewable { get; private set; }
        public VocabularyKey BuyerGroupId { get; private set; }
        public VocabularyKey VendorPaymentMethodName { get; private set; }
        public VocabularyKey VendorPaymentMethodSpecificationName { get; private set; }
        public VocabularyKey PurchaseOrderPoolId { get; private set; }
        public VocabularyKey VendorBankAccountId { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey ChargeVendorGroupId { get; private set; }
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey DeliveryName { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey IsDeliveryAddressAgreementSpecific { get; private set; }
        public VocabularyKey FormattedDeliveryAddress { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCityInKana { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCountyId { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressPostBox { get; private set; }
        public VocabularyKey DeliveryAddressStateId { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressValidFrom { get; private set; }
        public VocabularyKey DeliveryAddressValidTo { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryPostalAddress { get; private set; }
        public VocabularyKey ConfirmationNumber { get; private set; }
        public VocabularyKey PurchaseAgreementConfirmationNumber { get; private set; }
        public VocabularyKey ConfirmationCreationDateTime { get; private set; }
    }
}