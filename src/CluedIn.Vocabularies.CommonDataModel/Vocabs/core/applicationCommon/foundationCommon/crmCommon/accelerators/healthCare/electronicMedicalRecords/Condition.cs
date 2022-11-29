using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ConditionVocabulary : SimpleVocabulary
    {
        public ConditionVocabulary()
        {
            VocabularyName = "Condition";
            KeyPrefix = "commonDataModel.condition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Condition";

            AddGroup("Condition Details for ElectronicMedicalRecords", group =>
            {
			    AbatementAge = group.Add(new VocabularyKey(nameof(AbatementAge), "Abatement Age", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AbatementDate = group.Add(new VocabularyKey(nameof(AbatementDate), "Abatement Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementPeriodEndDate = group.Add(new VocabularyKey(nameof(AbatementPeriodEndDate), "Abatement Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementPeriodStartDate = group.Add(new VocabularyKey(nameof(AbatementPeriodStartDate), "Abatement Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementRangeHigh = group.Add(new VocabularyKey(nameof(AbatementRangeHigh), "Abatement Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AbatementRangeLow = group.Add(new VocabularyKey(nameof(AbatementRangeLow), "Abatement Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AbatementString = group.Add(new VocabularyKey(nameof(AbatementString), "Abatement String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AbatementType = group.Add(new VocabularyKey(nameof(AbatementType), "Abatement Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssertedDate = group.Add(new VocabularyKey(nameof(AssertedDate), "Asserted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClinicalStatus = group.Add(new VocabularyKey(nameof(ClinicalStatus), "Clinical Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConditionId = group.Add(new VocabularyKey(nameof(ConditionId), "Condition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsAbatement = group.Add(new VocabularyKey(nameof(IsAbatement), "Is Abatement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetAge = group.Add(new VocabularyKey(nameof(OnsetAge), "Onset Age", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    OnsetDate = group.Add(new VocabularyKey(nameof(OnsetDate), "Onset Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetPeriodEndDate = group.Add(new VocabularyKey(nameof(OnsetPeriodEndDate), "Onset Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetPeriodStartDate = group.Add(new VocabularyKey(nameof(OnsetPeriodStartDate), "Onset Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetRangeHigh = group.Add(new VocabularyKey(nameof(OnsetRangeHigh), "Onset Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OnsetRangeLow = group.Add(new VocabularyKey(nameof(OnsetRangeLow), "Onset Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OnsetString = group.Add(new VocabularyKey(nameof(OnsetString), "Onset String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnsetType = group.Add(new VocabularyKey(nameof(OnsetType), "Onset Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VerificationStatus = group.Add(new VocabularyKey(nameof(VerificationStatus), "Verification Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AbatementAge { get; private set; }
        public VocabularyKey AbatementDate { get; private set; }
        public VocabularyKey AbatementPeriodEndDate { get; private set; }
        public VocabularyKey AbatementPeriodStartDate { get; private set; }
        public VocabularyKey AbatementRangeHigh { get; private set; }
        public VocabularyKey AbatementRangeLow { get; private set; }
        public VocabularyKey AbatementString { get; private set; }
        public VocabularyKey AbatementType { get; private set; }
        public VocabularyKey AssertedDate { get; private set; }
        public VocabularyKey ClinicalStatus { get; private set; }
        public VocabularyKey ConditionId { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey IsAbatement { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OnsetAge { get; private set; }
        public VocabularyKey OnsetDate { get; private set; }
        public VocabularyKey OnsetPeriodEndDate { get; private set; }
        public VocabularyKey OnsetPeriodStartDate { get; private set; }
        public VocabularyKey OnsetRangeHigh { get; private set; }
        public VocabularyKey OnsetRangeLow { get; private set; }
        public VocabularyKey OnsetString { get; private set; }
        public VocabularyKey OnsetType { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey VerificationStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}