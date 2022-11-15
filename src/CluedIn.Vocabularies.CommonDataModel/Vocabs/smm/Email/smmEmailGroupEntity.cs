using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmEmailGroupEntityVocabulary : SimpleVocabulary
    {
        public SmmEmailGroupEntityVocabulary()
        {
            VocabularyName = "Smm Email Group Entity";
            KeyPrefix = "commonDataModel.smmemailgroupentity";
            KeySeparator = ".";
            Grouping = "/SmmEmailGroupEntity";

            AddGroup("SmmEmailGroupEntity Details", group =>
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