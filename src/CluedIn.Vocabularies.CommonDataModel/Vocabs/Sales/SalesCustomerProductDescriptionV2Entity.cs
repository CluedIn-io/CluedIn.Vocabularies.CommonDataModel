using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesCustomerProductDescriptionV2EntityVocabulary : SimpleVocabulary
    {
        public SalesCustomerProductDescriptionV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesCustomerProductDescriptionV2Entity";
            KeyPrefix = "commonDataModel.salescustomerproductdescriptionv2entity";
            KeySeparator = ".";
            Grouping = "/SalesCustomerProductDescriptionV2Entity";

            AddGroup("Common Data Model SalesCustomerProductDescriptionV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescriptionCustomerGroupId = group.Add(new VocabularyKey(nameof(ProductDescriptionCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerProductNumber = group.Add(new VocabularyKey(nameof(CustomerProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerProductDescription = group.Add(new VocabularyKey(nameof(CustomerProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerABCCode = group.Add(new VocabularyKey(nameof(CustomerABCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerABCCodeNote = group.Add(new VocabularyKey(nameof(CustomerABCCodeNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey ProductDescriptionCustomerGroupId { get; private set; }
        public VocabularyKey CustomerProductNumber { get; private set; }
        public VocabularyKey CustomerProductDescription { get; private set; }
        public VocabularyKey CustomerABCCode { get; private set; }
        public VocabularyKey CustomerABCCodeNote { get; private set; }
        public VocabularyKey CustVendRelation { get; private set; }
        public VocabularyKey ModuleType { get; private set; }
        public VocabularyKey InventDimId { get; private set; }


    }
}