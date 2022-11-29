using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanActivityOutcomeVocabulary : SimpleVocabulary
    {
        public CarePlanActivityOutcomeVocabulary()
        {
            VocabularyName = "Care Plan Activity Outcome";
            KeyPrefix = "commonDataModel.careplanactivityoutcome.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanActivityOutcome";

            AddGroup("CarePlanActivityOutcome Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanActivityOutcomeId = group.Add(new VocabularyKey(nameof(CarePlanActivityOutcomeId), "Care Plan Activity Outcome", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanActivityOutcomeId { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}