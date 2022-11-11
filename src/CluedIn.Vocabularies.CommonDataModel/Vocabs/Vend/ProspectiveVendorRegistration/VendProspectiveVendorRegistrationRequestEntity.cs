using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendProspectiveVendorRegistrationRequestEntityVocabulary : SimpleVocabulary
    {
        public VendProspectiveVendorRegistrationRequestEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendProspectiveVendorRegistrationRequestEntity";
            KeyPrefix = "commonDataModel.vendprospectivevendorregistrationrequestentity";
            KeySeparator = ".";
            Grouping = "/VendProspectiveVendorRegistrationRequestEntity";

            AddGroup("Common Data Model VendProspectiveVendorRegistrationRequestEntity Details", group =>
            {
                ContactPersonFirstName = group.Add(new VocabularyKey(nameof(ContactPersonFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonMiddleName = group.Add(new VocabularyKey(nameof(ContactPersonMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonLastName = group.Add(new VocabularyKey(nameof(ContactPersonLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyName = group.Add(new VocabularyKey(nameof(CompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessLineDescription = group.Add(new VocabularyKey(nameof(BusinessLineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessJustificationDescription = group.Add(new VocabularyKey(nameof(BusinessJustificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubmittedDate = group.Add(new VocabularyKey(nameof(SubmittedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessedDate = group.Add(new VocabularyKey(nameof(ProcessedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestState = group.Add(new VocabularyKey(nameof(RequestState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserRequestId = group.Add(new VocabularyKey(nameof(UserRequestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestCompany = group.Add(new VocabularyKey(nameof(RequestCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ContactPersonFirstName { get; private set; }
        public VocabularyKey ContactPersonMiddleName { get; private set; }
        public VocabularyKey ContactPersonLastName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey CompanyName { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
        public VocabularyKey BusinessLineDescription { get; private set; }
        public VocabularyKey BusinessJustificationDescription { get; private set; }
        public VocabularyKey SubmittedDate { get; private set; }
        public VocabularyKey ProcessedDate { get; private set; }
        public VocabularyKey RequestState { get; private set; }
        public VocabularyKey UserRequestId { get; private set; }
        public VocabularyKey RequestCompany { get; private set; }


    }
}