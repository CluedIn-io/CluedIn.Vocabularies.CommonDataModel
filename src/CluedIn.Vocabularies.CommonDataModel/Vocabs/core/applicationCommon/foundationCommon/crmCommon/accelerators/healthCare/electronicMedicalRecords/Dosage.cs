using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DosageVocabulary : SimpleVocabulary
    {
        public DosageVocabulary()
        {
            VocabularyName = "Dosage";
            KeyPrefix = "commonDataModel.dosage";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Dosage;

            AddGroup("Dosage Details for ElectronicMedicalRecords", group =>
            {
                AsNeededType = group.Add(new VocabularyKey(nameof(AsNeededType), "As Needed Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AsNeededTypeBoolean = group.Add(new VocabularyKey(nameof(AsNeededTypeBoolean), "Boolean", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DosageId = group.Add(new VocabularyKey(nameof(DosageId), "Dosage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoseType = group.Add(new VocabularyKey(nameof(DoseType), "Dose Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoseTypeQuantity = group.Add(new VocabularyKey(nameof(DoseTypeQuantity), "Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DoseTypeRangeHigh = group.Add(new VocabularyKey(nameof(DoseTypeRangeHigh), "High Range", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DoseTypeRangeLow = group.Add(new VocabularyKey(nameof(DoseTypeRangeLow), "Low Range", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MaxDosePerAdministration = group.Add(new VocabularyKey(nameof(MaxDosePerAdministration), "Max Dose Per Administration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MaxDosePeriodRatioQtyDenominatorValue = group.Add(new VocabularyKey(nameof(MaxDosePeriodRatioQtyDenominatorValue), "Ratio Denominator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                MaxDosePeriodRatioQtyNumeratorComparator = group.Add(new VocabularyKey(nameof(MaxDosePeriodRatioQtyNumeratorComparator), "Ratio Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDosePeriodRatioQuantityDenominatorUnit = group.Add(new VocabularyKey(nameof(MaxDosePeriodRatioQuantityDenominatorUnit), "Ratio Denominator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDosePeriodRatioQuantityNumeratorSystem = group.Add(new VocabularyKey(nameof(MaxDosePeriodRatioQuantityNumeratorSystem), "Ratio Numerator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDosePeriodRatioQuantityNumeratorUnit = group.Add(new VocabularyKey(nameof(MaxDosePeriodRatioQuantityNumeratorUnit), "Ratio Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDosePeriodRatioQuantityNumeratorValue = group.Add(new VocabularyKey(nameof(MaxDosePeriodRatioQuantityNumeratorValue), "Ratio Numerator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                MaxDosePeriodRatiotQuantityDenominatorSys = group.Add(new VocabularyKey(nameof(MaxDosePeriodRatiotQuantityDenominatorSys), "Ratio Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDosePerLifetime = group.Add(new VocabularyKey(nameof(MaxDosePerLifetime), "Max Dose Per Lifetime", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MaxDosePrdRatioQtyDenominatorComparator = group.Add(new VocabularyKey(nameof(MaxDosePrdRatioQtyDenominatorComparator), "Ratio Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PatientInstruction = group.Add(new VocabularyKey(nameof(PatientInstruction), "Patient Instruction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateRatioQuantityDenominatorComparator = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorComparator), "Ratio Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateRatioQuantityDenominatorUnit = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorUnit), "Ratio Denominator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateRatioQuantityDenominatorValue = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorValue), "Ratio Denominator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RateRatioQuantityNumeratorComparator = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorComparator), "Ratio Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateRatioQuantityNumeratorSystem = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorSystem), "Ratio Numerator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateRatioQuantityNumeratorUnit = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorUnit), "Ratio Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateRatioQuantityNumeratorValue = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorValue), "Ratio Numerator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RateRatiotQuantityDenominatorSystem = group.Add(new VocabularyKey(nameof(RateRatiotQuantityDenominatorSystem), "Ratio Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateType = group.Add(new VocabularyKey(nameof(RateType), "Rate Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateTypeQuantity = group.Add(new VocabularyKey(nameof(RateTypeQuantity), "Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RateTypeRaangeLow = group.Add(new VocabularyKey(nameof(RateTypeRaangeLow), "Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RateTypeRangeHigh = group.Add(new VocabularyKey(nameof(RateTypeRangeHigh), "Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), "Sequence", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), "Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ActivityDefinitionId"/> to Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'IdentifiesspecifictimeswhentheeventoccuId'
            ///Property <see cref="DosageId"/> to Vocab 'Dosage.cdm.json/Dosage' with Property 'DosageId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="AsNeededTypeCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="MaxDosePeriodRatioQuantityDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="MaxDosePeriodRatioQuantityNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="MethodId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RateRatioQuantityDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RateRatioQuantityNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RouteId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SiteId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DosageAdditionalInstructionId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="DosageId"/> to Vocab 'Dosage.cdm.json/Dosage' with Property 'DosageId'
            ///Property <see cref="DosageId"/> to Vocab 'Dosage.cdm.json/Dosage' with Property 'DosageId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="MedicationRequestId"/> to Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'MedicationRequestId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="DosageId"/> from Vocab 'ActivityDefinitionDosage.cdm.json/ActivityDefinitionDosage' with Property 'DosageId'
            ///Property <see cref="DosageId"/> from Vocab 'DosageAddInstruction.cdm.json/DosageAddInstruction' with Property 'DosageId'
            ///Property <see cref="DosageId"/> from Vocab 'MedicationRequestDosageInstruction.cdm.json/MedicationRequestDosageInstruction' with Property 'DosageId'
            #endregion
        }

        public VocabularyKey AsNeededType { get; private set; }
        public VocabularyKey AsNeededTypeBoolean { get; private set; }
        public VocabularyKey DosageId { get; private set; }
        public VocabularyKey DoseType { get; private set; }
        public VocabularyKey DoseTypeQuantity { get; private set; }
        public VocabularyKey DoseTypeRangeHigh { get; private set; }
        public VocabularyKey DoseTypeRangeLow { get; private set; }
        public VocabularyKey MaxDosePerAdministration { get; private set; }
        public VocabularyKey MaxDosePeriodRatioQtyDenominatorValue { get; private set; }
        public VocabularyKey MaxDosePeriodRatioQtyNumeratorComparator { get; private set; }
        public VocabularyKey MaxDosePeriodRatioQuantityDenominatorUnit { get; private set; }
        public VocabularyKey MaxDosePeriodRatioQuantityNumeratorSystem { get; private set; }
        public VocabularyKey MaxDosePeriodRatioQuantityNumeratorUnit { get; private set; }
        public VocabularyKey MaxDosePeriodRatioQuantityNumeratorValue { get; private set; }
        public VocabularyKey MaxDosePeriodRatiotQuantityDenominatorSys { get; private set; }
        public VocabularyKey MaxDosePerLifetime { get; private set; }
        public VocabularyKey MaxDosePrdRatioQtyDenominatorComparator { get; private set; }
        public VocabularyKey PatientInstruction { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorComparator { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorUnit { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorValue { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorComparator { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorSystem { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorUnit { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorValue { get; private set; }
        public VocabularyKey RateRatiotQuantityDenominatorSystem { get; private set; }
        public VocabularyKey RateType { get; private set; }
        public VocabularyKey RateTypeQuantity { get; private set; }
        public VocabularyKey RateTypeRaangeLow { get; private set; }
        public VocabularyKey RateTypeRangeHigh { get; private set; }
        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Text { get; private set; }
    }
}