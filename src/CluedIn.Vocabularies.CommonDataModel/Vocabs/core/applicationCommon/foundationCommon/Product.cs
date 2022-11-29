using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class ProductVocabulary : SimpleVocabulary
    {
        public ProductVocabulary()
        {
            VocabularyName = "Product";
            KeyPrefix = "commonDataModel.product.foundationcommon";
            KeySeparator = ".";
            Grouping = "/Product";

            AddGroup("Product Details for FoundationCommon", group =>
            {
			    ProductId = group.Add(new VocabularyKey(nameof(ProductId), "Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VendorID = group.Add(new VocabularyKey(nameof(VendorID), "Vendor ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CurrentCost = group.Add(new VocabularyKey(nameof(CurrentCost), "Current Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CurrentCostBase = group.Add(new VocabularyKey(nameof(CurrentCostBase), "Current Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsKit = group.Add(new VocabularyKey(nameof(IsKit), "Is Kit", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsStockItem = group.Add(new VocabularyKey(nameof(IsStockItem), "Stock Item", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "List Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "List Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductStructure = group.Add(new VocabularyKey(nameof(ProductStructure), "Product Structure", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), "Product ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductTypeCode = group.Add(new VocabularyKey(nameof(ProductTypeCode), "Product Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductUrl = group.Add(new VocabularyKey(nameof(ProductUrl), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    QuantityDecimal = group.Add(new VocabularyKey(nameof(QuantityDecimal), "Decimals Supported", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    QuantityOnHand = group.Add(new VocabularyKey(nameof(QuantityOnHand), "Quantity On Hand", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Size = group.Add(new VocabularyKey(nameof(Size), "Size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StandardCost = group.Add(new VocabularyKey(nameof(StandardCost), "Standard Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StandardCostBase = group.Add(new VocabularyKey(nameof(StandardCostBase), "Standard Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StockVolume = group.Add(new VocabularyKey(nameof(StockVolume), "Stock Volume", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StockWeight = group.Add(new VocabularyKey(nameof(StockWeight), "Stock Weight", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SupplierName = group.Add(new VocabularyKey(nameof(SupplierName), "Supplier Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VendorName = group.Add(new VocabularyKey(nameof(VendorName), "Vendor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VendorPartNumber = group.Add(new VocabularyKey(nameof(VendorPartNumber), "Vendor Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HierarchyPath = group.Add(new VocabularyKey(nameof(HierarchyPath), "Hierarchy Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProductId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey VendorID { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey CurrentCost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CurrentCostBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsKit { get; private set; }
        public VocabularyKey IsStockItem { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey ProductStructure { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductTypeCode { get; private set; }
        public VocabularyKey ProductUrl { get; private set; }
        public VocabularyKey QuantityDecimal { get; private set; }
        public VocabularyKey QuantityOnHand { get; private set; }
        public VocabularyKey Size { get; private set; }
        public VocabularyKey StandardCost { get; private set; }
        public VocabularyKey StandardCostBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StockVolume { get; private set; }
        public VocabularyKey StockWeight { get; private set; }
        public VocabularyKey SupplierName { get; private set; }
        public VocabularyKey VendorName { get; private set; }
        public VocabularyKey VendorPartNumber { get; private set; }
        public VocabularyKey HierarchyPath { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
    }
}