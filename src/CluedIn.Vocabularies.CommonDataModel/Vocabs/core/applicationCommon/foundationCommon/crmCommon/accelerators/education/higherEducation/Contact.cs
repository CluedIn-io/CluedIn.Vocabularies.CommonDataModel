using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.highereducation";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for HigherEducation", group =>
            {
			    ContactType = group.Add(new VocabularyKey(nameof(ContactType), "Contact Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CountryofBirth = group.Add(new VocabularyKey(nameof(CountryofBirth), "Country of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EthnicGroup = group.Add(new VocabularyKey(nameof(EthnicGroup), "Ethnic Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FERPAPrivacy = group.Add(new VocabularyKey(nameof(FERPAPrivacy), "FERPA Privacy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    FirstGeneration = group.Add(new VocabularyKey(nameof(FirstGeneration), "First Generation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    HIPAAIndicator = group.Add(new VocabularyKey(nameof(HIPAAIndicator), "HIPAA Indicator", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsDeceased = group.Add(new VocabularyKey(nameof(IsDeceased), "Is Deceased?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastPermanentResidenceCountry = group.Add(new VocabularyKey(nameof(LastPermanentResidenceCountry), "Last Permanent Residence Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Legacy = group.Add(new VocabularyKey(nameof(Legacy), "Legacy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MaidenName = group.Add(new VocabularyKey(nameof(MaidenName), "Maiden Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ManualRiskScore = group.Add(new VocabularyKey(nameof(ManualRiskScore), "Manual Risk Score", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiltaryStatus = group.Add(new VocabularyKey(nameof(MiltaryStatus), "Miltary Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NationalIdentifier = group.Add(new VocabularyKey(nameof(NationalIdentifier), "National Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Nationality = group.Add(new VocabularyKey(nameof(Nationality), "Nationality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Race = group.Add(new VocabularyKey(nameof(Race), "Race", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ContactType { get; private set; }
        public VocabularyKey CountryofBirth { get; private set; }
        public VocabularyKey EthnicGroup { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey FERPAPrivacy { get; private set; }
        public VocabularyKey FirstGeneration { get; private set; }
        public VocabularyKey HIPAAIndicator { get; private set; }
        public VocabularyKey IsDeceased { get; private set; }
        public VocabularyKey LastPermanentResidenceCountry { get; private set; }
        public VocabularyKey Legacy { get; private set; }
        public VocabularyKey MaidenName { get; private set; }
        public VocabularyKey ManualRiskScore { get; private set; }
        public VocabularyKey MiltaryStatus { get; private set; }
        public VocabularyKey NationalIdentifier { get; private set; }
        public VocabularyKey Nationality { get; private set; }
        public VocabularyKey Race { get; private set; }
    }
}