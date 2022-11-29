using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestVocabulary : SimpleVocabulary
    {
        public MedicationRequestVocabulary()
        {
            VocabularyName = "Medication Request";
            KeyPrefix = "commonDataModel.medicationrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequest";

            AddGroup("MedicationRequest Details for ElectronicMedicalRecords", group =>
            {
			    AuthoredOn = group.Add(new VocabularyKey(nameof(AuthoredOn), "Authored On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DispenseRequestNumberOfRepeatsAllowed = group.Add(new VocabularyKey(nameof(DispenseRequestNumberOfRepeatsAllowed), "Dispense Request Number of Repeats Allowed", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DispenseRequestQuantity = group.Add(new VocabularyKey(nameof(DispenseRequestQuantity), "Dispense Request Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DispenseRequestValidityPeriodEndDate = group.Add(new VocabularyKey(nameof(DispenseRequestValidityPeriodEndDate), "Dispense Request Validity Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DispenseRequestValidityPeriodStartDate = group.Add(new VocabularyKey(nameof(DispenseRequestValidityPeriodStartDate), "Dispense Request Validity Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedSupplyDuration = group.Add(new VocabularyKey(nameof(ExpectedSupplyDuration), "Expected Supply Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GroupIdentifier = group.Add(new VocabularyKey(nameof(GroupIdentifier), "Group Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Identifier = group.Add(new VocabularyKey(nameof(Identifier), "Medication Request Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Intent = group.Add(new VocabularyKey(nameof(Intent), "Intent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationRequestId = group.Add(new VocabularyKey(nameof(MedicationRequestId), "Medication Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationType = group.Add(new VocabularyKey(nameof(MedicationType), "Medication Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequesterAgentType = group.Add(new VocabularyKey(nameof(RequesterAgentType), "Requester Agent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubstitutionAllowed = group.Add(new VocabularyKey(nameof(SubstitutionAllowed), "Substitution Allowed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AuthoredOn { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey DispenseRequestNumberOfRepeatsAllowed { get; private set; }
        public VocabularyKey DispenseRequestQuantity { get; private set; }
        public VocabularyKey DispenseRequestValidityPeriodEndDate { get; private set; }
        public VocabularyKey DispenseRequestValidityPeriodStartDate { get; private set; }
        public VocabularyKey ExpectedSupplyDuration { get; private set; }
        public VocabularyKey GroupIdentifier { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey Intent { get; private set; }
        public VocabularyKey MedicationRequestId { get; private set; }
        public VocabularyKey MedicationType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey RequesterAgentType { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey SubstitutionAllowed { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}