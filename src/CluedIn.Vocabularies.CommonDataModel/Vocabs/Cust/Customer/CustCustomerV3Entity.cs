using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerV3EntityVocabulary : SimpleVocabulary
    {
        public CustCustomerV3EntityVocabulary()
        {
            VocabularyName = "Common Data Model CustCustomerV3Entity";
            KeyPrefix = "commonDataModel.custcustomerv3entity";
            KeySeparator = ".";
            Grouping = "/CustCustomerV3Entity";

            AddGroup("Common Data Model CustCustomerV3Entity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameAlias = group.Add(new VocabularyKey(nameof(NameAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KnownAs = group.Add(new VocabularyKey(nameof(KnownAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumberOfEmployees = group.Add(new VocabularyKey(nameof(OrganizationNumberOfEmployees), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationABCCode = group.Add(new VocabularyKey(nameof(OrganizationABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationPhoneticName = group.Add(new VocabularyKey(nameof(OrganizationPhoneticName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonInitials = group.Add(new VocabularyKey(nameof(PersonInitials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonFirstName = group.Add(new VocabularyKey(nameof(PersonFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonMiddleName = group.Add(new VocabularyKey(nameof(PersonMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonLastNamePrefix = group.Add(new VocabularyKey(nameof(PersonLastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonLastName = group.Add(new VocabularyKey(nameof(PersonLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonProfessionalTitle = group.Add(new VocabularyKey(nameof(PersonProfessionalTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonProfessionalSuffix = group.Add(new VocabularyKey(nameof(PersonProfessionalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticFirstName = group.Add(new VocabularyKey(nameof(PersonPhoneticFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticLastName = group.Add(new VocabularyKey(nameof(PersonPhoneticLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonPhoneticMiddleName = group.Add(new VocabularyKey(nameof(PersonPhoneticMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonGender = group.Add(new VocabularyKey(nameof(PersonGender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonMaritalStatus = group.Add(new VocabularyKey(nameof(PersonMaritalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryDay = group.Add(new VocabularyKey(nameof(PersonAnniversaryDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryMonth = group.Add(new VocabularyKey(nameof(PersonAnniversaryMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonAnniversaryYear = group.Add(new VocabularyKey(nameof(PersonAnniversaryYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonChildrenNames = group.Add(new VocabularyKey(nameof(PersonChildrenNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonHobbies = group.Add(new VocabularyKey(nameof(PersonHobbies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBooks = group.Add(new VocabularyKey(nameof(AddressBooks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPrimaryAddress = group.Add(new VocabularyKey(nameof(FullPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBuildingComplement = group.Add(new VocabularyKey(nameof(AddressBuildingComplement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBrazilianCNPJOrCPF = group.Add(new VocabularyKey(nameof(AddressBrazilianCNPJOrCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBrazilianIE = group.Add(new VocabularyKey(nameof(AddressBrazilianIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmail = group.Add(new VocabularyKey(nameof(PrimaryContactEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailDescription = group.Add(new VocabularyKey(nameof(PrimaryContactEmailDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailIsIM = group.Add(new VocabularyKey(nameof(PrimaryContactEmailIsIM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactEmailPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFax = group.Add(new VocabularyKey(nameof(PrimaryContactFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxDescription = group.Add(new VocabularyKey(nameof(PrimaryContactFaxDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxExtension = group.Add(new VocabularyKey(nameof(PrimaryContactFaxExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactFaxPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhone = group.Add(new VocabularyKey(nameof(PrimaryContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneDescription = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneExtension = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneIsMobile = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneIsMobile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhonePurpose = group.Add(new VocabularyKey(nameof(PrimaryContactPhonePurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelex = group.Add(new VocabularyKey(nameof(PrimaryContactTelex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexDescription = group.Add(new VocabularyKey(nameof(PrimaryContactTelexDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTelexPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactTelexPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURL = group.Add(new VocabularyKey(nameof(PrimaryContactURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLDescription = group.Add(new VocabularyKey(nameof(PrimaryContactURLDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactURLPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebook = group.Add(new VocabularyKey(nameof(PrimaryContactFacebook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookDescription = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFacebookPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactFacebookPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedIn = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInDescription = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactLinkedInPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactLinkedInPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterDescription = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitter = group.Add(new VocabularyKey(nameof(PrimaryContactTwitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactTwitterPurpose = group.Add(new VocabularyKey(nameof(PrimaryContactTwitterPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOneTimeCustomer = group.Add(new VocabularyKey(nameof(IsOneTimeCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticsGroupId = group.Add(new VocabularyKey(nameof(StatisticsGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStatement = group.Add(new VocabularyKey(nameof(AccountStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationNumber = group.Add(new VocabularyKey(nameof(IdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyCountry = group.Add(new VocabularyKey(nameof(PartyCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyState = group.Add(new VocabularyKey(nameof(PartyState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FederalIndicator = group.Add(new VocabularyKey(nameof(FederalIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FederalAgencyLocationCode = group.Add(new VocabularyKey(nameof(FederalAgencyLocationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FederalComments = group.Add(new VocabularyKey(nameof(FederalComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IRS1099CIndicator = group.Add(new VocabularyKey(nameof(IRS1099CIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineOfBusinessId = group.Add(new VocabularyKey(nameof(LineOfBusinessId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeResponsibleNumber = group.Add(new VocabularyKey(nameof(EmployeeResponsibleNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainContactWorker = group.Add(new VocabularyKey(nameof(MainContactWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesSegmentId = group.Add(new VocabularyKey(nameof(SalesSegmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesSubsegmentId = group.Add(new VocabularyKey(nameof(SalesSubsegmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDistrict = group.Add(new VocabularyKey(nameof(SalesDistrict), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyChain = group.Add(new VocabularyKey(nameof(CompanyChain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCurrencyCode = group.Add(new VocabularyKey(nameof(SalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesMemo = group.Add(new VocabularyKey(nameof(SalesMemo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHoldStatus = group.Add(new VocabularyKey(nameof(OnHoldStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimitIsMandatory = group.Add(new VocabularyKey(nameof(CreditLimitIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditRating = group.Add(new VocabularyKey(nameof(CreditRating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionsContactPersonId = group.Add(new VocabularyKey(nameof(CollectionsContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExcludedFromInterestChargeCalculation = group.Add(new VocabularyKey(nameof(IsExcludedFromInterestChargeCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExcludedFromCollectionFeeCalculation = group.Add(new VocabularyKey(nameof(IsExcludedFromCollectionFeeCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargesGroupId = group.Add(new VocabularyKey(nameof(ChargesGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCustomerGroupId = group.Add(new VocabularyKey(nameof(ItemCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionCustomerGroupId = group.Add(new VocabularyKey(nameof(CommissionCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommissionSalesGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderPoolId = group.Add(new VocabularyKey(nameof(SalesOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAccountNumber = group.Add(new VocabularyKey(nameof(SalesAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderEntryDeadline = group.Add(new VocabularyKey(nameof(OrderEntryDeadline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultiLineDiscountCode = group.Add(new VocabularyKey(nameof(MultiLineDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountCode = group.Add(new VocabularyKey(nameof(TotalDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPriceGroupId = group.Add(new VocabularyKey(nameof(DiscountPriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountCode = group.Add(new VocabularyKey(nameof(LineDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRebateGroupId = group.Add(new VocabularyKey(nameof(CustomerRebateGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTMAGroupId = group.Add(new VocabularyKey(nameof(CustomerTMAGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SupplementaryItemGroupId = group.Add(new VocabularyKey(nameof(SupplementaryItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTerms = group.Add(new VocabularyKey(nameof(PaymentTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSpecification = group.Add(new VocabularyKey(nameof(PaymentSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSchedule = group.Add(new VocabularyKey(nameof(PaymentSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDay = group.Add(new VocabularyKey(nameof(PaymentDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentCashDiscount = group.Add(new VocabularyKey(nameof(PaymentCashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsBaseDays = group.Add(new VocabularyKey(nameof(PaymentTermsBaseDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentBankAccount = group.Add(new VocabularyKey(nameof(PaymentBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentFactoringAccount = group.Add(new VocabularyKey(nameof(PaymentFactoringAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentIdType = group.Add(new VocabularyKey(nameof(PaymentIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentUseCashDiscount = group.Add(new VocabularyKey(nameof(PaymentUseCashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeNotes = group.Add(new VocabularyKey(nameof(CentralBankPurposeNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCardAddressVerification = group.Add(new VocabularyKey(nameof(CreditCardAddressVerification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCardAddressVerificationIsAuthorizationVoidedOnFailure = group.Add(new VocabularyKey(nameof(CreditCardAddressVerificationIsAuthorizationVoidedOnFailure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCardAddressVerificationLevel = group.Add(new VocabularyKey(nameof(CreditCardAddressVerificationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCardCVC = group.Add(new VocabularyKey(nameof(CreditCardCVC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseIsASNGenerated = group.Add(new VocabularyKey(nameof(WarehouseIsASNGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseIsEntireShipmentFilled = group.Add(new VocabularyKey(nameof(WarehouseIsEntireShipmentFilled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryStatusId = group.Add(new VocabularyKey(nameof(DefaultInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddress = group.Add(new VocabularyKey(nameof(InvoiceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroType = group.Add(new VocabularyKey(nameof(GiroType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroTypeFreeTextInvoice = group.Add(new VocabularyKey(nameof(GiroTypeFreeTextInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroTypeInterestNote = group.Add(new VocabularyKey(nameof(GiroTypeInterestNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroTypeCollectionletter = group.Add(new VocabularyKey(nameof(GiroTypeCollectionletter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroTypeProjInvoice = group.Add(new VocabularyKey(nameof(GiroTypeProjInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroTypeAccountStatement = group.Add(new VocabularyKey(nameof(GiroTypeAccountStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryFreightZone = group.Add(new VocabularyKey(nameof(DeliveryFreightZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTerms = group.Add(new VocabularyKey(nameof(DeliveryTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryMode = group.Add(new VocabularyKey(nameof(DeliveryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryReason = group.Add(new VocabularyKey(nameof(DeliveryReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCode = group.Add(new VocabularyKey(nameof(DestinationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptCalendar = group.Add(new VocabularyKey(nameof(ReceiptCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFuelSurchargeApplied = group.Add(new VocabularyKey(nameof(IsFuelSurchargeApplied), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesTaxIncludedInPrices = group.Add(new VocabularyKey(nameof(IsSalesTaxIncludedInPrices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingDutyLicense = group.Add(new VocabularyKey(nameof(PackingDutyLicense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCode = group.Add(new VocabularyKey(nameof(FiscalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingMaterialFeeLicenseNumber = group.Add(new VocabularyKey(nameof(PackingMaterialFeeLicenseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsElectronicInvoice = group.Add(new VocabularyKey(nameof(IsElectronicInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicInvoiceEAN = group.Add(new VocabularyKey(nameof(ElectronicInvoiceEAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFreightAccrued = group.Add(new VocabularyKey(nameof(IsFreightAccrued), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExpressBillOfLadingAccepted = group.Add(new VocabularyKey(nameof(IsExpressBillOfLadingAccepted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransactionPostedAsShipment = group.Add(new VocabularyKey(nameof(IsTransactionPostedAsShipment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOrderNumberReferenceUsed = group.Add(new VocabularyKey(nameof(IsOrderNumberReferenceUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesReturnTaxGroup = group.Add(new VocabularyKey(nameof(SalesReturnTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptEmail = group.Add(new VocabularyKey(nameof(ReceiptEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptOption = group.Add(new VocabularyKey(nameof(ReceiptOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWithholdingTaxCalculated = group.Add(new VocabularyKey(nameof(IsWithholdingTaxCalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(WithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FrenchSiret = group.Add(new VocabularyKey(nameof(FrenchSiret), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NAFCode = group.Add(new VocabularyKey(nameof(NAFCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyType = group.Add(new VocabularyKey(nameof(CompanyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CURPNumber = group.Add(new VocabularyKey(nameof(CURPNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFCNumber = group.Add(new VocabularyKey(nameof(RFCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateInscription = group.Add(new VocabularyKey(nameof(StateInscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationId = group.Add(new VocabularyKey(nameof(TaxRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationDay = group.Add(new VocabularyKey(nameof(ConsolidationDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NationalRegistryNumber = group.Add(new VocabularyKey(nameof(NationalRegistryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReliefGroupId = group.Add(new VocabularyKey(nameof(ReliefGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateWithholdingTax = group.Add(new VocabularyKey(nameof(CalculateWithholdingTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignCustomer = group.Add(new VocabularyKey(nameof(ForeignCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSGroup = group.Add(new VocabularyKey(nameof(TCSGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSGroup = group.Add(new VocabularyKey(nameof(TDSGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferentialCustomer = group.Add(new VocabularyKey(nameof(PreferentialCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NatureOfAssessee = group.Add(new VocabularyKey(nameof(NatureOfAssessee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PANNumber = group.Add(new VocabularyKey(nameof(PANNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PANReferenceNumber = group.Add(new VocabularyKey(nameof(PANReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PanStatus = group.Add(new VocabularyKey(nameof(PanStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicLocationId = group.Add(new VocabularyKey(nameof(ElectronicLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFineCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFinancialInterestCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFinancialInterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianCCM = group.Add(new VocabularyKey(nameof(BrazilianCCM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianCNAE = group.Add(new VocabularyKey(nameof(BrazilianCNAE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianCNPJOrCPF = group.Add(new VocabularyKey(nameof(BrazilianCNPJOrCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinalUser = group.Add(new VocabularyKey(nameof(IsFinalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerWithholdingContributionType = group.Add(new VocabularyKey(nameof(CustomerWithholdingContributionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIncomingFiscalDocumentGenerated = group.Add(new VocabularyKey(nameof(IsIncomingFiscalDocumentGenerated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsICMSContributor = group.Add(new VocabularyKey(nameof(IsICMSContributor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianIE = group.Add(new VocabularyKey(nameof(BrazilianIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianINSSCEI = group.Add(new VocabularyKey(nameof(BrazilianINSSCEI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilianNIT = group.Add(new VocabularyKey(nameof(BrazilianNIT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceDeliveryAddressBased = group.Add(new VocabularyKey(nameof(IsServiceDeliveryAddressBased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInSuframaRegion = group.Add(new VocabularyKey(nameof(IsInSuframaRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuframaNumber = group.Add(new VocabularyKey(nameof(SuframaNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasSuframaDiscountPISandCOFINS = group.Add(new VocabularyKey(nameof(HasSuframaDiscountPISandCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignerId = group.Add(new VocabularyKey(nameof(ForeignerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionPresenceType = group.Add(new VocabularyKey(nameof(TransactionPresenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffCompany = group.Add(new VocabularyKey(nameof(WriteOffCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteoffReason = group.Add(new VocabularyKey(nameof(WriteoffReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportSale = group.Add(new VocabularyKey(nameof(ExportSale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthCountyCode = group.Add(new VocabularyKey(nameof(BirthCountyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BirthPlace = group.Add(new VocabularyKey(nameof(BirthPlace), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResidenceForeignCountryRegionId = group.Add(new VocabularyKey(nameof(ResidenceForeignCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchRequestUsed = group.Add(new VocabularyKey(nameof(IsPurchRequestUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCounty = group.Add(new VocabularyKey(nameof(DeliveryAddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressState = group.Add(new VocabularyKey(nameof(DeliveryAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressBuildingComplement = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingComplement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidFrom = group.Add(new VocabularyKey(nameof(DeliveryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressValidTo = group.Add(new VocabularyKey(nameof(DeliveryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressDescription = group.Add(new VocabularyKey(nameof(InvoiceAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressZipCode = group.Add(new VocabularyKey(nameof(InvoiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressTimeZone = group.Add(new VocabularyKey(nameof(InvoiceAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCity = group.Add(new VocabularyKey(nameof(InvoiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCounty = group.Add(new VocabularyKey(nameof(InvoiceAddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressDistrictName = group.Add(new VocabularyKey(nameof(InvoiceAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLatitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLongitude = group.Add(new VocabularyKey(nameof(InvoiceAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressLocationId = group.Add(new VocabularyKey(nameof(InvoiceAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressState = group.Add(new VocabularyKey(nameof(InvoiceAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreet = group.Add(new VocabularyKey(nameof(InvoiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressBuildingComplement = group.Add(new VocabularyKey(nameof(InvoiceAddressBuildingComplement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressValidFrom = group.Add(new VocabularyKey(nameof(InvoiceAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressValidTo = group.Add(new VocabularyKey(nameof(InvoiceAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExternallyMaintained = group.Add(new VocabularyKey(nameof(IsExternallyMaintained), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MerchantID = group.Add(new VocabularyKey(nameof(MerchantID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultECommerceOperator = group.Add(new VocabularyKey(nameof(DefaultECommerceOperator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerType = group.Add(new VocabularyKey(nameof(CustomerType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentPolicyName = group.Add(new VocabularyKey(nameof(FulfillmentPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentPolicy = group.Add(new VocabularyKey(nameof(FulfillmentPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressPostbox = group.Add(new VocabularyKey(nameof(AddressPostbox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustClassificationId = group.Add(new VocabularyKey(nameof(CustClassificationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowCreateIndirectOrderLines = group.Add(new VocabularyKey(nameof(IsAllowCreateIndirectOrderLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactEmailRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactEmailRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactFaxRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactFaxRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactPhoneRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactPhoneRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactURLRecordId = group.Add(new VocabularyKey(nameof(PrimaryContactURLRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressRecordId = group.Add(new VocabularyKey(nameof(AddressRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionLetterCode = group.Add(new VocabularyKey(nameof(CollectionLetterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceRegister = group.Add(new VocabularyKey(nameof(EInvoiceRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorityOffice = group.Add(new VocabularyKey(nameof(AuthorityOffice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceAttachment = group.Add(new VocabularyKey(nameof(EInvoiceAttachment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressRecordId = group.Add(new VocabularyKey(nameof(DeliveryAddressRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressRecordId = group.Add(new VocabularyKey(nameof(InvoiceAddressRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirPartyLocationRecordId = group.Add(new VocabularyKey(nameof(DirPartyLocationRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyRecordId = group.Add(new VocabularyKey(nameof(PartyRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicePostingType = group.Add(new VocabularyKey(nameof(InvoicePostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignResident = group.Add(new VocabularyKey(nameof(ForeignResident), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterCompanyAutoCreateOrders = group.Add(new VocabularyKey(nameof(InterCompanyAutoCreateOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManAccountStatusId = group.Add(new VocabularyKey(nameof(CredManAccountStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManBusinessStarted = group.Add(new VocabularyKey(nameof(CredManBusinessStarted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManCollectionGroupId = group.Add(new VocabularyKey(nameof(CredManCollectionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManCreditLimitDate = group.Add(new VocabularyKey(nameof(CredManCreditLimitDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManCreditLimitExpiryDate = group.Add(new VocabularyKey(nameof(CredManCreditLimitExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManCustCreditMaxAlt = group.Add(new VocabularyKey(nameof(CredManCustCreditMaxAlt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManCustomerSince = group.Add(new VocabularyKey(nameof(CredManCustomerSince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManEligibleCreditLimitCurrency = group.Add(new VocabularyKey(nameof(CredManEligibleCreditLimitCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManEligibleCreditLimitDate = group.Add(new VocabularyKey(nameof(CredManEligibleCreditLimitDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManEligibleCreditMax = group.Add(new VocabularyKey(nameof(CredManEligibleCreditMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManExclude = group.Add(new VocabularyKey(nameof(CredManExclude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManGroupId = group.Add(new VocabularyKey(nameof(CredManGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManNotes = group.Add(new VocabularyKey(nameof(CredManNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManStatusReasonId = group.Add(new VocabularyKey(nameof(CredManStatusReasonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManTitleHeld = group.Add(new VocabularyKey(nameof(CredManTitleHeld), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManWithAgency = group.Add(new VocabularyKey(nameof(CredManWithAgency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManLastReviewDate = group.Add(new VocabularyKey(nameof(CredManLastReviewDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManNextSchedReviewDate = group.Add(new VocabularyKey(nameof(CredManNextSchedReviewDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManCustUnlimitedCredit = group.Add(new VocabularyKey(nameof(CredManCustUnlimitedCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey OrganizationName { get; private set; }
        public VocabularyKey NameAlias { get; private set; }
        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey CustomerGroupId { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey OrganizationNumberOfEmployees { get; private set; }
        public VocabularyKey OrganizationABCCode { get; private set; }
        public VocabularyKey OrganizationPhoneticName { get; private set; }
        public VocabularyKey PersonInitials { get; private set; }
        public VocabularyKey PersonFirstName { get; private set; }
        public VocabularyKey PersonMiddleName { get; private set; }
        public VocabularyKey PersonLastNamePrefix { get; private set; }
        public VocabularyKey PersonLastName { get; private set; }
        public VocabularyKey PersonProfessionalTitle { get; private set; }
        public VocabularyKey PersonProfessionalSuffix { get; private set; }
        public VocabularyKey PersonPhoneticFirstName { get; private set; }
        public VocabularyKey PersonPhoneticLastName { get; private set; }
        public VocabularyKey PersonPhoneticMiddleName { get; private set; }
        public VocabularyKey PersonGender { get; private set; }
        public VocabularyKey PersonMaritalStatus { get; private set; }
        public VocabularyKey PersonAnniversaryDay { get; private set; }
        public VocabularyKey PersonAnniversaryMonth { get; private set; }
        public VocabularyKey PersonAnniversaryYear { get; private set; }
        public VocabularyKey PersonChildrenNames { get; private set; }
        public VocabularyKey PersonHobbies { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey AddressBooks { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey FullPrimaryAddress { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressStreetNumber { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey AddressBuildingComplement { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressBrazilianCNPJOrCPF { get; private set; }
        public VocabularyKey AddressBrazilianIE { get; private set; }
        public VocabularyKey PrimaryContactEmail { get; private set; }
        public VocabularyKey PrimaryContactEmailDescription { get; private set; }
        public VocabularyKey PrimaryContactEmailIsIM { get; private set; }
        public VocabularyKey PrimaryContactEmailPurpose { get; private set; }
        public VocabularyKey PrimaryContactFax { get; private set; }
        public VocabularyKey PrimaryContactFaxDescription { get; private set; }
        public VocabularyKey PrimaryContactFaxExtension { get; private set; }
        public VocabularyKey PrimaryContactFaxPurpose { get; private set; }
        public VocabularyKey PrimaryContactPhone { get; private set; }
        public VocabularyKey PrimaryContactPhoneDescription { get; private set; }
        public VocabularyKey PrimaryContactPhoneExtension { get; private set; }
        public VocabularyKey PrimaryContactPhoneIsMobile { get; private set; }
        public VocabularyKey PrimaryContactPhonePurpose { get; private set; }
        public VocabularyKey PrimaryContactTelex { get; private set; }
        public VocabularyKey PrimaryContactTelexDescription { get; private set; }
        public VocabularyKey PrimaryContactTelexPurpose { get; private set; }
        public VocabularyKey PrimaryContactURL { get; private set; }
        public VocabularyKey PrimaryContactURLDescription { get; private set; }
        public VocabularyKey PrimaryContactURLPurpose { get; private set; }
        public VocabularyKey PrimaryContactFacebook { get; private set; }
        public VocabularyKey PrimaryContactFacebookDescription { get; private set; }
        public VocabularyKey PrimaryContactFacebookPurpose { get; private set; }
        public VocabularyKey PrimaryContactLinkedIn { get; private set; }
        public VocabularyKey PrimaryContactLinkedInDescription { get; private set; }
        public VocabularyKey PrimaryContactLinkedInPurpose { get; private set; }
        public VocabularyKey PrimaryContactTwitterDescription { get; private set; }
        public VocabularyKey PrimaryContactTwitter { get; private set; }
        public VocabularyKey PrimaryContactTwitterPurpose { get; private set; }
        public VocabularyKey IsOneTimeCustomer { get; private set; }
        public VocabularyKey StatisticsGroupId { get; private set; }
        public VocabularyKey AccountStatement { get; private set; }
        public VocabularyKey IdentificationNumber { get; private set; }
        public VocabularyKey PartyCountry { get; private set; }
        public VocabularyKey PartyState { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey FederalIndicator { get; private set; }
        public VocabularyKey FederalAgencyLocationCode { get; private set; }
        public VocabularyKey FederalComments { get; private set; }
        public VocabularyKey IRS1099CIndicator { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey LineOfBusinessId { get; private set; }
        public VocabularyKey EmployeeResponsibleNumber { get; private set; }
        public VocabularyKey MainContactWorker { get; private set; }
        public VocabularyKey SalesSegmentId { get; private set; }
        public VocabularyKey SalesSubsegmentId { get; private set; }
        public VocabularyKey SalesDistrict { get; private set; }
        public VocabularyKey CompanyChain { get; private set; }
        public VocabularyKey SalesCurrencyCode { get; private set; }
        public VocabularyKey SalesMemo { get; private set; }
        public VocabularyKey OnHoldStatus { get; private set; }
        public VocabularyKey CreditLimitIsMandatory { get; private set; }
        public VocabularyKey CreditRating { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey CollectionsContactPersonId { get; private set; }
        public VocabularyKey IsExcludedFromInterestChargeCalculation { get; private set; }
        public VocabularyKey IsExcludedFromCollectionFeeCalculation { get; private set; }
        public VocabularyKey ChargesGroupId { get; private set; }
        public VocabularyKey SiteId { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey ItemCustomerGroupId { get; private set; }
        public VocabularyKey CommissionCustomerGroupId { get; private set; }
        public VocabularyKey CommissionSalesGroupId { get; private set; }
        public VocabularyKey SalesOrderPoolId { get; private set; }
        public VocabularyKey SalesAccountNumber { get; private set; }
        public VocabularyKey OrderEntryDeadline { get; private set; }
        public VocabularyKey MultiLineDiscountCode { get; private set; }
        public VocabularyKey TotalDiscountCode { get; private set; }
        public VocabularyKey DiscountPriceGroupId { get; private set; }
        public VocabularyKey LineDiscountCode { get; private set; }
        public VocabularyKey CustomerRebateGroupId { get; private set; }
        public VocabularyKey CustomerTMAGroupId { get; private set; }
        public VocabularyKey SupplementaryItemGroupId { get; private set; }
        public VocabularyKey PaymentTerms { get; private set; }
        public VocabularyKey PaymentMethod { get; private set; }
        public VocabularyKey PaymentSpecification { get; private set; }
        public VocabularyKey PaymentSchedule { get; private set; }
        public VocabularyKey PaymentDay { get; private set; }
        public VocabularyKey PaymentCashDiscount { get; private set; }
        public VocabularyKey PaymentTermsBaseDays { get; private set; }
        public VocabularyKey PaymentBankAccount { get; private set; }
        public VocabularyKey PaymentFactoringAccount { get; private set; }
        public VocabularyKey PaymentIdType { get; private set; }
        public VocabularyKey PaymentUseCashDiscount { get; private set; }
        public VocabularyKey CentralBankPurposeCode { get; private set; }
        public VocabularyKey CentralBankPurposeNotes { get; private set; }
        public VocabularyKey CreditCardAddressVerification { get; private set; }
        public VocabularyKey CreditCardAddressVerificationIsAuthorizationVoidedOnFailure { get; private set; }
        public VocabularyKey CreditCardAddressVerificationLevel { get; private set; }
        public VocabularyKey CreditCardCVC { get; private set; }
        public VocabularyKey WarehouseIsASNGenerated { get; private set; }
        public VocabularyKey WarehouseIsEntireShipmentFilled { get; private set; }
        public VocabularyKey DefaultInventoryStatusId { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey InvoiceAddress { get; private set; }
        public VocabularyKey NumberSequenceGroup { get; private set; }
        public VocabularyKey GiroType { get; private set; }
        public VocabularyKey GiroTypeFreeTextInvoice { get; private set; }
        public VocabularyKey GiroTypeInterestNote { get; private set; }
        public VocabularyKey GiroTypeCollectionletter { get; private set; }
        public VocabularyKey GiroTypeProjInvoice { get; private set; }
        public VocabularyKey GiroTypeAccountStatement { get; private set; }
        public VocabularyKey DeliveryFreightZone { get; private set; }
        public VocabularyKey DeliveryTerms { get; private set; }
        public VocabularyKey DeliveryMode { get; private set; }
        public VocabularyKey DeliveryReason { get; private set; }
        public VocabularyKey DestinationCode { get; private set; }
        public VocabularyKey ReceiptCalendar { get; private set; }
        public VocabularyKey IsFuelSurchargeApplied { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey IsSalesTaxIncludedInPrices { get; private set; }
        public VocabularyKey PackingDutyLicense { get; private set; }
        public VocabularyKey FiscalCode { get; private set; }
        public VocabularyKey PackingMaterialFeeLicenseNumber { get; private set; }
        public VocabularyKey IsElectronicInvoice { get; private set; }
        public VocabularyKey ElectronicInvoiceEAN { get; private set; }
        public VocabularyKey IsFreightAccrued { get; private set; }
        public VocabularyKey IsExpressBillOfLadingAccepted { get; private set; }
        public VocabularyKey IsTransactionPostedAsShipment { get; private set; }
        public VocabularyKey IsOrderNumberReferenceUsed { get; private set; }
        public VocabularyKey SalesReturnTaxGroup { get; private set; }
        public VocabularyKey ReceiptEmail { get; private set; }
        public VocabularyKey ReceiptOption { get; private set; }
        public VocabularyKey IsWithholdingTaxCalculated { get; private set; }
        public VocabularyKey WithholdingTaxGroupCode { get; private set; }
        public VocabularyKey FrenchSiret { get; private set; }
        public VocabularyKey NAFCode { get; private set; }
        public VocabularyKey CompanyType { get; private set; }
        public VocabularyKey CURPNumber { get; private set; }
        public VocabularyKey RFCNumber { get; private set; }
        public VocabularyKey StateInscription { get; private set; }
        public VocabularyKey TaxRegistrationId { get; private set; }
        public VocabularyKey ConsolidationDay { get; private set; }
        public VocabularyKey NationalRegistryNumber { get; private set; }
        public VocabularyKey ReliefGroupId { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey CalculateWithholdingTax { get; private set; }
        public VocabularyKey ForeignCustomer { get; private set; }
        public VocabularyKey TCSGroup { get; private set; }
        public VocabularyKey TDSGroup { get; private set; }
        public VocabularyKey PreferentialCustomer { get; private set; }
        public VocabularyKey NatureOfAssessee { get; private set; }
        public VocabularyKey PANNumber { get; private set; }
        public VocabularyKey PANReferenceNumber { get; private set; }
        public VocabularyKey PanStatus { get; private set; }
        public VocabularyKey ElectronicLocationId { get; private set; }
        public VocabularyKey CustomerPaymentFineCode { get; private set; }
        public VocabularyKey CustomerPaymentFinancialInterestCode { get; private set; }
        public VocabularyKey BrazilianCCM { get; private set; }
        public VocabularyKey BrazilianCNAE { get; private set; }
        public VocabularyKey BrazilianCNPJOrCPF { get; private set; }
        public VocabularyKey IsFinalUser { get; private set; }
        public VocabularyKey CustomerWithholdingContributionType { get; private set; }
        public VocabularyKey IsIncomingFiscalDocumentGenerated { get; private set; }
        public VocabularyKey IsICMSContributor { get; private set; }
        public VocabularyKey BrazilianIE { get; private set; }
        public VocabularyKey BrazilianINSSCEI { get; private set; }
        public VocabularyKey BrazilianNIT { get; private set; }
        public VocabularyKey IsServiceDeliveryAddressBased { get; private set; }
        public VocabularyKey IsInSuframaRegion { get; private set; }
        public VocabularyKey SuframaNumber { get; private set; }
        public VocabularyKey HasSuframaDiscountPISandCOFINS { get; private set; }
        public VocabularyKey ForeignerId { get; private set; }
        public VocabularyKey TransactionPresenceType { get; private set; }
        public VocabularyKey WriteOffCompany { get; private set; }
        public VocabularyKey WriteoffReason { get; private set; }
        public VocabularyKey ExportSale { get; private set; }
        public VocabularyKey BirthCountyCode { get; private set; }
        public VocabularyKey BirthPlace { get; private set; }
        public VocabularyKey ResidenceForeignCountryRegionId { get; private set; }
        public VocabularyKey IsPurchRequestUsed { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey DeliveryAddressTimeZone { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressCounty { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressLatitude { get; private set; }
        public VocabularyKey DeliveryAddressLongitude { get; private set; }
        public VocabularyKey DeliveryAddressLocationId { get; private set; }
        public VocabularyKey DeliveryAddressState { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressBuildingComplement { get; private set; }
        public VocabularyKey DeliveryAddressValidFrom { get; private set; }
        public VocabularyKey DeliveryAddressValidTo { get; private set; }
        public VocabularyKey InvoiceAddressDescription { get; private set; }
        public VocabularyKey InvoiceAddressZipCode { get; private set; }
        public VocabularyKey InvoiceAddressTimeZone { get; private set; }
        public VocabularyKey InvoiceAddressCity { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey InvoiceAddressCounty { get; private set; }
        public VocabularyKey InvoiceAddressDistrictName { get; private set; }
        public VocabularyKey InvoiceAddressLatitude { get; private set; }
        public VocabularyKey InvoiceAddressLongitude { get; private set; }
        public VocabularyKey InvoiceAddressLocationId { get; private set; }
        public VocabularyKey InvoiceAddressState { get; private set; }
        public VocabularyKey InvoiceAddressStreet { get; private set; }
        public VocabularyKey InvoiceAddressStreetNumber { get; private set; }
        public VocabularyKey InvoiceAddressBuildingComplement { get; private set; }
        public VocabularyKey InvoiceAddressValidFrom { get; private set; }
        public VocabularyKey InvoiceAddressValidTo { get; private set; }
        public VocabularyKey IsExternallyMaintained { get; private set; }
        public VocabularyKey MerchantID { get; private set; }
        public VocabularyKey DefaultECommerceOperator { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey FulfillmentPolicyName { get; private set; }
        public VocabularyKey FulfillmentPolicy { get; private set; }
        public VocabularyKey AddressPostbox { get; private set; }
        public VocabularyKey CustClassificationId { get; private set; }
        public VocabularyKey IsAllowCreateIndirectOrderLines { get; private set; }
        public VocabularyKey PrimaryContactEmailRecordId { get; private set; }
        public VocabularyKey PrimaryContactFaxRecordId { get; private set; }
        public VocabularyKey PrimaryContactPhoneRecordId { get; private set; }
        public VocabularyKey PrimaryContactURLRecordId { get; private set; }
        public VocabularyKey AddressRecordId { get; private set; }
        public VocabularyKey CollectionLetterCode { get; private set; }
        public VocabularyKey EInvoiceRegister { get; private set; }
        public VocabularyKey AuthorityOffice { get; private set; }
        public VocabularyKey EInvoiceAttachment { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey DeliveryAddressRecordId { get; private set; }
        public VocabularyKey InvoiceAddressRecordId { get; private set; }
        public VocabularyKey DirPartyLocationRecordId { get; private set; }
        public VocabularyKey PartyRecordId { get; private set; }
        public VocabularyKey InvoicePostingType { get; private set; }
        public VocabularyKey ForeignResident { get; private set; }
        public VocabularyKey InterCompanyAutoCreateOrders { get; private set; }
        public VocabularyKey CredManAccountStatusId { get; private set; }
        public VocabularyKey CredManBusinessStarted { get; private set; }
        public VocabularyKey CredManCollectionGroupId { get; private set; }
        public VocabularyKey CredManCreditLimitDate { get; private set; }
        public VocabularyKey CredManCreditLimitExpiryDate { get; private set; }
        public VocabularyKey CredManCustCreditMaxAlt { get; private set; }
        public VocabularyKey CredManCustomerSince { get; private set; }
        public VocabularyKey CredManEligibleCreditLimitCurrency { get; private set; }
        public VocabularyKey CredManEligibleCreditLimitDate { get; private set; }
        public VocabularyKey CredManEligibleCreditMax { get; private set; }
        public VocabularyKey CredManExclude { get; private set; }
        public VocabularyKey CredManGroupId { get; private set; }
        public VocabularyKey CredManNotes { get; private set; }
        public VocabularyKey CredManStatusReasonId { get; private set; }
        public VocabularyKey CredManTitleHeld { get; private set; }
        public VocabularyKey CredManWithAgency { get; private set; }
        public VocabularyKey CredManLastReviewDate { get; private set; }
        public VocabularyKey CredManNextSchedReviewDate { get; private set; }
        public VocabularyKey CredManCustUnlimitedCredit { get; private set; }


    }
}