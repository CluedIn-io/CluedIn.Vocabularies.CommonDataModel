using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCategoryGroupEntityVocabulary : SimpleVocabulary
    {
        public ProjCategoryGroupEntityVocabulary()
        {
            VocabularyName = "ProjCategoryGroupEntity";
            KeyPrefix = "commonDataModel.projcategorygroupentity";
            KeySeparator = ".";
            Grouping = "/ProjCategoryGroupEntity";

            AddGroup("ProjCategoryGroupEntity Details", group =>
            {
                CategoryGroupId = group.Add(new VocabularyKey(nameof(CategoryGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryType = group.Add(new VocabularyKey(nameof(CategoryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryGroupId { get; private set; }
        public VocabularyKey CategoryType { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}