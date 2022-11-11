using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysPolicyInternalOrganizationAssignmentEntityVocabulary : SimpleVocabulary
    {
        public SysPolicyInternalOrganizationAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model SysPolicyInternalOrganizationAssignmentEntity";
            KeyPrefix = "commonDataModel.syspolicyinternalorganizationassignmententity";
            KeySeparator = ".";
            Grouping = "/SysPolicyInternalOrganizationAssignmentEntity";

            AddGroup("Common Data Model SysPolicyInternalOrganizationAssignmentEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationHierarchyName = group.Add(new VocabularyKey(nameof(OrganizationHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyType { get; private set; }
        public VocabularyKey OrganizationHierarchyName { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}