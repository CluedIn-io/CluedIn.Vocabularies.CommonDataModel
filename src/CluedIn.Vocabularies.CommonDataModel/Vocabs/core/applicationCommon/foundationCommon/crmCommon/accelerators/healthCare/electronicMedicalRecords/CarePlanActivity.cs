using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanActivityVocabulary : SimpleVocabulary
    {
        public CarePlanActivityVocabulary()
        {
            VocabularyName = "Care Plan Activity";
            KeyPrefix = "commonDataModel.careplanactivity.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanActivity";

            AddGroup("CarePlanActivity Details for ElectronicMedicalRecords", group =>
            {
			    ActivityDailyAmount = group.Add(new VocabularyKey(nameof(ActivityDailyAmount), "Daily Amount", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActivityDefinitionType = group.Add(new VocabularyKey(nameof(ActivityDefinitionType), "Activity Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityDescription = group.Add(new VocabularyKey(nameof(ActivityDescription), "Activity Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityEndDate = group.Add(new VocabularyKey(nameof(ActivityEndDate), "Activity End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityIdentifier = group.Add(new VocabularyKey(nameof(ActivityIdentifier), "Activity ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityProductReferenceType = group.Add(new VocabularyKey(nameof(ActivityProductReferenceType), "Product Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityProductType = group.Add(new VocabularyKey(nameof(ActivityProductType), "Activity Product Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityProhibited = group.Add(new VocabularyKey(nameof(ActivityProhibited), "Activity Prohibited", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ActivityQuantity = group.Add(new VocabularyKey(nameof(ActivityQuantity), "Activity Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActivityReferenceType = group.Add(new VocabularyKey(nameof(ActivityReferenceType), "Activity Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityScheduledType = group.Add(new VocabularyKey(nameof(ActivityScheduledType), "Activity Scheduled Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityStartDate = group.Add(new VocabularyKey(nameof(ActivityStartDate), "Activity Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityStatus = group.Add(new VocabularyKey(nameof(ActivityStatus), "Activity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityStatusReason = group.Add(new VocabularyKey(nameof(ActivityStatusReason), "Reason Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityString = group.Add(new VocabularyKey(nameof(ActivityString), "Activity String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CarePlanActivityId = group.Add(new VocabularyKey(nameof(CarePlanActivityId), "Care Plan Activity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmrstatusCode = group.Add(new VocabularyKey(nameof(EmrstatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActivityDailyAmount { get; private set; }
        public VocabularyKey ActivityDefinitionType { get; private set; }
        public VocabularyKey ActivityDescription { get; private set; }
        public VocabularyKey ActivityEndDate { get; private set; }
        public VocabularyKey ActivityIdentifier { get; private set; }
        public VocabularyKey ActivityProductReferenceType { get; private set; }
        public VocabularyKey ActivityProductType { get; private set; }
        public VocabularyKey ActivityProhibited { get; private set; }
        public VocabularyKey ActivityQuantity { get; private set; }
        public VocabularyKey ActivityReferenceType { get; private set; }
        public VocabularyKey ActivityScheduledType { get; private set; }
        public VocabularyKey ActivityStartDate { get; private set; }
        public VocabularyKey ActivityStatus { get; private set; }
        public VocabularyKey ActivityStatusReason { get; private set; }
        public VocabularyKey ActivityString { get; private set; }
        public VocabularyKey CarePlanActivityId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmrstatusCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}