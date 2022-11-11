using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesAgreementConfirmationHeaderEntityVocabulary : SimpleVocabulary
    {
        public SalesAgreementConfirmationHeaderEntityVocabulary()
        {
            VocabularyName = "SalesAgreementConfirmationHeaderEntity";
            KeyPrefix = "commonDataModel.salesagreementconfirmationheaderentity";
            KeySeparator = ".";
            Grouping = "/SalesAgreementConfirmationHeaderEntity";

            AddGroup("SalesAgreementConfirmationHeaderEntity Details", group =>
            {
                SellingLegalEntityRecId = group.Add(new VocabularyKey(nameof(SellingLegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SellingLegalEntityId = group.Add(new VocabularyKey(nameof(SellingLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAgreementId = group.Add(new VocabularyKey(nameof(SalesAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementCustomerAccountNumber = group.Add(new VocabularyKey(nameof(AgreementCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAgreementClassificationRecId = group.Add(new VocabularyKey(nameof(SalesAgreementClassificationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAgreementClassificationName = group.Add(new VocabularyKey(nameof(SalesAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                CustomerPaymentMethodName = group.Add(new VocabularyKey(nameof(CustomerPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentMethodSpecificationName = group.Add(new VocabularyKey(nameof(CustomerPaymentMethodSpecificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPoolId = group.Add(new VocabularyKey(nameof(SalesOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CampaignId = group.Add(new VocabularyKey(nameof(CampaignId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionCustomerGroupId = group.Add(new VocabularyKey(nameof(CommissionCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedExchangeRate = group.Add(new VocabularyKey(nameof(FixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitId = group.Add(new VocabularyKey(nameof(SalesUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesResponsible = group.Add(new VocabularyKey(nameof(SalesResponsible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(OrderResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeCustomerGroupId = group.Add(new VocabularyKey(nameof(ChargeCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationNumber = group.Add(new VocabularyKey(nameof(ConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAgreementConfirmationNumber = group.Add(new VocabularyKey(nameof(SalesAgreementConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationCreationDateTime = group.Add(new VocabularyKey(nameof(ConfirmationCreationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyFixedExchangeRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyFixedExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SellingLegalEntityRecId { get; private set; }
        public VocabularyKey SellingLegalEntityId { get; private set; }
        public VocabularyKey SalesAgreementId { get; private set; }
        public VocabularyKey AgreementCustomerAccountNumber { get; private set; }
        public VocabularyKey SalesAgreementClassificationRecId { get; private set; }
        public VocabularyKey SalesAgreementClassificationName { get; private set; }
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
        public VocabularyKey CustomerPaymentMethodName { get; private set; }
        public VocabularyKey CustomerPaymentMethodSpecificationName { get; private set; }
        public VocabularyKey SalesOrderPoolId { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
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
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey CampaignId { get; private set; }
        public VocabularyKey CommissionCustomerGroupId { get; private set; }
        public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey FixedExchangeRate { get; private set; }
        public VocabularyKey SalesUnitId { get; private set; }
        public VocabularyKey SalesResponsible { get; private set; }
        public VocabularyKey OrderResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey CustomerReference { get; private set; }
        public VocabularyKey ChargeCustomerGroupId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey ConfirmationNumber { get; private set; }
        public VocabularyKey SalesAgreementConfirmationNumber { get; private set; }
        public VocabularyKey ConfirmationCreationDateTime { get; private set; }
        public VocabularyKey ReportingCurrencyFixedExchangeRate { get; private set; }


    }
}