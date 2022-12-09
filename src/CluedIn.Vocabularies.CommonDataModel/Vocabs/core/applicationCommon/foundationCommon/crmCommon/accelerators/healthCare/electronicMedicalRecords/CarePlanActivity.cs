using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CarePlanActivityVocabulary : SimpleVocabulary
    {
        public CarePlanActivityVocabulary()
        {
            VocabularyName = "Care Plan Activity";
            KeyPrefix = "commonDataModel.careplanactivity";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CarePlanActivity;

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
            
            #region Incoming Relationships
            ///Property <see cref="PerformerTypeOrganizationId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="PerformerTypePatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PerformerTypePractitionerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="PerformerTypeRelatedPersonId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ReferenceAppointmentIdentifierId"/> to Vocab 'AppointmentEMR.cdm.json/AppointmentEMR' with Property 'ActivityId'
            ///Property <see cref="CarePlanId"/> to Vocab 'CarePlan.cdm.json/CarePlan' with Property 'CarePlanId'
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
            ///Property <see cref="ActivityCategoryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ActivityCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ActivityDefinitionTypeActivityDefinitionId"/> to Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'IdentifiesspecifictimeswhentheeventoccuId'
            ///Property <see cref="ActivityDefinitionTypePlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="ActivityDefinitionTypeQuestionnaireId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ActivityLocationId"/> to Vocab 'Location.cdm.json/Location' with Property 'LocationId'
            ///Property <see cref="ActivityProductCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ActivityProductReferenceTypeSubstanceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            ///Property <see cref="ActivityTimingId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
            ///Property <see cref="ProductReferenceMedicationNewId"/> to Vocab 'Medication.cdm.json/Medication' with Property 'MedicationId'
            ///Property <see cref="ReferenceCommunicationRequestIdentifierId"/> to Vocab 'CommunicationRequest.cdm.json/CommunicationRequest' with Property 'CommunicationRequestId'
            ///Property <see cref="ReferenceDeviceRequestIdentifierId"/> to Vocab 'DeviceRequest.cdm.json/DeviceRequest' with Property 'DeviceRequestId'
            ///Property <see cref="ReferenceMedicationRequestIdentifierId"/> to Vocab 'MedicationRequest.cdm.json/MedicationRequest' with Property 'MedicationRequestId'
            ///Property <see cref="ReferenceNutritionOrderIdentifierId"/> to Vocab 'NutritionOrder.cdm.json/NutritionOrder' with Property 'NutritionOrderId'
            ///Property <see cref="ReferenceProcedureRequestIdentifierId"/> to Vocab 'ProcedureRequest.cdm.json/ProcedureRequest' with Property 'ProcedureRequestId'
            ///Property <see cref="ReferenceReferralRequestIdentifierId"/> to Vocab 'ReferralRequest.cdm.json/ReferralRequest' with Property 'ReferralRequestId'
            ///Property <see cref="ReferenceRequestGroupIdentifierId"/> to Vocab 'RequestGroup.cdm.json/RequestGroup' with Property 'RequestGroupId'
            ///Property <see cref="ReferenceTaskIdentifierId"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="ReferenceVisionPrescriptionIdentifierId"/> to Vocab 'VisionPrescription.cdm.json/VisionPrescription' with Property 'VisionPrescriptionId'
            ///Property <see cref="ActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
            ///Property <see cref="ActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
            ///Property <see cref="ActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
            ///Property <see cref="ActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
            ///Property <see cref="ActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
            ///Property <see cref="CarePlanActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
            ///Property <see cref="ActivityId"/> to Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'CarePlanActivityId'
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
            ///Property <see cref="ActivityGoalId"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
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
            ///Property <see cref="ActivityOutcomeIdentifierId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            ///Property <see cref="PerformerTypeCareTeamId"/> to Vocab 'CareTeam.cdm.json/CareTeam' with Property 'CareTeamId'
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
            ///Property <see cref="PlanActivityReasonCodeIdentifierId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            ///Property <see cref="PlanActivityReasonReferenceId"/> to Vocab 'Condition.cdm.json/Condition' with Property 'ConditionId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'ActivityTimingId'
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivityGoal.cdm.json/CarePlanActivityGoal' with Property 'ActivityId'
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivityOutcome.cdm.json/CarePlanActivityOutcome' with Property 'ActivityId'
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivityOutcomeReference.cdm.json/CarePlanActivityOutcomeReference' with Property 'ActivityId'
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivityPerformer.cdm.json/CarePlanActivityPerformer' with Property 'ActivityId'
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivityReason.cdm.json/CarePlanActivityReason' with Property 'ActivityId'
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivityReasonCode.cdm.json/CarePlanActivityReasonCode' with Property 'CarePlanActivityId'
            ///Property <see cref="CarePlanActivityId"/> from Vocab 'CarePlanActivityReasonReference.cdm.json/CarePlanActivityReasonReference' with Property 'ActivityId'
            #endregion
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