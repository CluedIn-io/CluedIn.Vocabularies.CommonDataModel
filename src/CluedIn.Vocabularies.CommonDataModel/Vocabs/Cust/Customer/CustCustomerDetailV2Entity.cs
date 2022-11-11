using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerDetailV2EntityVocabulary : SimpleVocabulary
    {
        public CustCustomerDetailV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model CustCustomerDetailV2Entity";
            KeyPrefix = "commonDataModel.custcustomerdetailv2entity";
            KeySeparator = ".";
            Grouping = "/CustCustomerDetailV2Entity";

            AddGroup("Common Data Model CustCustomerDetailV2Entity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOneTimeCustomer = group.Add(new VocabularyKey(nameof(IsOneTimeCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticsGroupId = group.Add(new VocabularyKey(nameof(StatisticsGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStatement = group.Add(new VocabularyKey(nameof(AccountStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationNumber = group.Add(new VocabularyKey(nameof(IdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                CompanyType = group.Add(new VocabularyKey(nameof(CompanyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CURPNumber = group.Add(new VocabularyKey(nameof(CURPNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFCNumber = group.Add(new VocabularyKey(nameof(RFCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateInscription = group.Add(new VocabularyKey(nameof(StateInscription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationId = group.Add(new VocabularyKey(nameof(TaxRegistrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationDay = group.Add(new VocabularyKey(nameof(ConsolidationDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NationalRegistryNumber = group.Add(new VocabularyKey(nameof(NationalRegistryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                NAFCodeId = group.Add(new VocabularyKey(nameof(NAFCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReliefGroupId = group.Add(new VocabularyKey(nameof(ReliefGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NAFCode = group.Add(new VocabularyKey(nameof(NAFCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReliefGroup = group.Add(new VocabularyKey(nameof(ReliefGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentPolicyName = group.Add(new VocabularyKey(nameof(FulfillmentPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentPolicy = group.Add(new VocabularyKey(nameof(FulfillmentPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowCreateIndirectOrderLines = group.Add(new VocabularyKey(nameof(IsAllowCreateIndirectOrderLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionLetterCode = group.Add(new VocabularyKey(nameof(CollectionLetterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey IsOneTimeCustomer { get; private set; }
        public VocabularyKey StatisticsGroupId { get; private set; }
        public VocabularyKey AccountStatement { get; private set; }
        public VocabularyKey IdentificationNumber { get; private set; }
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
        public VocabularyKey CompanyType { get; private set; }
        public VocabularyKey CURPNumber { get; private set; }
        public VocabularyKey RFCNumber { get; private set; }
        public VocabularyKey StateInscription { get; private set; }
        public VocabularyKey TaxRegistrationId { get; private set; }
        public VocabularyKey ConsolidationDay { get; private set; }
        public VocabularyKey NationalRegistryNumber { get; private set; }
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
        public VocabularyKey NAFCodeId { get; private set; }
        public VocabularyKey ReliefGroupId { get; private set; }
        public VocabularyKey NAFCode { get; private set; }
        public VocabularyKey ReliefGroup { get; private set; }
        public VocabularyKey FulfillmentPolicyName { get; private set; }
        public VocabularyKey FulfillmentPolicy { get; private set; }
        public VocabularyKey IsAllowCreateIndirectOrderLines { get; private set; }
        public VocabularyKey CollectionLetterCode { get; private set; }


    }
}