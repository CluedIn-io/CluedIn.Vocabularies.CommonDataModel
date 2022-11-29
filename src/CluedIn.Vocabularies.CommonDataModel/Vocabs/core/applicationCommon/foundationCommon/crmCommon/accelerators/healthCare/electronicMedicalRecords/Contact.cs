using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for ElectronicMedicalRecords", group =>
            {
			    FamilyStatusCode = group.Add(new VocabularyKey(nameof(FamilyStatusCode), "Marital Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GenderCode = group.Add(new VocabularyKey(nameof(GenderCode), "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityStartDate = group.Add(new VocabularyKey(nameof(ActivityStartDate), "Activity Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodEndDate = group.Add(new VocabularyKey(nameof(Address1PeriodEndDate), "Permanent - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodStartDate = group.Add(new VocabularyKey(nameof(Address1PeriodStartDate), "Permanent- Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodEndDate = group.Add(new VocabularyKey(nameof(Address2PeriodEndDate), "Current - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodStartDate = group.Add(new VocabularyKey(nameof(Address2PeriodStartDate), "Current - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address3PeriodEndDate = group.Add(new VocabularyKey(nameof(Address3PeriodEndDate), "Billing  - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address3PeriodStartDate = group.Add(new VocabularyKey(nameof(Address3PeriodStartDate), "Billing  - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Animal = group.Add(new VocabularyKey(nameof(Animal), "Animal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Communication1Preferred = group.Add(new VocabularyKey(nameof(Communication1Preferred), "Primary Language Preferred", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Communication2Preferred = group.Add(new VocabularyKey(nameof(Communication2Preferred), "Secondary Language Preferred", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Contac1tEndDate = group.Add(new VocabularyKey(nameof(Contac1tEndDate), "Emergency Contact End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contac2tEndDate = group.Add(new VocabularyKey(nameof(Contac2tEndDate), "Primary Contact End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contact1StartDate = group.Add(new VocabularyKey(nameof(Contact1StartDate), "Emergency Contact Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Contact2StartDate = group.Add(new VocabularyKey(nameof(Contact2StartDate), "Primary Contact Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactType = group.Add(new VocabularyKey(nameof(ContactType), "Contact Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedDate = group.Add(new VocabularyKey(nameof(DeceasedDate), "Deceased Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicalRecordNumber = group.Add(new VocabularyKey(nameof(MedicalRecordNumber), "Medical Record Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MultipleBirth = group.Add(new VocabularyKey(nameof(MultipleBirth), "Multiple Birth", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name1EndDate = group.Add(new VocabularyKey(nameof(Name1EndDate), "Usual-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name1StartDate = group.Add(new VocabularyKey(nameof(Name1StartDate), "Usual-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name1Use = group.Add(new VocabularyKey(nameof(Name1Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2 = group.Add(new VocabularyKey(nameof(Name2), "Official Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2EndDate = group.Add(new VocabularyKey(nameof(Name2EndDate), "Official-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2FamilyName = group.Add(new VocabularyKey(nameof(Name2FamilyName), "Official- Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2GivenName = group.Add(new VocabularyKey(nameof(Name2GivenName), "Official - Given Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Prefix = group.Add(new VocabularyKey(nameof(Name2Prefix), "Official- Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2StartDate = group.Add(new VocabularyKey(nameof(Name2StartDate), "Official-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Suffix = group.Add(new VocabularyKey(nameof(Name2Suffix), "Official- Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name2Use = group.Add(new VocabularyKey(nameof(Name2Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3 = group.Add(new VocabularyKey(nameof(Name3), "Temporary Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3FamilyName = group.Add(new VocabularyKey(nameof(Name3FamilyName), "Official- Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3GivenName = group.Add(new VocabularyKey(nameof(Name3GivenName), "Official - Given Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3NameEndDate = group.Add(new VocabularyKey(nameof(Name3NameEndDate), "Official-Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3NameStartDate = group.Add(new VocabularyKey(nameof(Name3NameStartDate), "Official-Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Prefix = group.Add(new VocabularyKey(nameof(Name3Prefix), "Official- Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Suffix = group.Add(new VocabularyKey(nameof(Name3Suffix), "Official- Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name3Use = group.Add(new VocabularyKey(nameof(Name3Use), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1Identifier = group.Add(new VocabularyKey(nameof(Qualification1Identifier), "Provider NPI Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1PeriodEndDate = group.Add(new VocabularyKey(nameof(Qualification1PeriodEndDate), "Qualification Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualification1PeriodStartDate = group.Add(new VocabularyKey(nameof(Qualification1PeriodStartDate), "Qualification Issue Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1EndDate = group.Add(new VocabularyKey(nameof(Telecom1EndDate), "Primary Day Time Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Rank = group.Add(new VocabularyKey(nameof(Telecom1Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom1StartDate = group.Add(new VocabularyKey(nameof(Telecom1StartDate), "Primary Day Time Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1System = group.Add(new VocabularyKey(nameof(Telecom1System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Use = group.Add(new VocabularyKey(nameof(Telecom1Use), "Use of contact point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2EndDate = group.Add(new VocabularyKey(nameof(Telecom2EndDate), "Primary Evening Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Rank = group.Add(new VocabularyKey(nameof(Telecom2Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom2StartDate = group.Add(new VocabularyKey(nameof(Telecom2StartDate), "Primary Evening Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2System = group.Add(new VocabularyKey(nameof(Telecom2System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Use = group.Add(new VocabularyKey(nameof(Telecom2Use), "Use of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3EndDate = group.Add(new VocabularyKey(nameof(Telecom3EndDate), "Primary Email End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Rank = group.Add(new VocabularyKey(nameof(Telecom3Rank), "Rank of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom3StartDate = group.Add(new VocabularyKey(nameof(Telecom3StartDate), "Primary Email Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3System = group.Add(new VocabularyKey(nameof(Telecom3System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Use = group.Add(new VocabularyKey(nameof(Telecom3Use), "Use of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FamilyStatusCode { get; private set; }
        public VocabularyKey GenderCode { get; private set; }
        public VocabularyKey ActivityStartDate { get; private set; }
        public VocabularyKey Address1PeriodEndDate { get; private set; }
        public VocabularyKey Address1PeriodStartDate { get; private set; }
        public VocabularyKey Address2PeriodEndDate { get; private set; }
        public VocabularyKey Address2PeriodStartDate { get; private set; }
        public VocabularyKey Address3PeriodEndDate { get; private set; }
        public VocabularyKey Address3PeriodStartDate { get; private set; }
        public VocabularyKey Animal { get; private set; }
        public VocabularyKey Communication1Preferred { get; private set; }
        public VocabularyKey Communication2Preferred { get; private set; }
        public VocabularyKey Contac1tEndDate { get; private set; }
        public VocabularyKey Contac2tEndDate { get; private set; }
        public VocabularyKey Contact1StartDate { get; private set; }
        public VocabularyKey Contact2StartDate { get; private set; }
        public VocabularyKey ContactType { get; private set; }
        public VocabularyKey DeceasedDate { get; private set; }
        public VocabularyKey MedicalRecordNumber { get; private set; }
        public VocabularyKey MultipleBirth { get; private set; }
        public VocabularyKey Name1EndDate { get; private set; }
        public VocabularyKey Name1StartDate { get; private set; }
        public VocabularyKey Name1Use { get; private set; }
        public VocabularyKey Name2 { get; private set; }
        public VocabularyKey Name2EndDate { get; private set; }
        public VocabularyKey Name2FamilyName { get; private set; }
        public VocabularyKey Name2GivenName { get; private set; }
        public VocabularyKey Name2Prefix { get; private set; }
        public VocabularyKey Name2StartDate { get; private set; }
        public VocabularyKey Name2Suffix { get; private set; }
        public VocabularyKey Name2Use { get; private set; }
        public VocabularyKey Name3 { get; private set; }
        public VocabularyKey Name3FamilyName { get; private set; }
        public VocabularyKey Name3GivenName { get; private set; }
        public VocabularyKey Name3NameEndDate { get; private set; }
        public VocabularyKey Name3NameStartDate { get; private set; }
        public VocabularyKey Name3Prefix { get; private set; }
        public VocabularyKey Name3Suffix { get; private set; }
        public VocabularyKey Name3Use { get; private set; }
        public VocabularyKey Qualification1Identifier { get; private set; }
        public VocabularyKey Qualification1PeriodEndDate { get; private set; }
        public VocabularyKey Qualification1PeriodStartDate { get; private set; }
        public VocabularyKey Telecom1EndDate { get; private set; }
        public VocabularyKey Telecom1Rank { get; private set; }
        public VocabularyKey Telecom1StartDate { get; private set; }
        public VocabularyKey Telecom1System { get; private set; }
        public VocabularyKey Telecom1Use { get; private set; }
        public VocabularyKey Telecom2EndDate { get; private set; }
        public VocabularyKey Telecom2Rank { get; private set; }
        public VocabularyKey Telecom2StartDate { get; private set; }
        public VocabularyKey Telecom2System { get; private set; }
        public VocabularyKey Telecom2Use { get; private set; }
        public VocabularyKey Telecom3EndDate { get; private set; }
        public VocabularyKey Telecom3Rank { get; private set; }
        public VocabularyKey Telecom3StartDate { get; private set; }
        public VocabularyKey Telecom3System { get; private set; }
        public VocabularyKey Telecom3Use { get; private set; }
    }
}