using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustAdvancedInvoiceEntityVocabulary : SimpleVocabulary
    {
        public CustAdvancedInvoiceEntityVocabulary()
        {
            VocabularyName = "CustAdvancedInvoiceEntity";
            KeyPrefix = "commonDataModel.custadvancedinvoiceentity";
            KeySeparator = ".";
            Grouping = "/CustAdvancedInvoiceEntity";

            AddGroup("CustAdvancedInvoiceEntity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OneTimeCustomer = group.Add(new VocabularyKey(nameof(OneTimeCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostVAT = group.Add(new VocabularyKey(nameof(PostVAT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostVATUntil = group.Add(new VocabularyKey(nameof(PostVATUntil), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateTaxDocument = group.Add(new VocabularyKey(nameof(CreateTaxDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrepaymentPostingProfile = group.Add(new VocabularyKey(nameof(PrepaymentPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrder = group.Add(new VocabularyKey(nameof(SalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recipient = group.Add(new VocabularyKey(nameof(Recipient), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceInvoice = group.Add(new VocabularyKey(nameof(AdvanceInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceInvoiceVoucher = group.Add(new VocabularyKey(nameof(AdvanceInvoiceVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerSalesTaker = group.Add(new VocabularyKey(nameof(WorkerSalesTaker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAmount = group.Add(new VocabularyKey(nameof(InvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Triangulation = group.Add(new VocabularyKey(nameof(Triangulation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATRegisterDate = group.Add(new VocabularyKey(nameof(VATRegisterDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDocumentStatus = group.Add(new VocabularyKey(nameof(SalesDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentDate = group.Add(new VocabularyKey(nameof(FiscalDocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPrinter = group.Add(new VocabularyKey(nameof(FiscalPrinter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalInvoiceAccount = group.Add(new VocabularyKey(nameof(FiscalInvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOrderAccount = group.Add(new VocabularyKey(nameof(FiscalOrderAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSpecification = group.Add(new VocabularyKey(nameof(PaymentSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSchedule = group.Add(new VocabularyKey(nameof(PaymentSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstantSymbol = group.Add(new VocabularyKey(nameof(ConstantSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Listcode = group.Add(new VocabularyKey(nameof(Listcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondaryExchangeRate = group.Add(new VocabularyKey(nameof(SecondaryExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAdvanceInvoiceId = group.Add(new VocabularyKey(nameof(CustAdvanceInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeadId = group.Add(new VocabularyKey(nameof(HeadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceTxt = group.Add(new VocabularyKey(nameof(InvoiceTxt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerDimension = group.Add(new VocabularyKey(nameof(OffsetLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentRecId = group.Add(new VocabularyKey(nameof(ParentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionDescription = group.Add(new VocabularyKey(nameof(CorrectionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(OffsetLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCity = group.Add(new VocabularyKey(nameof(DeliveryCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCounty = group.Add(new VocabularyKey(nameof(DeliveryCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDistrictName = group.Add(new VocabularyKey(nameof(DeliveryDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryIsPrivate = group.Add(new VocabularyKey(nameof(DeliveryIsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryLatitude = group.Add(new VocabularyKey(nameof(DeliveryLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryLocationId = group.Add(new VocabularyKey(nameof(DeliveryLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryLongitude = group.Add(new VocabularyKey(nameof(DeliveryLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostBox = group.Add(new VocabularyKey(nameof(DeliveryPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryState = group.Add(new VocabularyKey(nameof(DeliveryState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryStreet = group.Add(new VocabularyKey(nameof(DeliveryStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTimeZone = group.Add(new VocabularyKey(nameof(DeliveryTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddress = group.Add(new VocabularyKey(nameof(DeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryZipCode = group.Add(new VocabularyKey(nameof(DeliveryZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalAddress = group.Add(new VocabularyKey(nameof(PostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDescription = group.Add(new VocabularyKey(nameof(DeliveryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustGroup = group.Add(new VocabularyKey(nameof(CustGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComputedLineNum = group.Add(new VocabularyKey(nameof(ComputedLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailOrderReferenceId = group.Add(new VocabularyKey(nameof(RetailOrderReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailStoreId = group.Add(new VocabularyKey(nameof(RetailStoreId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailTerminalId = group.Add(new VocabularyKey(nameof(RetailTerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailTransactionId = group.Add(new VocabularyKey(nameof(RetailTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey OneTimeCustomer { get; private set; }
        public VocabularyKey PostVAT { get; private set; }
        public VocabularyKey PostVATUntil { get; private set; }
        public VocabularyKey CreateTaxDocument { get; private set; }
        public VocabularyKey PrepaymentPostingProfile { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SalesOrder { get; private set; }
        public VocabularyKey Recipient { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey NumberSequenceGroup { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey AdvanceInvoice { get; private set; }
        public VocabularyKey AdvanceInvoiceVoucher { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey WorkerSalesTaker { get; private set; }
        public VocabularyKey InvoiceAmount { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey Triangulation { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey VATRegisterDate { get; private set; }
        public VocabularyKey SalesDocumentStatus { get; private set; }
        public VocabularyKey FiscalDocumentDate { get; private set; }
        public VocabularyKey FiscalPrinter { get; private set; }
        public VocabularyKey FiscalInvoiceAccount { get; private set; }
        public VocabularyKey FiscalOrderAccount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey PaymentSpecification { get; private set; }
        public VocabularyKey PaymentSchedule { get; private set; }
        public VocabularyKey ConstantSymbol { get; private set; }
        public VocabularyKey Listcode { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SecondaryExchangeRate { get; private set; }
        public VocabularyKey CustAdvanceInvoiceId { get; private set; }
        public VocabularyKey HeadId { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InvoiceTxt { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey OffsetLedgerDimension { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey ParentRecId { get; private set; }
        public VocabularyKey CorrectionDescription { get; private set; }
        public VocabularyKey OffsetLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryCity { get; private set; }
        public VocabularyKey DeliveryCountryRegionId { get; private set; }
        public VocabularyKey DeliveryCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryCounty { get; private set; }
        public VocabularyKey DeliveryDistrictName { get; private set; }
        public VocabularyKey DeliveryDunsNumber { get; private set; }
        public VocabularyKey DeliveryIsPrivate { get; private set; }
        public VocabularyKey DeliveryLatitude { get; private set; }
        public VocabularyKey DeliveryLocationId { get; private set; }
        public VocabularyKey DeliveryLongitude { get; private set; }
        public VocabularyKey DeliveryPostBox { get; private set; }
        public VocabularyKey DeliveryState { get; private set; }
        public VocabularyKey DeliveryStreet { get; private set; }
        public VocabularyKey DeliveryStreetNumber { get; private set; }
        public VocabularyKey DeliveryTimeZone { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey DeliveryAddress { get; private set; }
        public VocabularyKey DeliveryZipCode { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey PostalAddress { get; private set; }
        public VocabularyKey DeliveryDescription { get; private set; }
        public VocabularyKey CustGroup { get; private set; }
        public VocabularyKey ComputedLineNum { get; private set; }
        public VocabularyKey RetailOrderReferenceId { get; private set; }
        public VocabularyKey RetailStoreId { get; private set; }
        public VocabularyKey RetailTerminalId { get; private set; }
        public VocabularyKey RetailTransactionId { get; private set; }


    }
}