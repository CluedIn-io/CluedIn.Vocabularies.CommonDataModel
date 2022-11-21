using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchVendorProductDescriptionV2EntityVocabulary : SimpleVocabulary
    {
        public PurchVendorProductDescriptionV2EntityVocabulary()
        {
            VocabularyName = "Purch Vendor Product Description V2 Entity";
            KeyPrefix = "commonDataModel.purchvendorproductdescriptionv2entity";
            KeySeparator = ".";
            Grouping = "/PurchVendorProductDescriptionV2Entity";

            AddGroup("PurchVendorProductDescriptionV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescriptionVendorGroupId = group.Add(new VocabularyKey(nameof(ProductDescriptionVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorProductNumber = group.Add(new VocabularyKey(nameof(VendorProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorProductDescription = group.Add(new VocabularyKey(nameof(VendorProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorABCCode = group.Add(new VocabularyKey(nameof(VendorABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorABCCodeNote = group.Add(new VocabularyKey(nameof(VendorABCCodeNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendRelation = group.Add(new VocabularyKey(nameof(CustVendRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModuleType = group.Add(new VocabularyKey(nameof(ModuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey ProductDescriptionVendorGroupId { get; private set; }
        public VocabularyKey VendorProductNumber { get; private set; }
        public VocabularyKey VendorProductDescription { get; private set; }
        public VocabularyKey VendorABCCode { get; private set; }
        public VocabularyKey VendorABCCodeNote { get; private set; }
        public VocabularyKey CustVendRelation { get; private set; }
        public VocabularyKey ModuleType { get; private set; }
        public VocabularyKey InventDimId { get; private set; }
    }
}