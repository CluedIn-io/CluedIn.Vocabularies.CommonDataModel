using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSalesTaxOverrideEntityVocabulary : SimpleVocabulary
    {
        public RetailSalesTaxOverrideEntityVocabulary()
        {
            VocabularyName = "Retail Sales Tax Override Entity";
            KeyPrefix = "commonDataModel.retailsalestaxoverrideentity";
            KeySeparator = ".";
            Grouping = "/RetailSalesTaxOverrideEntity";

            AddGroup("RetailSalesTaxOverrideEntity Details", group =>
            {
                SourceTaxGroup = group.Add(new VocabularyKey(nameof(SourceTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceItemTaxGroup = group.Add(new VocabularyKey(nameof(SourceItemTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdditionalDescription = group.Add(new VocabularyKey(nameof(AdditionalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationItemTaxGroup = group.Add(new VocabularyKey(nameof(DestinationItemTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationTaxGroup = group.Add(new VocabularyKey(nameof(DestinationTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideBy = group.Add(new VocabularyKey(nameof(OverrideBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideFrom = group.Add(new VocabularyKey(nameof(OverrideFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideTo = group.Add(new VocabularyKey(nameof(OverrideTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideType = group.Add(new VocabularyKey(nameof(OverrideType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SourceTaxGroup { get; private set; }
        public VocabularyKey SourceItemTaxGroup { get; private set; }
        public VocabularyKey AdditionalDescription { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DestinationItemTaxGroup { get; private set; }
        public VocabularyKey DestinationTaxGroup { get; private set; }
        public VocabularyKey OverrideBy { get; private set; }
        public VocabularyKey OverrideFrom { get; private set; }
        public VocabularyKey OverrideTo { get; private set; }
        public VocabularyKey OverrideType { get; private set; }
        public VocabularyKey Status { get; private set; }
    }
}