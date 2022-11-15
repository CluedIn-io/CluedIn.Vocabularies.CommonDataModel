using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LegalRepresentativeContactEntityVocabulary : SimpleVocabulary
    {
        public LegalRepresentativeContactEntityVocabulary()
        {
            VocabularyName = "Legal Representative Contact Entity";
            KeyPrefix = "commonDataModel.legalrepresentativecontactentity";
            KeySeparator = ".";
            Grouping = "/LegalRepresentativeContactEntity";

            AddGroup("LegalRepresentativeContactEntity Details", group =>
            {
                FiscalOrganizationRootFiscalEstablishmentDataArea = group.Add(new VocabularyKey(nameof(FiscalOrganizationRootFiscalEstablishmentDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOrganizationRootFiscalEstablishment = group.Add(new VocabularyKey(nameof(FiscalOrganizationRootFiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalRepresentativeCPF = group.Add(new VocabularyKey(nameof(LegalRepresentativeCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalRepresentativeRole = group.Add(new VocabularyKey(nameof(LegalRepresentativeRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactNumberOrAddress = group.Add(new VocabularyKey(nameof(ContactNumberOrAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Extension = group.Add(new VocabularyKey(nameof(Extension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternationalCallingCode = group.Add(new VocabularyKey(nameof(InternationalCallingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMobilePhone = group.Add(new VocabularyKey(nameof(IsMobilePhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInstantMessage = group.Add(new VocabularyKey(nameof(IsInstantMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrivate = group.Add(new VocabularyKey(nameof(IsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FiscalOrganizationRootFiscalEstablishmentDataArea { get; private set; }
        public VocabularyKey FiscalOrganizationRootFiscalEstablishment { get; private set; }
        public VocabularyKey LegalRepresentativeCPF { get; private set; }
        public VocabularyKey LegalRepresentativeRole { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey ContactNumberOrAddress { get; private set; }
        public VocabularyKey Extension { get; private set; }
        public VocabularyKey InternationalCallingCode { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey IsMobilePhone { get; private set; }
        public VocabularyKey IsInstantMessage { get; private set; }
        public VocabularyKey IsPrivate { get; private set; }
    }
}