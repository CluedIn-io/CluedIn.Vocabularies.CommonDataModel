using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LegalRepresentativeEntityVocabulary : SimpleVocabulary
    {
        public LegalRepresentativeEntityVocabulary()
        {
            VocabularyName = "Legal Representative Entity";
            KeyPrefix = "commonDataModel.legalrepresentativeentity";
            KeySeparator = ".";
            Grouping = "/LegalRepresentativeEntity";

            AddGroup("LegalRepresentativeEntity Details", group =>
            {
                FiscalOrganization = group.Add(new VocabularyKey(nameof(FiscalOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOrganizationRootFiscalEstablishmentDataArea = group.Add(new VocabularyKey(nameof(FiscalOrganizationRootFiscalEstablishmentDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOrganizationRootFiscalEstablishment = group.Add(new VocabularyKey(nameof(FiscalOrganizationRootFiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CPF = group.Add(new VocabularyKey(nameof(CPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatedInRFBAuthority = group.Add(new VocabularyKey(nameof(ValidatedInRFBAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CRCState = group.Add(new VocabularyKey(nameof(CRCState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CRC = group.Add(new VocabularyKey(nameof(CRC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CRCExpirationDate = group.Add(new VocabularyKey(nameof(CRCExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FiscalOrganization { get; private set; }
        public VocabularyKey FiscalOrganizationRootFiscalEstablishmentDataArea { get; private set; }
        public VocabularyKey FiscalOrganizationRootFiscalEstablishment { get; private set; }
        public VocabularyKey CPF { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey ValidatedInRFBAuthority { get; private set; }
        public VocabularyKey CRCState { get; private set; }
        public VocabularyKey CRC { get; private set; }
        public VocabularyKey CRCExpirationDate { get; private set; }
    }
}