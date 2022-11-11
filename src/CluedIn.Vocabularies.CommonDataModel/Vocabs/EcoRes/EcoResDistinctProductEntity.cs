using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResDistinctProductEntityVocabulary : SimpleVocabulary
    {
        public EcoResDistinctProductEntityVocabulary()
        {
            VocabularyName = "EcoResDistinctProductEntity";
            KeyPrefix = "commonDataModel.ecoresdistinctproductentity";
            KeySeparator = ".";
            Grouping = "/EcoResDistinctProductEntity";

            AddGroup("EcoResDistinctProductEntity Details", group =>
            {
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSearchName = group.Add(new VocabularyKey(nameof(ProductSearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCatchWeightProduct = group.Add(new VocabularyKey(nameof(IsCatchWeightProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageDimensionGroupName = group.Add(new VocabularyKey(nameof(StorageDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingDimensionGroupName = group.Add(new VocabularyKey(nameof(TrackingDimensionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailProductCategoryName = group.Add(new VocabularyKey(nameof(RetailProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                STCCCode = group.Add(new VocabularyKey(nameof(STCCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HarmonizedSystemCode = group.Add(new VocabularyKey(nameof(HarmonizedSystemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NMFCCode = group.Add(new VocabularyKey(nameof(NMFCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceType = group.Add(new VocabularyKey(nameof(ServiceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTime = group.Add(new VocabularyKey(nameof(WarrantyDurationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyDurationTimeUnit = group.Add(new VocabularyKey(nameof(WarrantyDurationTimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductSearchName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey IsCatchWeightProduct { get; private set; }
        public VocabularyKey StorageDimensionGroupName { get; private set; }
        public VocabularyKey TrackingDimensionGroupName { get; private set; }
        public VocabularyKey RetailProductCategoryName { get; private set; }
        public VocabularyKey STCCCode { get; private set; }
        public VocabularyKey HarmonizedSystemCode { get; private set; }
        public VocabularyKey NMFCCode { get; private set; }
        public VocabularyKey ServiceType { get; private set; }
        public VocabularyKey WarrantyDurationTime { get; private set; }
        public VocabularyKey WarrantyDurationTimeUnit { get; private set; }


    }
}