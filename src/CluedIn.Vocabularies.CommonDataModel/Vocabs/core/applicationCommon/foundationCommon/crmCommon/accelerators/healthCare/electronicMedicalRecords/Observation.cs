using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ObservationVocabulary : SimpleVocabulary
    {
        public ObservationVocabulary()
        {
            VocabularyName = "Observation";
            KeyPrefix = "commonDataModel.observation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Observation;

            AddGroup("Observation Details for ElectronicMedicalRecords", group =>
            {
                Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceType = group.Add(new VocabularyKey(nameof(DeviceType), "Device Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveEnd = group.Add(new VocabularyKey(nameof(EffectiveEnd), "Effective End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveStart = group.Add(new VocabularyKey(nameof(EffectiveStart), "Effective Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveType = group.Add(new VocabularyKey(nameof(EffectiveType), "Effective Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveTypeDateTime = group.Add(new VocabularyKey(nameof(EffectiveTypeDateTime), "Effective Type Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Identifier = group.Add(new VocabularyKey(nameof(Identifier), "Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssuedDate = group.Add(new VocabularyKey(nameof(IssuedDate), "Issued Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ObservationId = group.Add(new VocabularyKey(nameof(ObservationId), "Observation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ObservationNumber = group.Add(new VocabularyKey(nameof(ObservationNumber), "Observation Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueBoolean = group.Add(new VocabularyKey(nameof(ValueBoolean), "Value Boolean", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ValueDateType = group.Add(new VocabularyKey(nameof(ValueDateType), "Value Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValuePeriodEndDate = group.Add(new VocabularyKey(nameof(ValuePeriodEndDate), "Value Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValuePeriodStartDate = group.Add(new VocabularyKey(nameof(ValuePeriodStartDate), "Value Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueQuantitySystem = group.Add(new VocabularyKey(nameof(ValueQuantitySystem), "Value Quantity System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueQuantityUnit = group.Add(new VocabularyKey(nameof(ValueQuantityUnit), "Value Quantity Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueRangeHighLimit = group.Add(new VocabularyKey(nameof(ValueRangeHighLimit), "Value Range High Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ValueRangeLowLimit = group.Add(new VocabularyKey(nameof(ValueRangeLowLimit), "Value Range Low Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ValueRatioDenominatorComparator = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorComparator), "Ratio Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueRatioDenominatorSystem = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorSystem), "Ratio Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueRatioDenominatorUnit = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorUnit), "Ratio Denominator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueRatioDenominatorValue = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorValue), "Ratio Denominator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ValueRatioNumeratorComparator = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorComparator), "Ratio Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueRatioNumeratorSystem = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorSystem), "Ratio Numerator  System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueRatioNumeratorUnit = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorUnit), "Ratio Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueRatioNumeratorValue = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorValue), "Ratio Numerator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ValueSampledDataTypeData = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeData), "Value Sampled DataType Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueSampledDataTypeDimension = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeDimension), "Value Sampled Data Type Dimension", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ValueSampledDataTypeFactor = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeFactor), "Value Sampled Data Type Factor", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ValueSampledDataTypeLowerLimit = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeLowerLimit), "Value Sampled Data Type Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ValueSampledDataTypeOrigin = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeOrigin), "Value Sampled Data Type Origin", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ValueSampledDataTypePeriod = group.Add(new VocabularyKey(nameof(ValueSampledDataTypePeriod), "Value Sampled Data Type Period", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ValueSampledDataTypeUpperLimit = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeUpperLimit), "Value Sampled Data Type Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ValueString = group.Add(new VocabularyKey(nameof(ValueString), "Value String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueType = group.Add(new VocabularyKey(nameof(ValueType), "Value Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueTypeQuantityComparator = group.Add(new VocabularyKey(nameof(ValueTypeQuantityComparator), "Quantity Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueTypeQuantityValue = group.Add(new VocabularyKey(nameof(ValueTypeQuantityValue), "Quantity Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Observation Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="ObsPerformerOrganizationId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="SubjectTypePatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ObsPerformerPatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ObsPerformerPractitionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ObsPerformerRelatedPersonId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ObsBasedOnTypeCarePlanId"/> to Vocab 'CarePlan.cdm.json/CarePlan' with Property 'CarePlanId'
            ///Property <see cref="BodySiteId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DataAbsentReasonId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="InterpretationId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="MethodId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SubjectTypeGroupId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueQuantityCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueRatioDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueRatioNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ObsBasedOnTypeImmunizationRequestId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ComponentDataAbsentReasonId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ComponentInterpretationId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ObsComponentCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueQuantityCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueRatioDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueRatioNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RangeTypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ObsReferenceRangeAppliesToId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ObsRelatedResourceQuestionaireResponseId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ObsRelatedResourceSequenceIdentfierId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="DeviceTypeDeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="SubjectTypeDeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="DeviceTypeDeviceMetricId"/> to Vocab 'DeviceMetric.cdm.json/DeviceMetric' with Property 'DeviceMetricId'
            ///Property <see cref="ObsBasedOnTypeDeviceRequestId"/> to Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'DeviceRequestId'
            ///Property <see cref="ConextTypeEncounterId"/> to Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterId'
            ///Property <see cref="ConextTypeEpisodeOfCareId"/> to Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'EpisodeOfCareId'
            ///Property <see cref="EpisodeOfCareId"/> to Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'EpisodeOfCareId'
            ///Property <see cref="SubjectTypeLocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="ObsBasedOnTypeMedRequestId"/> to Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'MedicationRequestId'
            ///Property <see cref="ObsBasedOnTypeNutritionOrderId"/> to Vocab 'NutritionOrder.cdm.json/NutritionOrder' with Property 'NutritionOrderId'
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
            ///Property <see cref="SpecimenId"/> to Vocab 'Specimen.cdm.json/Specimen' with Property 'SpecimenId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
            ///Property <see cref="ObsRelatedResourceObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
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
            ///Property <see cref="ObsBasedOnTypeProcedureRequestId"/> to Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'ProcedureRequestId'
            ///Property <see cref="ObsBasedOnTypeReferralRequestId"/> to Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'ReferralRequestId'
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
            ///Property <see cref="ObservationComponentId"/> to Vocab 'ObservationComponent.cdm.json/ObservationComponent' with Property 'ObservationComponentId'
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
            ///Property <see cref="ObservationReferenceRangeId"/> to Vocab 'ObservationReferenceRange.cdm.json/ObservationReferenceRange' with Property 'ObservationReferenceRangeId'
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
            ///Property <see cref="ObservationId"/> from Vocab 'ClinicalImpressionFinding.cdm.json/ClinicalImpressionFinding' with Property 'ItemObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ClinicalImpressionInvestigation.cdm.json/ClinicalImpressionInvestigation' with Property 'ItemObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ClinicalImpressionInvestigationItem.cdm.json/ClinicalImpressionInvestigationItem' with Property 'ItemTypeObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'CommunicationRequestReasonReference.cdm.json/CommunicationRequestReasonReference' with Property 'ReasonReferenceObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ConditionStage.cdm.json/ConditionStage' with Property 'StageAssessmentClinicalImpressionId'
            ///Property <see cref="ObservationId"/> from Vocab 'ConditionStage.cdm.json/ConditionStage' with Property 'StageAssessmentObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'FamilyMemberHistoryReasonReference.cdm.json/FamilyMemberHistoryReasonReference' with Property 'ReasonReferenceObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'GoalAddresses.cdm.json/GoalAddresses' with Property 'AddressesTypeObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'MedicationAdministrationReasonReference.cdm.json/MedicationAdministrationReasonReference' with Property 'ReasonReferenceTypeObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'MedicationRequestReasonReference.cdm.json/MedicationRequestReasonReference' with Property 'ReasonReferenceObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationBasedOn.cdm.json/ObservationBasedOn' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationCategory.cdm.json/ObservationCategory' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationComponent.cdm.json/ObservationComponent' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationPerformer.cdm.json/ObservationPerformer' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationReferenceRange.cdm.json/ObservationReferenceRange' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationReferenceRangeAppliesTo.cdm.json/ObservationReferenceRangeAppliesTo' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationRelatedResource.cdm.json/ObservationRelatedResource' with Property 'ObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ObservationRelatedResource.cdm.json/ObservationRelatedResource' with Property 'ObsRelatedResourceObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ProcedurePartOf.cdm.json/ProcedurePartOf' with Property 'PartOfObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ProcedureReasonReference.cdm.json/ProcedureReasonReference' with Property 'ReferenceObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ProcedureRequestReasonReference.cdm.json/ProcedureRequestReasonReference' with Property 'ReferenceReasonObservationId'
            ///Property <see cref="ObservationId"/> from Vocab 'ReferralRequestReasonReference.cdm.json/ReferralRequestReasonReference' with Property 'ReferenceReasonObservationId'
            ///Property <see cref="ObservationComponentId"/> from Vocab 'ObservationComponentReferenceRange.cdm.json/ObservationComponentReferenceRange' with Property 'ObservationComponentId'
            ///Property <see cref="ObservationReferenceRangeId"/> from Vocab 'ObservationComponentReferenceRange.cdm.json/ObservationComponentReferenceRange' with Property 'ObservationReferenceRangeId'
            #endregion
        }

        public VocabularyKey Comment { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceType { get; private set; }
        public VocabularyKey EffectiveEnd { get; private set; }
        public VocabularyKey EffectiveStart { get; private set; }
        public VocabularyKey EffectiveType { get; private set; }
        public VocabularyKey EffectiveTypeDateTime { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey IssuedDate { get; private set; }
        public VocabularyKey ObservationId { get; private set; }
        public VocabularyKey ObservationNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey ValueBoolean { get; private set; }
        public VocabularyKey ValueDateType { get; private set; }
        public VocabularyKey ValuePeriodEndDate { get; private set; }
        public VocabularyKey ValuePeriodStartDate { get; private set; }
        public VocabularyKey ValueQuantitySystem { get; private set; }
        public VocabularyKey ValueQuantityUnit { get; private set; }
        public VocabularyKey ValueRangeHighLimit { get; private set; }
        public VocabularyKey ValueRangeLowLimit { get; private set; }
        public VocabularyKey ValueRatioDenominatorComparator { get; private set; }
        public VocabularyKey ValueRatioDenominatorSystem { get; private set; }
        public VocabularyKey ValueRatioDenominatorUnit { get; private set; }
        public VocabularyKey ValueRatioDenominatorValue { get; private set; }
        public VocabularyKey ValueRatioNumeratorComparator { get; private set; }
        public VocabularyKey ValueRatioNumeratorSystem { get; private set; }
        public VocabularyKey ValueRatioNumeratorUnit { get; private set; }
        public VocabularyKey ValueRatioNumeratorValue { get; private set; }
        public VocabularyKey ValueSampledDataTypeData { get; private set; }
        public VocabularyKey ValueSampledDataTypeDimension { get; private set; }
        public VocabularyKey ValueSampledDataTypeFactor { get; private set; }
        public VocabularyKey ValueSampledDataTypeLowerLimit { get; private set; }
        public VocabularyKey ValueSampledDataTypeOrigin { get; private set; }
        public VocabularyKey ValueSampledDataTypePeriod { get; private set; }
        public VocabularyKey ValueSampledDataTypeUpperLimit { get; private set; }
        public VocabularyKey ValueString { get; private set; }
        public VocabularyKey ValueType { get; private set; }
        public VocabularyKey ValueTypeQuantityComparator { get; private set; }
        public VocabularyKey ValueTypeQuantityValue { get; private set; }
    }
}