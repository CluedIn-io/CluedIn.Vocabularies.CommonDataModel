using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DomainAuthenticationVocabulary : SimpleVocabulary
    {
        public DomainAuthenticationVocabulary()
        {
            VocabularyName = "Domain Authentication";
            KeyPrefix = "commonDataModel.domainauthentication";
            KeySeparator = ".";
            Grouping = "/DomainAuthentication";

            AddGroup("DomainAuthentication Details", group =>
            {
                CreatedBy = group.Add(new VocabularyKey(nameof(CreatedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedBy = group.Add(new VocabularyKey(nameof(ModifiedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Emailhost1 = group.Add(new VocabularyKey(nameof(Emailhost1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Emailhost2 = group.Add(new VocabularyKey(nameof(Emailhost2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Emailkey1 = group.Add(new VocabularyKey(nameof(Emailkey1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Emailkey2 = group.Add(new VocabularyKey(nameof(Emailkey2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Emailkeysvalidationstatus = group.Add(new VocabularyKey(nameof(Emailkeysvalidationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Emailtyperecord1 = group.Add(new VocabularyKey(nameof(Emailtyperecord1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Emailtyperecord2 = group.Add(new VocabularyKey(nameof(Emailtyperecord2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Generateemailkeys = group.Add(new VocabularyKey(nameof(Generateemailkeys), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Generateformkeys = group.Add(new VocabularyKey(nameof(Generateformkeys), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Instructions = group.Add(new VocabularyKey(nameof(Instructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ownershipvalidationstatus = group.Add(new VocabularyKey(nameof(Ownershipvalidationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SetupDomainId = group.Add(new VocabularyKey(nameof(SetupDomainId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Txtkey = group.Add(new VocabularyKey(nameof(Txtkey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Txthostinstructions = group.Add(new VocabularyKey(nameof(Txthostinstructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Txttyperecord = group.Add(new VocabularyKey(nameof(Txttyperecord), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Validationdate = group.Add(new VocabularyKey(nameof(Validationdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationIDId = group.Add(new VocabularyKey(nameof(OrganizationIDId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ipinstructions = group.Add(new VocabularyKey(nameof(Ipinstructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ipslist = group.Add(new VocabularyKey(nameof(Ipslist), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Domainalignmentrequired = group.Add(new VocabularyKey(nameof(Domainalignmentrequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Generatedomainalignmentkeys = group.Add(new VocabularyKey(nameof(Generatedomainalignmentkeys), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Domalignrectype = group.Add(new VocabularyKey(nameof(Domalignrectype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Domalignrechost = group.Add(new VocabularyKey(nameof(Domalignrechost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Domalignrecvalue = group.Add(new VocabularyKey(nameof(Domalignrecvalue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlignedName = group.Add(new VocabularyKey(nameof(AlignedName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Domainalignmentvalidationstatus = group.Add(new VocabularyKey(nameof(Domainalignmentvalidationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedBy { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedBy { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Emailhost1 { get; private set; }
        public VocabularyKey Emailhost2 { get; private set; }
        public VocabularyKey Emailkey1 { get; private set; }
        public VocabularyKey Emailkey2 { get; private set; }
        public VocabularyKey Emailkeysvalidationstatus { get; private set; }
        public VocabularyKey Emailtyperecord1 { get; private set; }
        public VocabularyKey Emailtyperecord2 { get; private set; }
        public VocabularyKey Generateemailkeys { get; private set; }
        public VocabularyKey Generateformkeys { get; private set; }
        public VocabularyKey Instructions { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Ownershipvalidationstatus { get; private set; }
        public VocabularyKey SetupDomainId { get; private set; }
        public VocabularyKey Txtkey { get; private set; }
        public VocabularyKey Txthostinstructions { get; private set; }
        public VocabularyKey Txttyperecord { get; private set; }
        public VocabularyKey Validationdate { get; private set; }
        public VocabularyKey OrganizationIDId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Ipinstructions { get; private set; }
        public VocabularyKey Ipslist { get; private set; }
        public VocabularyKey Domainalignmentrequired { get; private set; }
        public VocabularyKey Generatedomainalignmentkeys { get; private set; }
        public VocabularyKey Domalignrectype { get; private set; }
        public VocabularyKey Domalignrechost { get; private set; }
        public VocabularyKey Domalignrecvalue { get; private set; }
        public VocabularyKey AlignedName { get; private set; }
        public VocabularyKey Domainalignmentvalidationstatus { get; private set; }
    }
}