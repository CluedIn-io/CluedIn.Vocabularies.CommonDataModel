using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysPolicyOrganizationEntityVocabulary : SimpleVocabulary
    {
        public SysPolicyOrganizationEntityVocabulary()
        {
            VocabularyName = "SysPolicyOrganizationEntity";
            KeyPrefix = "commonDataModel.syspolicyorganizationentity";
            KeySeparator = ".";
            Grouping = "/SysPolicyOrganizationEntity";

            AddGroup("SysPolicyOrganizationEntity Details", group =>
            {
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Organization = group.Add(new VocabularyKey(nameof(Organization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyTypeRel = group.Add(new VocabularyKey(nameof(PolicyTypeRel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey HierarchyName { get; private set; }
        public VocabularyKey Organization { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyTypeRel { get; private set; }
        public VocabularyKey PolicyType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }


    }
}