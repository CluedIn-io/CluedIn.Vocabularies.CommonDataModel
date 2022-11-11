using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjValEmplCategoryEntityVocabulary : SimpleVocabulary
    {
        public ProjValEmplCategoryEntityVocabulary()
        {
            VocabularyName = "ProjValEmplCategoryEntity";
            KeyPrefix = "commonDataModel.projvalemplcategoryentity";
            KeySeparator = ".";
            Grouping = "/ProjValEmplCategoryEntity";

            AddGroup("ProjValEmplCategoryEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}