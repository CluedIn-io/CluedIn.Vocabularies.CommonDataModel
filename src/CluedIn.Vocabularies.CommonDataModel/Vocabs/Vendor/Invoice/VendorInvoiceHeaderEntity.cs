using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorInvoiceHeaderEntityVocabulary : SimpleVocabulary
    {
        public VendorInvoiceHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorInvoiceHeaderEntity";
            KeyPrefix = "commonDataModel.vendorinvoiceheaderentity";
            KeySeparator = ".";
            Grouping = "/VendorInvoiceHeaderEntity";

            AddGroup("Common Data Model VendorInvoiceHeaderEntity Details", group =>
            {
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsApproved = group.Add(new VocabularyKey(nameof(IsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedBy = group.Add(new VocabularyKey(nameof(ApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipmentNumber = group.Add(new VocabularyKey(nameof(ShipmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatch = group.Add(new VocabularyKey(nameof(IsBatch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscount = group.Add(new VocabularyKey(nameof(CashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountDate = group.Add(new VocabularyKey(nameof(CashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyOrigDest = group.Add(new VocabularyKey(nameof(CountyOrigDest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryName = group.Add(new VocabularyKey(nameof(DeliveryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDescription = group.Add(new VocabularyKey(nameof(InvoiceDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscount = group.Add(new VocabularyKey(nameof(TotalDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnterpriseNumber = group.Add(new VocabularyKey(nameof(EnterpriseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorInvalidDistribution = group.Add(new VocabularyKey(nameof(ErrorInvalidDistribution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Triangulation = group.Add(new VocabularyKey(nameof(Triangulation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryExchangeRate = group.Add(new VocabularyKey(nameof(SecondaryExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedRate = group.Add(new VocabularyKey(nameof(FixedRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOnHold = group.Add(new VocabularyKey(nameof(IsOnHold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IgnoreCalculatedSalesTax = group.Add(new VocabularyKey(nameof(IgnoreCalculatedSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPricesIncludeSalesTax = group.Add(new VocabularyKey(nameof(IsPricesIncludeSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Site = group.Add(new VocabularyKey(nameof(Site), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicePaymentReleaseDate = group.Add(new VocabularyKey(nameof(InvoicePaymentReleaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceRoundOff = group.Add(new VocabularyKey(nameof(InvoiceRoundOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceType = group.Add(new VocabularyKey(nameof(VendorInvoiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ListCode = group.Add(new VocabularyKey(nameof(ListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Log = group.Add(new VocabularyKey(nameof(Log), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargesGroup = group.Add(new VocabularyKey(nameof(ChargesGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchStatus = group.Add(new VocabularyKey(nameof(MatchStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSchedule = group.Add(new VocabularyKey(nameof(PaymentSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentId = group.Add(new VocabularyKey(nameof(PaymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSpecification = group.Add(new VocabularyKey(nameof(PaymentSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Port = group.Add(new VocabularyKey(nameof(Port), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorName = group.Add(new VocabularyKey(nameof(VendorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recalculation = group.Add(new VocabularyKey(nameof(Recalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleaseDateComment = group.Add(new VocabularyKey(nameof(ReleaseDateComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceLocation = group.Add(new VocabularyKey(nameof(RemittanceLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceReviewStatus = group.Add(new VocabularyKey(nameof(VendorInvoiceReviewStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleVoucher = group.Add(new VocabularyKey(nameof(SettleVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticsProcedure = group.Add(new VocabularyKey(nameof(StatisticsProcedure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCorrection = group.Add(new VocabularyKey(nameof(CreditCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderReference = group.Add(new VocabularyKey(nameof(HeaderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxRounding = group.Add(new VocabularyKey(nameof(SalesTaxRounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDetails = group.Add(new VocabularyKey(nameof(TransportationDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovePostingWithMatchingDiscrepancies = group.Add(new VocabularyKey(nameof(ApprovePostingWithMatchingDiscrepancies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VarianceApprovedDateTime = group.Add(new VocabularyKey(nameof(VarianceApprovedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VarianceApprovedBy = group.Add(new VocabularyKey(nameof(VarianceApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceGroup = group.Add(new VocabularyKey(nameof(InvoiceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRequestedWorkerEmail = group.Add(new VocabularyKey(nameof(VendorRequestedWorkerEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentGroupCode = group.Add(new VocabularyKey(nameof(PaymentGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariancePersonnelNumber = group.Add(new VocabularyKey(nameof(VariancePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UUID = group.Add(new VocabularyKey(nameof(UUID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceSeries = group.Add(new VocabularyKey(nameof(InvoiceSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTInvoiceType = group.Add(new VocabularyKey(nameof(GSTInvoiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTImportDeclarationNumber = group.Add(new VocabularyKey(nameof(GSTImportDeclarationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankConstantSymbol = group.Add(new VocabularyKey(nameof(BankConstantSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankSpecificSymbol = group.Add(new VocabularyKey(nameof(BankSpecificSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentFinancialInterestCode = group.Add(new VocabularyKey(nameof(VendorPaymentFinancialInterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentFineCode = group.Add(new VocabularyKey(nameof(VendorPaymentFineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinalUser = group.Add(new VocabularyKey(nameof(IsFinalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CTeType = group.Add(new VocabularyKey(nameof(CTeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCodeOnDeliveryAddress = group.Add(new VocabularyKey(nameof(ServiceCodeOnDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPurchOperationTypeRecId = group.Add(new VocabularyKey(nameof(SalesPurchOperationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOperationPresenceType = group.Add(new VocabularyKey(nameof(FiscalOperationPresenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportDeclarationRecId = group.Add(new VocabularyKey(nameof(ImportDeclarationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeRecId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentSpecie = group.Add(new VocabularyKey(nameof(FiscalDocumentSpecie), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentModel = group.Add(new VocabularyKey(nameof(FiscalDocumentModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsElectronicInvoiceForService = group.Add(new VocabularyKey(nameof(IsElectronicInvoiceForService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTransportBrand = group.Add(new VocabularyKey(nameof(DeliveryTransportBrand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryStateRegistered = group.Add(new VocabularyKey(nameof(DeliveryStateRegistered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPackingName = group.Add(new VocabularyKey(nameof(DeliveryPackingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryVehicleNumber = group.Add(new VocabularyKey(nameof(DeliveryVehicleNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryFreightChargeTerms = group.Add(new VocabularyKey(nameof(DeliveryFreightChargeTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFPSCode = group.Add(new VocabularyKey(nameof(CFPSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightedBy = group.Add(new VocabularyKey(nameof(FreightedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierName = group.Add(new VocabularyKey(nameof(CarrierName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessKey = group.Add(new VocabularyKey(nameof(AccessKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentRecId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentOperationTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentOperationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportDeclarationNumber = group.Add(new VocabularyKey(nameof(ImportDeclarationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchReceiptDate_W = group.Add(new VocabularyKey(nameof(PurchReceiptDate_W), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchangeRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNBankAccountId = group.Add(new VocabularyKey(nameof(PSNBankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNCardHolderName = group.Add(new VocabularyKey(nameof(PSNCardHolderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNPostingDefinitionRecId = group.Add(new VocabularyKey(nameof(PSNPostingDefinitionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNPostingDefinitionCode = group.Add(new VocabularyKey(nameof(PSNPostingDefinitionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNCardNumberDigits = group.Add(new VocabularyKey(nameof(PSNCardNumberDigits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNReferenceInvoiceNumber = group.Add(new VocabularyKey(nameof(PSNReferenceInvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNPurchasingCardTransactionType = group.Add(new VocabularyKey(nameof(PSNPurchasingCardTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSNVendorAccountForBalancePayoff = group.Add(new VocabularyKey(nameof(PSNVendorAccountForBalancePayoff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey IsApproved { get; private set; }
        public VocabularyKey ApprovedBy { get; private set; }
        public VocabularyKey ShipmentNumber { get; private set; }
        public VocabularyKey IsBatch { get; private set; }
        public VocabularyKey CashDiscount { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey CashDiscountDate { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey CountyOrigDest { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DeliveryName { get; private set; }
        public VocabularyKey InvoiceDescription { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey TotalDiscount { get; private set; }
        public VocabularyKey EnterpriseNumber { get; private set; }
        public VocabularyKey ErrorInvalidDistribution { get; private set; }
        public VocabularyKey Triangulation { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SecondaryExchangeRate { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey FixedRate { get; private set; }
        public VocabularyKey IsOnHold { get; private set; }
        public VocabularyKey IgnoreCalculatedSalesTax { get; private set; }
        public VocabularyKey IsPricesIncludeSalesTax { get; private set; }
        public VocabularyKey Warehouse { get; private set; }
        public VocabularyKey Site { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey InvoicePaymentReleaseDate { get; private set; }
        public VocabularyKey InvoiceRoundOff { get; private set; }
        public VocabularyKey VendorInvoiceType { get; private set; }
        public VocabularyKey ListCode { get; private set; }
        public VocabularyKey Log { get; private set; }
        public VocabularyKey ChargesGroup { get; private set; }
        public VocabularyKey MatchStatus { get; private set; }
        public VocabularyKey InvoiceNumber { get; private set; }
        public VocabularyKey NumberSequenceGroup { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey PaymentSchedule { get; private set; }
        public VocabularyKey PaymentId { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey PaymentSpecification { get; private set; }
        public VocabularyKey Port { get; private set; }
        public VocabularyKey VendorName { get; private set; }
        public VocabularyKey Recalculation { get; private set; }
        public VocabularyKey ReleaseDateComment { get; private set; }
        public VocabularyKey RemittanceLocation { get; private set; }
        public VocabularyKey VendorInvoiceReviewStatus { get; private set; }
        public VocabularyKey SettleVoucher { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey StatisticsProcedure { get; private set; }
        public VocabularyKey CreditCorrection { get; private set; }
        public VocabularyKey HeaderReference { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey SalesTaxRounding { get; private set; }
        public VocabularyKey TransactionCode { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey Transport { get; private set; }
        public VocabularyKey TransportationDetails { get; private set; }
        public VocabularyKey ApprovePostingWithMatchingDiscrepancies { get; private set; }
        public VocabularyKey VarianceApprovedDateTime { get; private set; }
        public VocabularyKey VarianceApprovedBy { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey BankAccount { get; private set; }
        public VocabularyKey InvoiceGroup { get; private set; }
        public VocabularyKey VendorRequestedWorkerEmail { get; private set; }
        public VocabularyKey PaymentGroupCode { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }
        public VocabularyKey VariancePersonnelNumber { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey UUID { get; private set; }
        public VocabularyKey InvoiceSeries { get; private set; }
        public VocabularyKey GSTInvoiceType { get; private set; }
        public VocabularyKey GSTImportDeclarationNumber { get; private set; }
        public VocabularyKey BankConstantSymbol { get; private set; }
        public VocabularyKey BankSpecificSymbol { get; private set; }
        public VocabularyKey VendorPaymentFinancialInterestCode { get; private set; }
        public VocabularyKey VendorPaymentFineCode { get; private set; }
        public VocabularyKey IsFinalUser { get; private set; }
        public VocabularyKey CTeType { get; private set; }
        public VocabularyKey ServiceCodeOnDeliveryAddress { get; private set; }
        public VocabularyKey SalesPurchOperationTypeRecId { get; private set; }
        public VocabularyKey FiscalOperationPresenceType { get; private set; }
        public VocabularyKey ImportDeclarationRecId { get; private set; }
        public VocabularyKey FiscalDocumentTypeRecId { get; private set; }
        public VocabularyKey FiscalDocumentSpecie { get; private set; }
        public VocabularyKey FiscalDocumentSeries { get; private set; }
        public VocabularyKey FiscalDocumentModel { get; private set; }
        public VocabularyKey IsElectronicInvoiceForService { get; private set; }
        public VocabularyKey DeliveryTransportBrand { get; private set; }
        public VocabularyKey DeliveryStateRegistered { get; private set; }
        public VocabularyKey DeliveryPackingName { get; private set; }
        public VocabularyKey DeliveryVehicleNumber { get; private set; }
        public VocabularyKey DeliveryFreightChargeTerms { get; private set; }
        public VocabularyKey CFPSCode { get; private set; }
        public VocabularyKey FreightedBy { get; private set; }
        public VocabularyKey CarrierName { get; private set; }
        public VocabularyKey AccessKey { get; private set; }
        public VocabularyKey FiscalDocumentTypeId { get; private set; }
        public VocabularyKey FiscalEstablishmentRecId { get; private set; }
        public VocabularyKey FiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentOperationTypeId { get; private set; }
        public VocabularyKey ImportDeclarationNumber { get; private set; }
        public VocabularyKey PurchReceiptDate_W { get; private set; }
        public VocabularyKey ReportingCurrencyExchangeRate { get; private set; }
        public VocabularyKey PSNBankAccountId { get; private set; }
        public VocabularyKey PSNCardHolderName { get; private set; }
        public VocabularyKey PSNPostingDefinitionRecId { get; private set; }
        public VocabularyKey PSNPostingDefinitionCode { get; private set; }
        public VocabularyKey PSNCardNumberDigits { get; private set; }
        public VocabularyKey PSNReferenceInvoiceNumber { get; private set; }
        public VocabularyKey PSNPurchasingCardTransactionType { get; private set; }
        public VocabularyKey PSNVendorAccountForBalancePayoff { get; private set; }


    }
}