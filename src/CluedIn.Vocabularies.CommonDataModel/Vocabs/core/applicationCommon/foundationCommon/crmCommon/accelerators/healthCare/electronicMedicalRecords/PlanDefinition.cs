using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PlanDefinitionVocabulary : SimpleVocabulary
    {
        public PlanDefinitionVocabulary()
        {
            VocabularyName = "Plan Definition";
            KeyPrefix = "commonDataModel.plandefinition";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PlanDefinition;

            AddGroup("PlanDefinition Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApprovalDate = group.Add(new VocabularyKey(nameof(ApprovalDate), "Approval Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copyright = group.Add(new VocabularyKey(nameof(Copyright), "Copyright", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Experimental = group.Add(new VocabularyKey(nameof(Experimental), "Experimental", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastReviewDate = group.Add(new VocabularyKey(nameof(LastReviewDate), "Last Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanDefinitionId = group.Add(new VocabularyKey(nameof(PlanDefinitionId), "Plan Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanDefinitionNumber = group.Add(new VocabularyKey(nameof(PlanDefinitionNumber), "Plan Definition Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Publisher = group.Add(new VocabularyKey(nameof(Publisher), "Publisher", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RevisionDate = group.Add(new VocabularyKey(nameof(RevisionDate), "Revision Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Usage = group.Add(new VocabularyKey(nameof(Usage), "Usage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            ///Property <see cref="DefinitionTypePlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="DefinitionTypePQuestionnaireId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="TransformId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ReasonId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DescriptionId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="StartEventId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="GoalAddressesId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="GoalMeasureId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="QuantityCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValueconceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="JurisdictionId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="LibraryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RoleId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="TopicId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ValuecodeableconceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ActionInputId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
            ///Property <see cref="ActionOutputId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
            ///Property <see cref="EventDataId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
            ///Property <see cref="GoalId"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="DefinitionactivityId"/> to Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'IdentifiesspecifictimeswhentheeventoccuId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="DefinitionplanId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> to Vocab 'PlanDefinition.cdm.json/PlanDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TimingtimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ChildActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="RelatedActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="PlanDefinitionActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="ActionId"/> to Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionActionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="GoalId"/> to Vocab 'PlanDefinitionGoal.cdm.json/PlanDefinitionGoal' with Property 'PlanDefinitionGoalId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="EventreferenceId"/> to Vocab 'Schedule.cdm.json/Schedule' with Property 'ScheduleId'
            ///Property <see cref="EventtimingId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="PlanContributorId"/> to Vocab 'PlanDefinitionContributor.cdm.json/PlanDefinitionContributor' with Property 'PlanDefinitionContributorId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="PlanDefinitionGoalId"/> to Vocab 'PlanDefinitionGoal.cdm.json/PlanDefinitionGoal' with Property 'PlanDefinitionGoalId'
            ///Property <see cref="GoalIdentifierId"/> to Vocab 'PlanDefinitionGoal.cdm.json/PlanDefinitionGoal' with Property 'PlanDefinitionGoalId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'ActivityDefinitionTypePlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'CarePlanDefinition.cdm.json/CarePlanDefinition' with Property 'DefinitionTypePlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'DeviceRequestDefinition.cdm.json/DeviceRequestDefinition' with Property 'DefinitionTypePlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'FamilyMemberHistoryDefinition.cdm.json/FamilyMemberHistoryDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'MedicationAdministrationDefinition.cdm.json/MedicationAdministrationDefinition' with Property 'DefintionTypePlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'MedicationRequestDefinition.cdm.json/MedicationRequestDefinition' with Property 'MedicationRequestDefinitionPlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'DefinitionplanId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionArtifact.cdm.json/PlanDefinitionArtifact' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionContributor.cdm.json/PlanDefinitionContributor' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionGoal.cdm.json/PlanDefinitionGoal' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionJurisdiction.cdm.json/PlanDefinitionJurisdiction' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionLibrary.cdm.json/PlanDefinitionLibrary' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionTopic.cdm.json/PlanDefinitionTopic' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'PlanDefinitionUseContext.cdm.json/PlanDefinitionUseContext' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'ProcedureDefinition.cdm.json/ProcedureDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'ProcedureRequestDefinition.cdm.json/ProcedureRequestDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionId"/> from Vocab 'ReferralRequestDefinition.cdm.json/ReferralRequestDefinition' with Property 'PlanDefinitionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionAction.cdm.json/PlanDefinitionActionAction' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionAction.cdm.json/PlanDefinitionActionAction' with Property 'ChildActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionArtifact.cdm.json/PlanDefinitionActionArtifact' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionCode.cdm.json/PlanDefinitionActionCode' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionCondition.cdm.json/PlanDefinitionActionCondition' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionDynamicValue.cdm.json/PlanDefinitionActionDynamicValue' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionGoal.cdm.json/PlanDefinitionActionGoal' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionInput.cdm.json/PlanDefinitionActionInput' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionOutput.cdm.json/PlanDefinitionActionOutput' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionReason.cdm.json/PlanDefinitionActionReason' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionRelatedAction.cdm.json/PlanDefinitionActionRelatedAction' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionRelatedAction.cdm.json/PlanDefinitionActionRelatedAction' with Property 'RelatedActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionActionTriggerDefinition.cdm.json/PlanDefinitionActionTriggerDefinition' with Property 'PlanDefinitionActionId'
            ///Property <see cref="PlanDefinitionActionId"/> from Vocab 'PlanDefinitionParticipant.cdm.json/PlanDefinitionParticipant' with Property 'ActionId'
            ///Property <see cref="PlanDefinitionGoalId"/> from Vocab 'PlanDefinitionActionGoal.cdm.json/PlanDefinitionActionGoal' with Property 'GoalId'
            ///Property <see cref="PlanDefinitionContributorId"/> from Vocab 'PlanDefinitionContributorContact.cdm.json/PlanDefinitionContributorContact' with Property 'PlanContributorId'
            ///Property <see cref="PlanDefinitionGoalId"/> from Vocab 'PlanDefinitionGoalAddresses.cdm.json/PlanDefinitionGoalAddresses' with Property 'PlanDefinitionGoalId'
            ///Property <see cref="PlanDefinitionGoalId"/> from Vocab 'PlanDefinitionGoalArtifact.cdm.json/PlanDefinitionGoalArtifact' with Property 'GoalIdentifierId'
            #endregion
        }

        public VocabularyKey ApprovalDate { get; private set; }
        public VocabularyKey Copyright { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Experimental { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey LastReviewDate { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey PlanDefinitionId { get; private set; }
        public VocabularyKey PlanDefinitionNumber { get; private set; }
        public VocabularyKey Publisher { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RevisionDate { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey Usage { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Version { get; private set; }
    }
}