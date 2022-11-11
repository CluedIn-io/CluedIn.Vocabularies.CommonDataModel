using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductGlobalTradeItemNumberAssignmentV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResProductGlobalTradeItemNumberAssignmentV2EntityVocabulary()
        {
            VocabularyName = "EcoResProductGlobalTradeItemNumberAssignmentV2Entity";
            KeyPrefix = "commonDataModel.ecoresproductglobaltradeitemnumberassignmentv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResProductGlobalTradeItemNumberAssignmentV2Entity";

            AddGroup("EcoResProductGlobalTradeItemNumberAssignmentV2Entity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductUnitSymbol = group.Add(new VocabularyKey(nameof(ProductUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GlobalTradeItemNumberCodeType = group.Add(new VocabularyKey(nameof(GlobalTradeItemNumberCodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GlobalTradeItemNumber = group.Add(new VocabularyKey(nameof(GlobalTradeItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GlobalTradeItemNumberDescription = group.Add(new VocabularyKey(nameof(GlobalTradeItemNumberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey ProductUnitSymbol { get; private set; }
        public VocabularyKey GlobalTradeItemNumberCodeType { get; private set; }
        public VocabularyKey GlobalTradeItemNumber { get; private set; }
        public VocabularyKey GlobalTradeItemNumberDescription { get; private set; }


    }
}