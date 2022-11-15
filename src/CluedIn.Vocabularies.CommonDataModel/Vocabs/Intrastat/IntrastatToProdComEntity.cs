using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatToProdComEntityVocabulary : SimpleVocabulary
    {
        public IntrastatToProdComEntityVocabulary()
        {
            VocabularyName = "Intrastat To Prod Com Entity";
            KeyPrefix = "commonDataModel.intrastattoprodcomentity";
            KeySeparator = ".";
            Grouping = "/IntrastatToProdComEntity";

            AddGroup("IntrastatToProdComEntity Details", group =>
            {
                CommodityHierarchyName = group.Add(new VocabularyKey(nameof(CommodityHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommodityName = group.Add(new VocabularyKey(nameof(CommodityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromYear = group.Add(new VocabularyKey(nameof(FromYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToYear = group.Add(new VocabularyKey(nameof(ToYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProdComCode = group.Add(new VocabularyKey(nameof(ProdComCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unit = group.Add(new VocabularyKey(nameof(Unit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Variable = group.Add(new VocabularyKey(nameof(Variable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CommodityHierarchyName { get; private set; }
        public VocabularyKey CommodityName { get; private set; }
        public VocabularyKey FromYear { get; private set; }
        public VocabularyKey ToYear { get; private set; }
        public VocabularyKey ProdComCode { get; private set; }
        public VocabularyKey Unit { get; private set; }
        public VocabularyKey Variable { get; private set; }
    }
}