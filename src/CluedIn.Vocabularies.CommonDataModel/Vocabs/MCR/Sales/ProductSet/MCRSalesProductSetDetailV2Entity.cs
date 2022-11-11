using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRSalesProductSetDetailV2EntityVocabulary : SimpleVocabulary
    {
        public MCRSalesProductSetDetailV2EntityVocabulary()
        {
            VocabularyName = "MCRSalesProductSetDetailV2Entity";
            KeyPrefix = "commonDataModel.mcrsalesproductsetdetailv2entity";
            KeySeparator = ".";
            Grouping = "/MCRSalesProductSetDetailV2Entity";

            AddGroup("MCRSalesProductSetDetailV2Entity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderedSalesQuantity = group.Add(new VocabularyKey(nameof(OrderedSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesProductSetNumber = group.Add(new VocabularyKey(nameof(SalesProductSetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey OrderedSalesQuantity { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey SalesProductSetNumber { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}