using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanActivityPerformerVocabulary : SimpleVocabulary
    {
        public CarePlanActivityPerformerVocabulary()
        {
            VocabularyName = "Care Plan Activity Performer";
            KeyPrefix = "commonDataModel.careplanactivityperformer.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanActivityPerformer";

            AddGroup("CarePlanActivityPerformer Details for ElectronicMedicalRecords", group =>
            {
			    ActivityPerformerType = group.Add(new VocabularyKey(nameof(ActivityPerformerType), "Activity Performer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CarePlanActivityPerformerId = group.Add(new VocabularyKey(nameof(CarePlanActivityPerformerId), "Care Plan Activity Performer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActivityPerformerType { get; private set; }
        public VocabularyKey CarePlanActivityPerformerId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}