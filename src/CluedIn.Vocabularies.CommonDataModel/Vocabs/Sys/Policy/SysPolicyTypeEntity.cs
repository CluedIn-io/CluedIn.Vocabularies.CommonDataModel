using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysPolicyTypeEntityVocabulary : SimpleVocabulary
    {
        public SysPolicyTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model SysPolicyTypeEntity";
            KeyPrefix = "commonDataModel.syspolicytypeentity";
            KeySeparator = ".";
            Grouping = "/SysPolicyTypeEntity";

            AddGroup("Common Data Model SysPolicyTypeEntity Details", group =>
            {
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DropDialog = group.Add(new VocabularyKey(nameof(DropDialog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPolicyReadOnly = group.Add(new VocabularyKey(nameof(IsPolicyReadOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReassignOrganizationSupported = group.Add(new VocabularyKey(nameof(IsReassignOrganizationSupported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey DropDialog { get; private set; }
        public VocabularyKey IsPolicyReadOnly { get; private set; }
        public VocabularyKey IsReassignOrganizationSupported { get; private set; }
        public VocabularyKey PolicyType { get; private set; }


    }
}