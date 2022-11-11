using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmEmailGroupEntityVocabulary : SimpleVocabulary
    {
        public smmEmailGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmEmailGroupEntity";
            KeyPrefix = "commonDataModel.smmemailgroupentity";
            KeySeparator = ".";
            Grouping = "/smmEmailGroupEntity";

            AddGroup("Common Data Model smmEmailGroupEntity Details", group =>
            {
                EmailCategoryName = group.Add(new VocabularyKey(nameof(EmailCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EmailCategoryName { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}