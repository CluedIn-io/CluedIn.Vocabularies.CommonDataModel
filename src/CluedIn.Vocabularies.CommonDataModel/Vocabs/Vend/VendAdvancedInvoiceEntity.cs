using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendAdvancedInvoiceEntityVocabulary : SimpleVocabulary
    {
        public VendAdvancedInvoiceEntityVocabulary()
        {
            VocabularyName = "VendAdvancedInvoiceEntity";
            KeyPrefix = "commonDataModel.vendadvancedinvoiceentity";
            KeySeparator = ".";
            Grouping = "/VendAdvancedInvoiceEntity";

            AddGroup("VendAdvancedInvoiceEntity Details", group =>
            {
                VendAccount = group.Add(new VocabularyKey(nameof(VendAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendGroup = group.Add(new VocabularyKey(nameof(VendGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrder = group.Add(new VocabularyKey(nameof(PurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerSalesTaker = group.Add(new VocabularyKey(nameof(WorkerSalesTaker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariableSymbol = group.Add(new VocabularyKey(nameof(VariableSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceInvoice = group.Add(new VocabularyKey(nameof(AdvanceInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Contact = group.Add(new VocabularyKey(nameof(Contact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSpecification = group.Add(new VocabularyKey(nameof(PaymentSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstantSymbol = group.Add(new VocabularyKey(nameof(ConstantSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ListCode = group.Add(new VocabularyKey(nameof(ListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAmount = group.Add(new VocabularyKey(nameof(InvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Recipient = group.Add(new VocabularyKey(nameof(Recipient), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendPostalAddress = group.Add(new VocabularyKey(nameof(VendPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OneTimeSupplier = group.Add(new VocabularyKey(nameof(OneTimeSupplier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAdvanceInvoiceId = group.Add(new VocabularyKey(nameof(VendAdvanceInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeadId = group.Add(new VocabularyKey(nameof(HeadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceText = group.Add(new VocabularyKey(nameof(InvoiceText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentRecId = group.Add(new VocabularyKey(nameof(ParentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDescription = group.Add(new VocabularyKey(nameof(DeliveryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryLocationId = group.Add(new VocabularyKey(nameof(DeliveryLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCountryRegion = group.Add(new VocabularyKey(nameof(DeliveryCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryZipCode = group.Add(new VocabularyKey(nameof(DeliveryZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddress = group.Add(new VocabularyKey(nameof(DeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryStreet = group.Add(new VocabularyKey(nameof(DeliveryStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCity = group.Add(new VocabularyKey(nameof(DeliveryCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryState = group.Add(new VocabularyKey(nameof(DeliveryState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCounty = group.Add(new VocabularyKey(nameof(DeliveryCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDeliveryPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDistrictName = group.Add(new VocabularyKey(nameof(DeliveryDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DunsNumber = group.Add(new VocabularyKey(nameof(DunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryLatitude = group.Add(new VocabularyKey(nameof(DeliveryLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryLongitude = group.Add(new VocabularyKey(nameof(DeliveryLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTimeZone = group.Add(new VocabularyKey(nameof(DeliveryTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostBox = group.Add(new VocabularyKey(nameof(DeliveryPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComputedLineNum = group.Add(new VocabularyKey(nameof(ComputedLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendAccount { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey VendGroup { get; private set; }
        public VocabularyKey PurchaseOrder { get; private set; }
        public VocabularyKey WorkerSalesTaker { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey NumberSequenceGroup { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey VariableSymbol { get; private set; }
        public VocabularyKey AdvanceInvoice { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey Contact { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey PaymentSpecification { get; private set; }
        public VocabularyKey ConstantSymbol { get; private set; }
        public VocabularyKey ListCode { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey InvoiceAmount { get; private set; }
        public VocabularyKey Recipient { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey VendPostalAddress { get; private set; }
        public VocabularyKey OneTimeSupplier { get; private set; }
        public VocabularyKey VendAdvanceInvoiceId { get; private set; }
        public VocabularyKey HeadId { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InvoiceText { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey ParentRecId { get; private set; }
        public VocabularyKey DeliveryDescription { get; private set; }
        public VocabularyKey DeliveryLocationId { get; private set; }
        public VocabularyKey DeliveryCountryRegion { get; private set; }
        public VocabularyKey DeliveryCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryZipCode { get; private set; }
        public VocabularyKey DeliveryAddress { get; private set; }
        public VocabularyKey DeliveryStreet { get; private set; }
        public VocabularyKey DeliveryCity { get; private set; }
        public VocabularyKey DeliveryState { get; private set; }
        public VocabularyKey DeliveryCounty { get; private set; }
        public VocabularyKey IsDeliveryPrivate { get; private set; }
        public VocabularyKey DeliveryBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryDistrictName { get; private set; }
        public VocabularyKey DunsNumber { get; private set; }
        public VocabularyKey DeliveryLatitude { get; private set; }
        public VocabularyKey DeliveryLongitude { get; private set; }
        public VocabularyKey DeliveryStreetNumber { get; private set; }
        public VocabularyKey DeliveryTimeZone { get; private set; }
        public VocabularyKey DeliveryValidFrom { get; private set; }
        public VocabularyKey DeliveryValidTo { get; private set; }
        public VocabularyKey DeliveryPostBox { get; private set; }
        public VocabularyKey ComputedLineNum { get; private set; }


    }
}