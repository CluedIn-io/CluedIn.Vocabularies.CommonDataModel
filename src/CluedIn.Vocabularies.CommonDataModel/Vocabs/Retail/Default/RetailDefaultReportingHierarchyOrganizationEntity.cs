using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDefaultReportingHierarchyOrganizationEntityVocabulary : SimpleVocabulary
    {
        public RetailDefaultReportingHierarchyOrganizationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailDefaultReportingHierarchyOrganizationEntity";
            KeyPrefix = "commonDataModel.retaildefaultreportinghierarchyorganizationentity";
            KeySeparator = ".";
            Grouping = "/RetailDefaultReportingHierarchyOrganizationEntity";

            AddGroup("Common Data Model RetailDefaultReportingHierarchyOrganizationEntity Details", group =>
            {
                OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentOrganizationRecordId = group.Add(new VocabularyKey(nameof(ParentOrganizationRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentOrganizationName = group.Add(new VocabularyKey(nameof(ParentOrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentOrganizationNumber = group.Add(new VocabularyKey(nameof(ParentOrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationRecordId = group.Add(new VocabularyKey(nameof(OrganizationRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OrganizationName { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey ParentOrganizationRecordId { get; private set; }
        public VocabularyKey ParentOrganizationName { get; private set; }
        public VocabularyKey ParentOrganizationNumber { get; private set; }
        public VocabularyKey OrganizationRecordId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }


    }
}