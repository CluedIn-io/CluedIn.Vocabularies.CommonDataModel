using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanVocabulary : SimpleVocabulary
    {
        public CarePlanVocabulary()
        {
            VocabularyName = "Care Plan";
            KeyPrefix = "commonDataModel.careplan.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlan";

            AddGroup("CarePlan Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanId = group.Add(new VocabularyKey(nameof(CarePlanId), "Care Plan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CarePlanIdentifier = group.Add(new VocabularyKey(nameof(CarePlanIdentifier), "Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanDescription = group.Add(new VocabularyKey(nameof(PlanDescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanEndDate = group.Add(new VocabularyKey(nameof(PlanEndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanIntent = group.Add(new VocabularyKey(nameof(PlanIntent), "Intent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanStartDate = group.Add(new VocabularyKey(nameof(PlanStartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanStatus = group.Add(new VocabularyKey(nameof(PlanStatus), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanId { get; private set; }
        public VocabularyKey CarePlanIdentifier { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey PlanDescription { get; private set; }
        public VocabularyKey PlanEndDate { get; private set; }
        public VocabularyKey PlanIntent { get; private set; }
        public VocabularyKey PlanStartDate { get; private set; }
        public VocabularyKey PlanStatus { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}