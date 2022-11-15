using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxSalesTaxHierarchiesEntityVocabulary : SimpleVocabulary
    {
        public TaxSalesTaxHierarchiesEntityVocabulary()
        {
            VocabularyName = "Tax Sales Tax Hierarchies Entity";
            KeyPrefix = "commonDataModel.taxsalestaxhierarchiesentity";
            KeySeparator = ".";
            Grouping = "/TaxSalesTaxHierarchiesEntity";

            AddGroup("TaxSalesTaxHierarchiesEntity Details", group =>
            {
                IsSetoffable = group.Add(new VocabularyKey(nameof(IsSetoffable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassId = group.Add(new VocabularyKey(nameof(ClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyVersionDescription = group.Add(new VocabularyKey(nameof(HierarchyVersionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActiveVersion = group.Add(new VocabularyKey(nameof(IsActiveVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyVersion = group.Add(new VocabularyKey(nameof(HierarchyVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyStructure = group.Add(new VocabularyKey(nameof(HierarchyStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsSetoffable { get; private set; }
        public VocabularyKey HierarchyName { get; private set; }
        public VocabularyKey ClassId { get; private set; }
        public VocabularyKey HierarchyVersionDescription { get; private set; }
        public VocabularyKey IsActiveVersion { get; private set; }
        public VocabularyKey HierarchyVersion { get; private set; }
        public VocabularyKey HierarchyStructure { get; private set; }
    }
}