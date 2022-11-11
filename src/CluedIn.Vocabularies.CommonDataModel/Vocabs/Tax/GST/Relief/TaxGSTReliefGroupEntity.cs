using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGSTReliefGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxGSTReliefGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxGSTReliefGroupEntity";
            KeyPrefix = "commonDataModel.taxgstreliefgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxGSTReliefGroupEntity";

            AddGroup("Common Data Model TaxGSTReliefGroupEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReliefCategoryId = group.Add(new VocabularyKey(nameof(ReliefCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ReliefCategoryId { get; private set; }


    }
}