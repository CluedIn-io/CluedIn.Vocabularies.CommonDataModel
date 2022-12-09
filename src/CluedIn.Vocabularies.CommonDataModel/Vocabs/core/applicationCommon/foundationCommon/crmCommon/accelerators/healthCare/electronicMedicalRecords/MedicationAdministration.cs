using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MedicationAdministrationVocabulary : SimpleVocabulary
    {
        public MedicationAdministrationVocabulary()
        {
            VocabularyName = "Medication Administration";
            KeyPrefix = "commonDataModel.medicationadministration";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MedicationAdministration;

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
            
            #region Incoming Relationships
            ///Property <see cref="PerfomerOnBehalfOfId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="SubjectTypePatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PerformerActorTypePatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PerformerActorTypePractitionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PerformerActorTypeRelatedPersonId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CategoryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DosageMethodId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DosageRouteId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DosageSiteId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="MedicationCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RateRatioQuantityNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RatioDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SubjectTypeGroupId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="EventHistoryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonNotGivenId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonReferenceTypeConditionId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="PerformerActorTypeDeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="ContextTypeEncounterId"/> to Vocab 'Encounter.cdm.json/Encounter' with Property 'EncounterId'
            ///Property <see cref="ContextTypeEpisodeOfCareId"/> to Vocab 'EpisodeOfCare.cdm.json/EpisodeOfCare' with Property 'EpisodeOfCareId'
            ///Property <see cref="DefinitionTypeActivityDefintionId"/> to Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'IdentifiesspecifictimeswhentheeventoccuId'
            ///Property <see cref="MedicationReferenceNewId"/> to Vocab 'Medication.cdm.json/Medication' with Property 'MedicationId'
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
            ///Property <see cref="PrescriptionId"/> to Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'MedicationRequestId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="PartOfTypeMedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> to Vocab 'MedicationAdministration.cdm.json/MedicationAdministration' with Property 'MedicationAdministrationId'
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
            ///Property <see cref="DefintionTypePlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
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
            ///Property <see cref="PartOfTypeProcedureId"/> to Vocab 'Procedure.cdm.json/Procedure' with Property 'ProcedureId'
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
            ///Property <see cref="ReasonReferenceTypeObservationId"/> to Vocab 'Observation.cdm.json/Observation' with Property 'ObservationId'
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
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationDefinition.cdm.json/MedicationAdministrationDefinition' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationDevice.cdm.json/MedicationAdministrationDevice' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationEventHistory.cdm.json/MedicationAdministrationEventHistory' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationPartOf.cdm.json/MedicationAdministrationPartOf' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationPartOf.cdm.json/MedicationAdministrationPartOf' with Property 'PartOfTypeMedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationPerformer.cdm.json/MedicationAdministrationPerformer' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationReasonCode.cdm.json/MedicationAdministrationReasonCode' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationReasonNotGiven.cdm.json/MedicationAdministrationReasonNotGiven' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationReasonReference.cdm.json/MedicationAdministrationReasonReference' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'MedicationAdministrationSupportingInformation.cdm.json/MedicationAdministrationSupportingInformation' with Property 'MedicationAdministrationId'
            ///Property <see cref="MedicationAdministrationId"/> from Vocab 'ProcedurePartOf.cdm.json/ProcedurePartOf' with Property 'PartOfMedAdminId'
            #endregion
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
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
    }
}