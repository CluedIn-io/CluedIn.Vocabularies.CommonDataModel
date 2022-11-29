using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerQualificationVocabulary : SimpleVocabulary
    {
        public PractitionerQualificationVocabulary()
        {
            VocabularyName = "Practitioner Qualification";
            KeyPrefix = "commonDataModel.practitionerqualification.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerQualification";

            AddGroup("PractitionerQualification Details for ElectronicMedicalRecords", group =>
            {
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeSystem = group.Add(new VocabularyKey(nameof(CodeSystem), "Code System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeVersion = group.Add(new VocabularyKey(nameof(CodeVersion), "Code Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), "Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), "Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerQualificationId = group.Add(new VocabularyKey(nameof(PractitionerQualificationId), "Practitioner Qualification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProviderNPINumber = group.Add(new VocabularyKey(nameof(ProviderNPINumber), "Provider NPI Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey CodeSystem { get; private set; }
        public VocabularyKey CodeVersion { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey PractitionerQualificationId { get; private set; }
        public VocabularyKey ProviderNPINumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}