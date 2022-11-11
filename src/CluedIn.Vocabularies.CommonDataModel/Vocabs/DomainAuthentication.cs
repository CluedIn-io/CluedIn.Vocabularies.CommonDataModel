using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DomainAuthenticationVocabulary : SimpleVocabulary
    {
        public DomainAuthenticationVocabulary()
        {
            VocabularyName = "DomainAuthentication";
            KeyPrefix = "commonDataModel.domainauthentication";
            KeySeparator = ".";
            Grouping = "/DomainAuthentication";

            AddGroup("DomainAuthentication Details", group =>
            {
                createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailhost1 = group.Add(new VocabularyKey(nameof(emailhost1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailhost2 = group.Add(new VocabularyKey(nameof(emailhost2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailkey1 = group.Add(new VocabularyKey(nameof(emailkey1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailkey2 = group.Add(new VocabularyKey(nameof(emailkey2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailkeysvalidationstatus = group.Add(new VocabularyKey(nameof(emailkeysvalidationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailtyperecord1 = group.Add(new VocabularyKey(nameof(emailtyperecord1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailtyperecord2 = group.Add(new VocabularyKey(nameof(emailtyperecord2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                generateemailkeys = group.Add(new VocabularyKey(nameof(generateemailkeys), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                generateformkeys = group.Add(new VocabularyKey(nameof(generateformkeys), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                instructions = group.Add(new VocabularyKey(nameof(instructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownershipvalidationstatus = group.Add(new VocabularyKey(nameof(ownershipvalidationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                setupDomainId = group.Add(new VocabularyKey(nameof(setupDomainId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                txtkey = group.Add(new VocabularyKey(nameof(txtkey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                txthostinstructions = group.Add(new VocabularyKey(nameof(txthostinstructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                txttyperecord = group.Add(new VocabularyKey(nameof(txttyperecord), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validationdate = group.Add(new VocabularyKey(nameof(validationdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                organizationIDId = group.Add(new VocabularyKey(nameof(organizationIDId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ipinstructions = group.Add(new VocabularyKey(nameof(ipinstructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ipslist = group.Add(new VocabularyKey(nameof(ipslist), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                domainalignmentrequired = group.Add(new VocabularyKey(nameof(domainalignmentrequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                generatedomainalignmentkeys = group.Add(new VocabularyKey(nameof(generatedomainalignmentkeys), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                domalignrectype = group.Add(new VocabularyKey(nameof(domalignrectype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                domalignrechost = group.Add(new VocabularyKey(nameof(domalignrechost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                domalignrecvalue = group.Add(new VocabularyKey(nameof(domalignrecvalue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                alignedName = group.Add(new VocabularyKey(nameof(alignedName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                domainalignmentvalidationstatus = group.Add(new VocabularyKey(nameof(domainalignmentvalidationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdBy { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey modifiedBy { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey emailhost1 { get; private set; }
        public VocabularyKey emailhost2 { get; private set; }
        public VocabularyKey emailkey1 { get; private set; }
        public VocabularyKey emailkey2 { get; private set; }
        public VocabularyKey emailkeysvalidationstatus { get; private set; }
        public VocabularyKey emailtyperecord1 { get; private set; }
        public VocabularyKey emailtyperecord2 { get; private set; }
        public VocabularyKey generateemailkeys { get; private set; }
        public VocabularyKey generateformkeys { get; private set; }
        public VocabularyKey instructions { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey ownershipvalidationstatus { get; private set; }
        public VocabularyKey setupDomainId { get; private set; }
        public VocabularyKey txtkey { get; private set; }
        public VocabularyKey txthostinstructions { get; private set; }
        public VocabularyKey txttyperecord { get; private set; }
        public VocabularyKey validationdate { get; private set; }
        public VocabularyKey organizationIDId { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey ipinstructions { get; private set; }
        public VocabularyKey ipslist { get; private set; }
        public VocabularyKey domainalignmentrequired { get; private set; }
        public VocabularyKey generatedomainalignmentkeys { get; private set; }
        public VocabularyKey domalignrectype { get; private set; }
        public VocabularyKey domalignrechost { get; private set; }
        public VocabularyKey domalignrecvalue { get; private set; }
        public VocabularyKey alignedName { get; private set; }
        public VocabularyKey domainalignmentvalidationstatus { get; private set; }


    }
}