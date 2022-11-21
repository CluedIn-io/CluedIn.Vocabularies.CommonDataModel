using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxItemGroupHeadingEntityVocabulary : SimpleVocabulary
    {
        public TaxItemGroupHeadingEntityVocabulary()
        {
            VocabularyName = "Tax Item Group Heading Entity";
            KeyPrefix = "commonDataModel.taxitemgroupheadingentity";
            KeySeparator = ".";
            Grouping = "/TaxItemGroupHeadingEntity";

            AddGroup("TaxItemGroupHeadingEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
    }
}