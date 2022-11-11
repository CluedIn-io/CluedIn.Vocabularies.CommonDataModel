using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjValProjCategoryEntityVocabulary : SimpleVocabulary
    {
        public ProjValProjCategoryEntityVocabulary()
        {
            VocabularyName = "ProjValProjCategoryEntity";
            KeyPrefix = "commonDataModel.projvalprojcategoryentity";
            KeySeparator = ".";
            Grouping = "/ProjValProjCategoryEntity";

            AddGroup("ProjValProjCategoryEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}