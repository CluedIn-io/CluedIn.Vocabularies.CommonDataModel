using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPersonalContactOrganizationEntityVocabulary : SimpleVocabulary
    {
        public HcmPersonalContactOrganizationEntityVocabulary()
        {
            VocabularyName = "HcmPersonalContactOrganizationEntity";
            KeyPrefix = "commonDataModel.hcmpersonalcontactorganizationentity";
            KeySeparator = ".";
            Grouping = "/HcmPersonalContactOrganizationEntity";

            AddGroup("HcmPersonalContactOrganizationEntity Details", group =>
            {
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactOrganizationPartyNumber = group.Add(new VocabularyKey(nameof(ContactOrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBeneficiary = group.Add(new VocabularyKey(nameof(IsBeneficiary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkerPersonnelNumber { get; private set; }
        public VocabularyKey ContactOrganizationPartyNumber { get; private set; }
        public VocabularyKey RelationshipType { get; private set; }
        public VocabularyKey IsBeneficiary { get; private set; }
        public VocabularyKey OrganizationName { get; private set; }


    }
}