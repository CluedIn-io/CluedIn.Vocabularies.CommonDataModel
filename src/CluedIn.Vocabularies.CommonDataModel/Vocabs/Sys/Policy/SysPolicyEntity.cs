using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysPolicyEntityVocabulary : SimpleVocabulary
    {
        public SysPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model SysPolicyEntity";
            KeyPrefix = "commonDataModel.syspolicyentity";
            KeySeparator = ".";
            Grouping = "/SysPolicyEntity";

            AddGroup("Common Data Model SysPolicyEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPolicyActive = group.Add(new VocabularyKey(nameof(IsPolicyActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyTypeRecId = group.Add(new VocabularyKey(nameof(PolicyTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsPolicyActive { get; private set; }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyTypeRecId { get; private set; }
        public VocabularyKey PolicyType { get; private set; }


    }
}