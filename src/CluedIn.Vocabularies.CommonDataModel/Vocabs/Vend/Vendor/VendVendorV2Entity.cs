using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorV2EntityVocabulary : SimpleVocabulary
    {
        public VendVendorV2EntityVocabulary()
        {
            VocabularyName = "VendVendorV2Entity";
            KeyPrefix = "commonDataModel.vendvendorv2entity";
            KeySeparator = ".";
            Grouping = "/VendVendorV2Entity";

            AddGroup("VendVendorV2Entity Details", group =>
            {
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(WithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPaymentTermsName = group.Add(new VocabularyKey(nameof(DefaultPaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeText = group.Add(new VocabularyKey(nameof(CentralBankPurposeText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasOnlyTakenBids = group.Add(new VocabularyKey(nameof(HasOnlyTakenBids), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHoldStatus = group.Add(new VocabularyKey(nameof(OnHoldStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorHoldReleaseDate = group.Add(new VocabularyKey(nameof(VendorHoldReleaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseOrderChangeRequestOverrideAllowed = group.Add(new VocabularyKey(nameof(IsPurchaseOrderChangeRequestOverrideAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsChangeManagementActivated = group.Add(new VocabularyKey(nameof(IsChangeManagementActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsChangeMangementOverrideByVendorAllowed = group.Add(new VocabularyKey(nameof(IsChangeMangementOverrideByVendorAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CISCompanyRegistrationNumber = group.Add(new VocabularyKey(nameof(CISCompanyRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CISNationalInsuranceNumber = group.Add(new VocabularyKey(nameof(CISNationalInsuranceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CISStatus = group.Add(new VocabularyKey(nameof(CISStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CISUniqueTaxPayerReference = group.Add(new VocabularyKey(nameof(CISUniqueTaxPayerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CISVerificationDate = group.Add(new VocabularyKey(nameof(CISVerificationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CISVerificationNumber = group.Add(new VocabularyKey(nameof(CISVerificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingPeriodPaymentTermsId = group.Add(new VocabularyKey(nameof(ClearingPeriodPaymentTermsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommercialRegisterName = group.Add(new VocabularyKey(nameof(CommercialRegisterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommercialRegisterInsetNumber = group.Add(new VocabularyKey(nameof(CommercialRegisterInsetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommercialRegisterSection = group.Add(new VocabularyKey(nameof(CommercialRegisterSection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyChainName = group.Add(new VocabularyKey(nameof(CompanyChainName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiretNumber = group.Add(new VocabularyKey(nameof(SiretNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NAFCodeRef = group.Add(new VocabularyKey(nameof(NAFCodeRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyType = group.Add(new VocabularyKey(nameof(CompanyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPersonId = group.Add(new VocabularyKey(nameof(PrimaryContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditRating = group.Add(new VocabularyKey(nameof(CreditRating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UniquePopulationRegistryCode = group.Add(new VocabularyKey(nameof(UniquePopulationRegistryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099DoingBusinessAsName = group.Add(new VocabularyKey(nameof(Tax1099DoingBusinessAsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryStatusId = group.Add(new VocabularyKey(nameof(DefaultInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCode = group.Add(new VocabularyKey(nameof(DestinationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DIOTCountryCode = group.Add(new VocabularyKey(nameof(DIOTCountryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOwnerDisabled = group.Add(new VocabularyKey(nameof(IsOwnerDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDeliveryModeId = group.Add(new VocabularyKey(nameof(DefaultDeliveryModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDeliveryTermsCode = group.Add(new VocabularyKey(nameof(DefaultDeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTotalDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(DefaultTotalDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EthnicOriginId = group.Add(new VocabularyKey(nameof(EthnicOriginId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FactoringVendorAccountNumber = group.Add(new VocabularyKey(nameof(FactoringVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWomanOwner = group.Add(new VocabularyKey(nameof(IsWomanOwner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCode = group.Add(new VocabularyKey(nameof(FiscalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsForeignEntity = group.Add(new VocabularyKey(nameof(IsForeignEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignVendorTaxRegistrationId = group.Add(new VocabularyKey(nameof(ForeignVendorTaxRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UPSFreightZone = group.Add(new VocabularyKey(nameof(UPSFreightZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVendorLocatedInHUBZone = group.Add(new VocabularyKey(nameof(IsVendorLocatedInHUBZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProcumentWarehouseId = group.Add(new VocabularyKey(nameof(DefaultProcumentWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPurchaseSiteId = group.Add(new VocabularyKey(nameof(DefaultPurchaseSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineOfBusinessId = group.Add(new VocabularyKey(nameof(LineOfBusinessId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVendorLocallyOwned = group.Add(new VocabularyKey(nameof(IsVendorLocallyOwned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTransactionCodeRef = group.Add(new VocabularyKey(nameof(PaymentTransactionCodeRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainContactWorkerPersonnelNumberRef = group.Add(new VocabularyKey(nameof(MainContactWorkerPersonnelNumberRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeVendorGroupId = group.Add(new VocabularyKey(nameof(ChargeVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceLineMatchingPolicy = group.Add(new VocabularyKey(nameof(VendorInvoiceLineMatchingPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMinorityOwned = group.Add(new VocabularyKey(nameof(IsMinorityOwned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(MultilineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameControl = group.Add(new VocabularyKey(nameof(NameControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nationality = group.Add(new VocabularyKey(nameof(Nationality), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroupId = group.Add(new VocabularyKey(nameof(NumberSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOffsetAccountType = group.Add(new VocabularyKey(nameof(DefaultOffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOffsetLedgerAccount = group.Add(new VocabularyKey(nameof(DefaultOffsetLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOneTimeVendor = group.Add(new VocabularyKey(nameof(IsOneTimeVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DIOTOperationType = group.Add(new VocabularyKey(nameof(DIOTOperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NationalRegistryNumberId = group.Add(new VocabularyKey(nameof(NationalRegistryNumberId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Party = group.Add(new VocabularyKey(nameof(Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPaymentDayName = group.Add(new VocabularyKey(nameof(DefaultPaymentDayName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentId = group.Add(new VocabularyKey(nameof(PaymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVendorPaymentMethodName = group.Add(new VocabularyKey(nameof(DefaultVendorPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPaymentScheduleName = group.Add(new VocabularyKey(nameof(DefaultPaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSpecificationId = group.Add(new VocabularyKey(nameof(PaymentSpecificationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceVendorGroupId = group.Add(new VocabularyKey(nameof(PriceVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseOrderIncludePricesAndAmounts = group.Add(new VocabularyKey(nameof(WillPurchaseOrderIncludePricesAndAmounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseWorkCalendarId = group.Add(new VocabularyKey(nameof(PurchaseWorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPurchaseOrderPoolId = group.Add(new VocabularyKey(nameof(DefaultPurchaseOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFCFederalTaxNumber = group.Add(new VocabularyKey(nameof(RFCFederalTaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFlaggedWithSecondTIN = group.Add(new VocabularyKey(nameof(IsFlaggedWithSecondTIN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessSegmentCode = group.Add(new VocabularyKey(nameof(BusinessSegmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSmallBusiness = group.Add(new VocabularyKey(nameof(IsSmallBusiness), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateInscription = group.Add(new VocabularyKey(nameof(StateInscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessSubsegmentCode = group.Add(new VocabularyKey(nameof(BusinessSubsegmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSupplementaryProductVendorGroupId = group.Add(new VocabularyKey(nameof(DefaultSupplementaryProductVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRebateVendorGroupId = group.Add(new VocabularyKey(nameof(PurchaseRebateVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099BoxIdRef = group.Add(new VocabularyKey(nameof(Tax1099BoxIdRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099NameToUse = group.Add(new VocabularyKey(nameof(Tax1099NameToUse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099FederalTaxId = group.Add(new VocabularyKey(nameof(Tax1099FederalTaxId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportingTax1099 = group.Add(new VocabularyKey(nameof(IsReportingTax1099), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099IdType = group.Add(new VocabularyKey(nameof(Tax1099IdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWithholdingTaxCalculated = group.Add(new VocabularyKey(nameof(IsWithholdingTaxCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCashDiscountUsage = group.Add(new VocabularyKey(nameof(DefaultCashDiscountUsage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorExceptionGroupIdRef = group.Add(new VocabularyKey(nameof(VendorExceptionGroupIdRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDeclarationIdRef = group.Add(new VocabularyKey(nameof(InvoiceDeclarationIdRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescriptionVendorGroupId = group.Add(new VocabularyKey(nameof(ProductDescriptionVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DIOTVendorType = group.Add(new VocabularyKey(nameof(DIOTVendorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPriceToleranceGroupId = group.Add(new VocabularyKey(nameof(VendorPriceToleranceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceVeteranOwned = group.Add(new VocabularyKey(nameof(IsServiceVeteranOwned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsW9Received = group.Add(new VocabularyKey(nameof(IsW9Received), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsW9CheckingEnabled = group.Add(new VocabularyKey(nameof(IsW9CheckingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OurAccountNumber = group.Add(new VocabularyKey(nameof(OurAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NAFCode = group.Add(new VocabularyKey(nameof(NAFCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceDeclarationId = group.Add(new VocabularyKey(nameof(VendorInvoiceDeclarationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTransactionCode = group.Add(new VocabularyKey(nameof(PaymentTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainContactPersonnelNumber = group.Add(new VocabularyKey(nameof(MainContactPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099BoxId = group.Add(new VocabularyKey(nameof(Tax1099BoxId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tax1099Type = group.Add(new VocabularyKey(nameof(Tax1099Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorExceptionGroupId = group.Add(new VocabularyKey(nameof(VendorExceptionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOffsetLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(DefaultOffsetLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBooks = group.Add(new VocabularyKey(nameof(AddressBooks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountyId = group.Add(new VocabularyKey(nameof(AddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStateId = group.Add(new VocabularyKey(nameof(AddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBrazilianCNPJOrCPF = group.Add(new VocabularyKey(nameof(AddressBrazilianCNPJOrCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBrazilianIE = group.Add(new VocabularyKey(nameof(AddressBrazilianIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedPrimaryAddress = group.Add(new VocabularyKey(nameof(FormattedPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorKnownAsName = group.Add(new VocabularyKey(nameof(VendorKnownAsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorOrganizationName = group.Add(new VocabularyKey(nameof(VendorOrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorSearchName = group.Add(new VocabularyKey(nameof(VendorSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationABCCode = group.Add(new VocabularyKey(nameof(OrganizationABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationEmployeeAmount = group.Add(new VocabularyKey(nameof(OrganizationEmployeeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationPhoneticName = group.Add(new VocabularyKey(nameof(OrganizationPhoneticName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPartyNumber = group.Add(new VocabularyKey(nameof(VendorPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPartyType = group.Add(new VocabularyKey(nameof(VendorPartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryDay = group.Add(new VocabularyKey(nameof(PersonAnniversaryDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryMonth = group.Add(new VocabularyKey(nameof(PersonAnniversaryMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryYear = group.Add(new VocabularyKey(nameof(PersonAnniversaryYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthDay = group.Add(new VocabularyKey(nameof(PersonBirthDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthMonth = group.Add(new VocabularyKey(nameof(PersonBirthMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonBirthYear = group.Add(new VocabularyKey(nameof(PersonBirthYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonChildrenNames = group.Add(new VocabularyKey(nameof(PersonChildrenNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonGender = group.Add(new VocabularyKey(nameof(PersonGender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonHobbies = group.Add(new VocabularyKey(nameof(PersonHobbies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonFirstName = group.Add(new VocabularyKey(nameof(PersonFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonMiddleName = group.Add(new VocabularyKey(nameof(PersonMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonLastNamePrefix = group.Add(new VocabularyKey(nameof(PersonLastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonLastName = group.Add(new VocabularyKey(nameof(PersonLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonInitials = group.Add(new VocabularyKey(nameof(PersonInitials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonMaritalStatus = group.Add(new VocabularyKey(nameof(PersonMaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPersonalSuffix = group.Add(new VocabularyKey(nameof(PersonPersonalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPersonalTitle = group.Add(new VocabularyKey(nameof(PersonPersonalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticFirstName = group.Add(new VocabularyKey(nameof(PersonPhoneticFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticLastName = group.Add(new VocabularyKey(nameof(PersonPhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticMiddleName = group.Add(new VocabularyKey(nameof(PersonPhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonProfessionalSuffix = group.Add(new VocabularyKey(nameof(PersonProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonProfessionalTitle = group.Add(new VocabularyKey(nameof(PersonProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryEmailAddress = group.Add(new VocabularyKey(nameof(PrimaryEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryEmailAddressDescription = group.Add(new VocabularyKey(nameof(PrimaryEmailAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryEmailAddressIMEnabled = group.Add(new VocabularyKey(nameof(IsPrimaryEmailAddressIMEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryEmailAddressPurpose = group.Add(new VocabularyKey(nameof(PrimaryEmailAddressPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFaxNumber = group.Add(new VocabularyKey(nameof(PrimaryFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFaxNumberDescription = group.Add(new VocabularyKey(nameof(PrimaryFaxNumberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFaxNumberExtension = group.Add(new VocabularyKey(nameof(PrimaryFaxNumberExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFaxNumberPurpose = group.Add(new VocabularyKey(nameof(PrimaryFaxNumberPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryPhoneNumber = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryPhoneNumberDescription = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryPhoneNumberMobile = group.Add(new VocabularyKey(nameof(IsPrimaryPhoneNumberMobile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryPhoneNumberPurpose = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumberPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTelex = group.Add(new VocabularyKey(nameof(PrimaryTelex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTelexDescription = group.Add(new VocabularyKey(nameof(PrimaryTelexDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTelexPurpose = group.Add(new VocabularyKey(nameof(PrimaryTelexPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryURL = group.Add(new VocabularyKey(nameof(PrimaryURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryURLDescription = group.Add(new VocabularyKey(nameof(PrimaryURLDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryURLPurpose = group.Add(new VocabularyKey(nameof(PrimaryURLPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFacebook = group.Add(new VocabularyKey(nameof(PrimaryFacebook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFacebookDescription = group.Add(new VocabularyKey(nameof(PrimaryFacebookDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryFacebookPurpose = group.Add(new VocabularyKey(nameof(PrimaryFacebookPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryLinkedIn = group.Add(new VocabularyKey(nameof(PrimaryLinkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryLinkedInDescription = group.Add(new VocabularyKey(nameof(PrimaryLinkedInDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryLinkedInPurpose = group.Add(new VocabularyKey(nameof(PrimaryLinkedInPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTwitter = group.Add(new VocabularyKey(nameof(PrimaryTwitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTwitterDescription = group.Add(new VocabularyKey(nameof(PrimaryTwitterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryTwitterPurpose = group.Add(new VocabularyKey(nameof(PrimaryTwitterPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchaseOrderProcessingSummaryUpdatePurchaseOrder = group.Add(new VocabularyKey(nameof(WillPurchaseOrderProcessingSummaryUpdatePurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillProductReceiptProcessingSummaryUpdatePurchaseOrder = group.Add(new VocabularyKey(nameof(WillProductReceiptProcessingSummaryUpdatePurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillReceiptsListProcessingSummaryUpdatePurchaseOrder = group.Add(new VocabularyKey(nameof(WillReceiptsListProcessingSummaryUpdatePurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInvoiceProcessingSummaryUpdatePurchaseOrder = group.Add(new VocabularyKey(nameof(WillInvoiceProcessingSummaryUpdatePurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCUSIPIdentificationNumberApplicable = group.Add(new VocabularyKey(nameof(IsCUSIPIdentificationNumberApplicable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CUSIPIdentificationNumber = group.Add(new VocabularyKey(nameof(CUSIPIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CUSIPDetails = group.Add(new VocabularyKey(nameof(CUSIPDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OIDInvestorType = group.Add(new VocabularyKey(nameof(OIDInvestorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OIDNomineeDetails = group.Add(new VocabularyKey(nameof(OIDNomineeDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ISNationalRegistryNumber = group.Add(new VocabularyKey(nameof(ISNationalRegistryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxVendorType = group.Add(new VocabularyKey(nameof(WithholdingTaxVendorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderConsolidationDayOfMonth = group.Add(new VocabularyKey(nameof(PurchaseOrderConsolidationDayOfMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentFeeGroupId = group.Add(new VocabularyKey(nameof(PaymentFeeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVendorPayingBankPaymentFee = group.Add(new VocabularyKey(nameof(IsVendorPayingBankPaymentFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianCCM = group.Add(new VocabularyKey(nameof(BrazilianCCM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianCNPJOrCPF = group.Add(new VocabularyKey(nameof(BrazilianCNPJOrCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianCNAE = group.Add(new VocabularyKey(nameof(BrazilianCNAE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignerId = group.Add(new VocabularyKey(nameof(ForeignerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianIE = group.Add(new VocabularyKey(nameof(BrazilianIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianNIT = group.Add(new VocabularyKey(nameof(BrazilianNIT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOperationPresenceType = group.Add(new VocabularyKey(nameof(FiscalOperationPresenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceDeliveryAddressBased = group.Add(new VocabularyKey(nameof(IsServiceDeliveryAddressBased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchaseConsumed = group.Add(new VocabularyKey(nameof(IsPurchaseConsumed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianINSSCEI = group.Add(new VocabularyKey(nameof(BrazilianINSSCEI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIncomingFiscalDocumentGenerated = group.Add(new VocabularyKey(nameof(IsIncomingFiscalDocumentGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsICMSContributor = group.Add(new VocabularyKey(nameof(IsICMSContributor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompositionScheme = group.Add(new VocabularyKey(nameof(CompositionScheme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignVendor = group.Add(new VocabularyKey(nameof(ForeignVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GTAVendor = group.Add(new VocabularyKey(nameof(GTAVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferentialVendor = group.Add(new VocabularyKey(nameof(PreferentialVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SSIVendor = group.Add(new VocabularyKey(nameof(SSIVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NatureOfAssessee = group.Add(new VocabularyKey(nameof(NatureOfAssessee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PANNumber = group.Add(new VocabularyKey(nameof(PANNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PANReferenceNumber = group.Add(new VocabularyKey(nameof(PANReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PANStatus = group.Add(new VocabularyKey(nameof(PANStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SSIValidityDate = group.Add(new VocabularyKey(nameof(SSIValidityDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSGroup = group.Add(new VocabularyKey(nameof(TCSGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSGroup = group.Add(new VocabularyKey(nameof(TDSGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPortalCollaborationMethod = group.Add(new VocabularyKey(nameof(VendorPortalCollaborationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryPhoneNumberExtension = group.Add(new VocabularyKey(nameof(PrimaryPhoneNumberExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZakatRegistrationNumber = group.Add(new VocabularyKey(nameof(ZakatRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZakatFileNumber = group.Add(new VocabularyKey(nameof(ZakatFileNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSubcontractor = group.Add(new VocabularyKey(nameof(IsSubcontractor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZakatServiceType = group.Add(new VocabularyKey(nameof(ZakatServiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentFineCode = group.Add(new VocabularyKey(nameof(VendorPaymentFineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentFinancialInterestCode = group.Add(new VocabularyKey(nameof(VendorPaymentFinancialInterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthPlace = group.Add(new VocabularyKey(nameof(BirthPlace), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthCountyCode = group.Add(new VocabularyKey(nameof(BirthCountyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResidenceForeignCountryRegionId = group.Add(new VocabularyKey(nameof(ResidenceForeignCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentIncomeCode = group.Add(new VocabularyKey(nameof(FiscalDocumentIncomeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DUNSNumber = group.Add(new VocabularyKey(nameof(DUNSNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsGSTCompositionSchemeEnabled = group.Add(new VocabularyKey(nameof(IsGSTCompositionSchemeEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankOrderOfPayment = group.Add(new VocabularyKey(nameof(BankOrderOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignResident = group.Add(new VocabularyKey(nameof(ForeignResident), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfile = group.Add(new VocabularyKey(nameof(InventoryProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryProfileType = group.Add(new VocabularyKey(nameof(InventoryProfileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeparateDivisionId = group.Add(new VocabularyKey(nameof(SeparateDivisionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StructureDepartment = group.Add(new VocabularyKey(nameof(StructureDepartment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxOperationCode = group.Add(new VocabularyKey(nameof(TaxOperationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPartnerKind = group.Add(new VocabularyKey(nameof(TaxPartnerKind), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAgent = group.Add(new VocabularyKey(nameof(TaxAgent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactFaxRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactEmailRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactURLRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressRecordId = group.Add(new VocabularyKey(nameof(AddressRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey WithholdingTaxGroupCode { get; private set; }
        public VocabularyKey DefaultPaymentTermsName { get; private set; }
        public VocabularyKey LineDiscountVendorGroupCode { get; private set; }
        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey CentralBankPurposeCode { get; private set; }
        public VocabularyKey CentralBankPurposeText { get; private set; }
        public VocabularyKey HasOnlyTakenBids { get; private set; }
        public VocabularyKey OnHoldStatus { get; private set; }
        public VocabularyKey VendorHoldReleaseDate { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey IsPurchaseOrderChangeRequestOverrideAllowed { get; private set; }
        public VocabularyKey IsChangeManagementActivated { get; private set; }
        public VocabularyKey IsChangeMangementOverrideByVendorAllowed { get; private set; }
        public VocabularyKey CISCompanyRegistrationNumber { get; private set; }
        public VocabularyKey CISNationalInsuranceNumber { get; private set; }
        public VocabularyKey CISStatus { get; private set; }
        public VocabularyKey CISUniqueTaxPayerReference { get; private set; }
        public VocabularyKey CISVerificationDate { get; private set; }
        public VocabularyKey CISVerificationNumber { get; private set; }
        public VocabularyKey ClearingPeriodPaymentTermsId { get; private set; }
        public VocabularyKey CommercialRegisterName { get; private set; }
        public VocabularyKey CommercialRegisterInsetNumber { get; private set; }
        public VocabularyKey CommercialRegisterSection { get; private set; }
        public VocabularyKey CompanyChainName { get; private set; }
        public VocabularyKey SiretNumber { get; private set; }
        public VocabularyKey NAFCodeRef { get; private set; }
        public VocabularyKey CompanyType { get; private set; }
        public VocabularyKey PrimaryContactPersonId { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CreditRating { get; private set; }
        public VocabularyKey UniquePopulationRegistryCode { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey Tax1099DoingBusinessAsName { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey DefaultInventoryStatusId { get; private set; }
        public VocabularyKey DestinationCode { get; private set; }
        public VocabularyKey DIOTCountryCode { get; private set; }
        public VocabularyKey IsOwnerDisabled { get; private set; }
        public VocabularyKey DefaultDeliveryModeId { get; private set; }
        public VocabularyKey DefaultDeliveryTermsCode { get; private set; }
        public VocabularyKey DefaultTotalDiscountVendorGroupCode { get; private set; }
        public VocabularyKey EthnicOriginId { get; private set; }
        public VocabularyKey FactoringVendorAccountNumber { get; private set; }
        public VocabularyKey IsWomanOwner { get; private set; }
        public VocabularyKey FiscalCode { get; private set; }
        public VocabularyKey IsForeignEntity { get; private set; }
        public VocabularyKey ForeignVendorTaxRegistrationId { get; private set; }
        public VocabularyKey UPSFreightZone { get; private set; }
        public VocabularyKey IsVendorLocatedInHUBZone { get; private set; }
        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey DefaultProcumentWarehouseId { get; private set; }
        public VocabularyKey DefaultPurchaseSiteId { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }
        public VocabularyKey BuyerGroupId { get; private set; }
        public VocabularyKey LineOfBusinessId { get; private set; }
        public VocabularyKey IsVendorLocallyOwned { get; private set; }
        public VocabularyKey PaymentTransactionCodeRef { get; private set; }
        public VocabularyKey MainContactWorkerPersonnelNumberRef { get; private set; }
        public VocabularyKey ChargeVendorGroupId { get; private set; }
        public VocabularyKey VendorInvoiceLineMatchingPolicy { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey IsMinorityOwned { get; private set; }
        public VocabularyKey MultilineDiscountVendorGroupCode { get; private set; }
        public VocabularyKey NameControl { get; private set; }
        public VocabularyKey Nationality { get; private set; }
        public VocabularyKey NumberSequenceGroupId { get; private set; }
        public VocabularyKey DefaultOffsetAccountType { get; private set; }
        public VocabularyKey DefaultOffsetLedgerAccount { get; private set; }
        public VocabularyKey IsOneTimeVendor { get; private set; }
        public VocabularyKey DIOTOperationType { get; private set; }
        public VocabularyKey NationalRegistryNumberId { get; private set; }
        public VocabularyKey Party { get; private set; }
        public VocabularyKey DefaultPaymentDayName { get; private set; }
        public VocabularyKey PaymentId { get; private set; }
        public VocabularyKey DefaultVendorPaymentMethodName { get; private set; }
        public VocabularyKey DefaultPaymentScheduleName { get; private set; }
        public VocabularyKey PaymentSpecificationId { get; private set; }
        public VocabularyKey PriceVendorGroupId { get; private set; }
        public VocabularyKey WillPurchaseOrderIncludePricesAndAmounts { get; private set; }
        public VocabularyKey PurchaseWorkCalendarId { get; private set; }
        public VocabularyKey DefaultPurchaseOrderPoolId { get; private set; }
        public VocabularyKey RFCFederalTaxNumber { get; private set; }
        public VocabularyKey IsFlaggedWithSecondTIN { get; private set; }
        public VocabularyKey BusinessSegmentCode { get; private set; }
        public VocabularyKey IsSmallBusiness { get; private set; }
        public VocabularyKey StateInscription { get; private set; }
        public VocabularyKey BusinessSubsegmentCode { get; private set; }
        public VocabularyKey DefaultSupplementaryProductVendorGroupId { get; private set; }
        public VocabularyKey PurchaseRebateVendorGroupId { get; private set; }
        public VocabularyKey Tax1099BoxIdRef { get; private set; }
        public VocabularyKey Tax1099NameToUse { get; private set; }
        public VocabularyKey Tax1099FederalTaxId { get; private set; }
        public VocabularyKey IsReportingTax1099 { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey Tax1099IdType { get; private set; }
        public VocabularyKey IsWithholdingTaxCalculated { get; private set; }
        public VocabularyKey DefaultCashDiscountUsage { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey VendorExceptionGroupIdRef { get; private set; }
        public VocabularyKey VendorGroupId { get; private set; }
        public VocabularyKey InvoiceDeclarationIdRef { get; private set; }
        public VocabularyKey ProductDescriptionVendorGroupId { get; private set; }
        public VocabularyKey DIOTVendorType { get; private set; }
        public VocabularyKey VendorPriceToleranceGroupId { get; private set; }
        public VocabularyKey IsServiceVeteranOwned { get; private set; }
        public VocabularyKey IsW9Received { get; private set; }
        public VocabularyKey IsW9CheckingEnabled { get; private set; }
        public VocabularyKey OurAccountNumber { get; private set; }
        public VocabularyKey NAFCode { get; private set; }
        public VocabularyKey VendorInvoiceDeclarationId { get; private set; }
        public VocabularyKey PaymentTransactionCode { get; private set; }
        public VocabularyKey MainContactPersonnelNumber { get; private set; }
        public VocabularyKey Tax1099BoxId { get; private set; }
        public VocabularyKey Tax1099Type { get; private set; }
        public VocabularyKey VendorExceptionGroupId { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DefaultOffsetLedgerAccountDisplayValue { get; private set; }
        public VocabularyKey AddressBooks { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountyId { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressStateId { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressBuildingCompliment { get; private set; }
        public VocabularyKey AddressStreetNumber { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressPostBox { get; private set; }
        public VocabularyKey AddressCityInKana { get; private set; }
        public VocabularyKey AddressStreetInKana { get; private set; }
        public VocabularyKey AddressBrazilianCNPJOrCPF { get; private set; }
        public VocabularyKey AddressBrazilianIE { get; private set; }
        public VocabularyKey FormattedPrimaryAddress { get; private set; }
        public VocabularyKey VendorKnownAsName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey VendorOrganizationName { get; private set; }
        public VocabularyKey VendorSearchName { get; private set; }
        public VocabularyKey OrganizationABCCode { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey OrganizationEmployeeAmount { get; private set; }
        public VocabularyKey OrganizationPhoneticName { get; private set; }
        public VocabularyKey VendorPartyNumber { get; private set; }
        public VocabularyKey VendorPartyType { get; private set; }
        public VocabularyKey PersonAnniversaryDay { get; private set; }
        public VocabularyKey PersonAnniversaryMonth { get; private set; }
        public VocabularyKey PersonAnniversaryYear { get; private set; }
        public VocabularyKey PersonBirthDay { get; private set; }
        public VocabularyKey PersonBirthMonth { get; private set; }
        public VocabularyKey PersonBirthYear { get; private set; }
        public VocabularyKey PersonChildrenNames { get; private set; }
        public VocabularyKey PersonGender { get; private set; }
        public VocabularyKey PersonHobbies { get; private set; }
        public VocabularyKey PersonFirstName { get; private set; }
        public VocabularyKey PersonMiddleName { get; private set; }
        public VocabularyKey PersonLastNamePrefix { get; private set; }
        public VocabularyKey PersonLastName { get; private set; }
        public VocabularyKey PersonInitials { get; private set; }
        public VocabularyKey PersonMaritalStatus { get; private set; }
        public VocabularyKey PersonPersonalSuffix { get; private set; }
        public VocabularyKey PersonPersonalTitle { get; private set; }
        public VocabularyKey PersonPhoneticFirstName { get; private set; }
        public VocabularyKey PersonPhoneticLastName { get; private set; }
        public VocabularyKey PersonPhoneticMiddleName { get; private set; }
        public VocabularyKey PersonProfessionalSuffix { get; private set; }
        public VocabularyKey PersonProfessionalTitle { get; private set; }
        public VocabularyKey PrimaryEmailAddress { get; private set; }
        public VocabularyKey PrimaryEmailAddressDescription { get; private set; }
        public VocabularyKey IsPrimaryEmailAddressIMEnabled { get; private set; }
        public VocabularyKey PrimaryEmailAddressPurpose { get; private set; }
        public VocabularyKey PrimaryFaxNumber { get; private set; }
        public VocabularyKey PrimaryFaxNumberDescription { get; private set; }
        public VocabularyKey PrimaryFaxNumberExtension { get; private set; }
        public VocabularyKey PrimaryFaxNumberPurpose { get; private set; }
        public VocabularyKey PrimaryPhoneNumber { get; private set; }
        public VocabularyKey PrimaryPhoneNumberDescription { get; private set; }
        public VocabularyKey IsPrimaryPhoneNumberMobile { get; private set; }
        public VocabularyKey PrimaryPhoneNumberPurpose { get; private set; }
        public VocabularyKey PrimaryTelex { get; private set; }
        public VocabularyKey PrimaryTelexDescription { get; private set; }
        public VocabularyKey PrimaryTelexPurpose { get; private set; }
        public VocabularyKey PrimaryURL { get; private set; }
        public VocabularyKey PrimaryURLDescription { get; private set; }
        public VocabularyKey PrimaryURLPurpose { get; private set; }
        public VocabularyKey PrimaryFacebook { get; private set; }
        public VocabularyKey PrimaryFacebookDescription { get; private set; }
        public VocabularyKey PrimaryFacebookPurpose { get; private set; }
        public VocabularyKey PrimaryLinkedIn { get; private set; }
        public VocabularyKey PrimaryLinkedInDescription { get; private set; }
        public VocabularyKey PrimaryLinkedInPurpose { get; private set; }
        public VocabularyKey PrimaryTwitter { get; private set; }
        public VocabularyKey PrimaryTwitterDescription { get; private set; }
        public VocabularyKey PrimaryTwitterPurpose { get; private set; }
        public VocabularyKey WillPurchaseOrderProcessingSummaryUpdatePurchaseOrder { get; private set; }
        public VocabularyKey WillProductReceiptProcessingSummaryUpdatePurchaseOrder { get; private set; }
        public VocabularyKey WillReceiptsListProcessingSummaryUpdatePurchaseOrder { get; private set; }
        public VocabularyKey WillInvoiceProcessingSummaryUpdatePurchaseOrder { get; private set; }
        public VocabularyKey IsCUSIPIdentificationNumberApplicable { get; private set; }
        public VocabularyKey CUSIPIdentificationNumber { get; private set; }
        public VocabularyKey CUSIPDetails { get; private set; }
        public VocabularyKey OIDInvestorType { get; private set; }
        public VocabularyKey OIDNomineeDetails { get; private set; }
        public VocabularyKey ISNationalRegistryNumber { get; private set; }
        public VocabularyKey WithholdingTaxVendorType { get; private set; }
        public VocabularyKey PurchaseOrderConsolidationDayOfMonth { get; private set; }
        public VocabularyKey PaymentFeeGroupId { get; private set; }
        public VocabularyKey IsVendorPayingBankPaymentFee { get; private set; }
        public VocabularyKey BrazilianCCM { get; private set; }
        public VocabularyKey BrazilianCNPJOrCPF { get; private set; }
        public VocabularyKey BrazilianCNAE { get; private set; }
        public VocabularyKey ForeignerId { get; private set; }
        public VocabularyKey BrazilianIE { get; private set; }
        public VocabularyKey BrazilianNIT { get; private set; }
        public VocabularyKey FiscalOperationPresenceType { get; private set; }
        public VocabularyKey IsServiceDeliveryAddressBased { get; private set; }
        public VocabularyKey IsPurchaseConsumed { get; private set; }
        public VocabularyKey BrazilianINSSCEI { get; private set; }
        public VocabularyKey IsIncomingFiscalDocumentGenerated { get; private set; }
        public VocabularyKey IsICMSContributor { get; private set; }
        public VocabularyKey CompositionScheme { get; private set; }
        public VocabularyKey ForeignVendor { get; private set; }
        public VocabularyKey GTAVendor { get; private set; }
        public VocabularyKey PreferentialVendor { get; private set; }
        public VocabularyKey SSIVendor { get; private set; }
        public VocabularyKey NatureOfAssessee { get; private set; }
        public VocabularyKey PANNumber { get; private set; }
        public VocabularyKey PANReferenceNumber { get; private set; }
        public VocabularyKey PANStatus { get; private set; }
        public VocabularyKey SSIValidityDate { get; private set; }
        public VocabularyKey TCSGroup { get; private set; }
        public VocabularyKey TDSGroup { get; private set; }
        public VocabularyKey VendorPortalCollaborationMethod { get; private set; }
        public VocabularyKey PrimaryPhoneNumberExtension { get; private set; }
        public VocabularyKey ZakatRegistrationNumber { get; private set; }
        public VocabularyKey ZakatFileNumber { get; private set; }
        public VocabularyKey IsSubcontractor { get; private set; }
        public VocabularyKey ZakatServiceType { get; private set; }
        public VocabularyKey ElectronicLocationId { get; private set; }
        public VocabularyKey VendorPaymentFineCode { get; private set; }
        public VocabularyKey VendorPaymentFinancialInterestCode { get; private set; }
        public VocabularyKey BirthPlace { get; private set; }
        public VocabularyKey BirthCountyCode { get; private set; }
        public VocabularyKey ResidenceForeignCountryRegionId { get; private set; }
        public VocabularyKey FiscalDocumentIncomeCode { get; private set; }
        public VocabularyKey DUNSNumber { get; private set; }
        public VocabularyKey IsGSTCompositionSchemeEnabled { get; private set; }
        public VocabularyKey BankTransactionType { get; private set; }
        public VocabularyKey BankOrderOfPayment { get; private set; }
        public VocabularyKey ForeignResident { get; private set; }
        public VocabularyKey InventoryProfile { get; private set; }
        public VocabularyKey InventoryProfileType { get; private set; }
        public VocabularyKey SeparateDivisionId { get; private set; }
        public VocabularyKey StructureDepartment { get; private set; }
        public VocabularyKey TaxOperationCode { get; private set; }
        public VocabularyKey TaxPartnerKind { get; private set; }
        public VocabularyKey TaxAgent { get; private set; }
        public VocabularyKey PrimaryContactFaxRecordId { get; private set; }
        public VocabularyKey PrimaryContactPhoneRecordId { get; private set; }
        public VocabularyKey PrimaryContactEmailRecordId { get; private set; }
        public VocabularyKey PrimaryContactURLRecordId { get; private set; }
        public VocabularyKey AddressRecordId { get; private set; }


    }
}