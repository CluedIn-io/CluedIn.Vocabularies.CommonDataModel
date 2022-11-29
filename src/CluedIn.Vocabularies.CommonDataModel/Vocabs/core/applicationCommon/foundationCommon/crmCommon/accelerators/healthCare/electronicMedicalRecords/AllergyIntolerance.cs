using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AllergyIntoleranceVocabulary : SimpleVocabulary
    {
        public AllergyIntoleranceVocabulary()
        {
            VocabularyName = "Allergy Intolerance";
            KeyPrefix = "commonDataModel.allergyintolerance.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/AllergyIntolerance";

            AddGroup("AllergyIntolerance Details for ElectronicMedicalRecords", group =>
            {
			    AllergyIntoleranceId = group.Add(new VocabularyKey(nameof(AllergyIntoleranceId), "Allergy Intolerance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Criticality = group.Add(new VocabularyKey(nameof(Criticality), "Criticality", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VerificationStatus = group.Add(new VocabularyKey(nameof(VerificationStatus), "Verification Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AllergyIntoleranceId { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Criticality { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey VerificationStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}