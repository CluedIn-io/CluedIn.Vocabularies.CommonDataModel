using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationAdministrationVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationVocabulary()
        {
            VocabularyName = "Medication Administration";
            KeyPrefix = "commonDataModel.medicationadministration.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationAdministration";

            AddGroup("MedicationAdministration Details for ElectronicMedicalRecords", group =>
            {
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DosageDose = group.Add(new VocabularyKey(nameof(DosageDose), "Dosage Dose", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DosageRateQuantity = group.Add(new VocabularyKey(nameof(DosageRateQuantity), "Dosage Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DosageRateType = group.Add(new VocabularyKey(nameof(DosageRateType), "Dosage Rate Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DosageText = group.Add(new VocabularyKey(nameof(DosageText), "Dosage Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveDateTime = group.Add(new VocabularyKey(nameof(EffectiveDateTime), "Effective Date time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectivePeriodEndDate = group.Add(new VocabularyKey(nameof(EffectivePeriodEndDate), "Effective Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectivePeriodStartDate = group.Add(new VocabularyKey(nameof(EffectivePeriodStartDate), "Effective Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveType = group.Add(new VocabularyKey(nameof(EffectiveType), "Effective Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationAdministrationId = group.Add(new VocabularyKey(nameof(MedicationAdministrationId), "Medication Administration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationAdministrationNumber = group.Add(new VocabularyKey(nameof(MedicationAdministrationNumber), "Medication Administration Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicationType = group.Add(new VocabularyKey(nameof(MedicationType), "Medication Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotGiven = group.Add(new VocabularyKey(nameof(NotGiven), "Not Given", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityDenominatorComparator = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorComparator), "Ratio Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityDenominatorUnit = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorUnit), "Ratio Denominator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityDenominatorValue = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorValue), "Ratio Denominator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorComparator = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorComparator), "Ratio Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorSystem = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorSystem), "Ratio Numerator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorUnit = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorUnit), "Ratio Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorValue = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorValue), "Ratio Numerator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RateRatiotQuantityDenominatorSystem = group.Add(new VocabularyKey(nameof(RateRatiotQuantityDenominatorSystem), "Ratio Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey DosageDose { get; private set; }
        public VocabularyKey DosageRateQuantity { get; private set; }
        public VocabularyKey DosageRateType { get; private set; }
        public VocabularyKey DosageText { get; private set; }
        public VocabularyKey EffectiveDateTime { get; private set; }
        public VocabularyKey EffectivePeriodEndDate { get; private set; }
        public VocabularyKey EffectivePeriodStartDate { get; private set; }
        public VocabularyKey EffectiveType { get; private set; }
        public VocabularyKey MedicationAdministrationId { get; private set; }
        public VocabularyKey MedicationAdministrationNumber { get; private set; }
        public VocabularyKey MedicationType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotGiven { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorComparator { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorUnit { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorValue { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorComparator { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorSystem { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorUnit { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorValue { get; private set; }
        public VocabularyKey RateRatiotQuantityDenominatorSystem { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}