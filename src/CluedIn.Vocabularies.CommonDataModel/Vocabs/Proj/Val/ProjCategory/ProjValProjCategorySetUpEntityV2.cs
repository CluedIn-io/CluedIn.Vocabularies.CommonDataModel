using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjValProjCategorySetUpEntityV2Vocabulary : SimpleVocabulary
    {
        public ProjValProjCategorySetUpEntityV2Vocabulary()
        {
            VocabularyName = "ProjValProjCategorySetUpEntityV2";
            KeyPrefix = "commonDataModel.projvalprojcategorysetupentityv2";
            KeySeparator = ".";
            Grouping = "/ProjValProjCategorySetUpEntityV2";

            AddGroup("ProjValProjCategorySetUpEntityV2 Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjId = group.Add(new VocabularyKey(nameof(ProjId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey ProjId { get; private set; }


    }
}