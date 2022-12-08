using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class ProjectTeamVocabulary : SimpleVocabulary
    {
        public ProjectTeamVocabulary()
        {
            VocabularyName = "Project Team";
            KeyPrefix = "commonDataModel.projectteam.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ProjectTeam;

            AddGroup("ProjectTeam Details for ProjectServiceAutomation", group =>
            {
			    ProjectTeamId = group.Add(new VocabularyKey(nameof(ProjectTeamId), "Project Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PositionName = group.Add(new VocabularyKey(nameof(PositionName), "Position Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllocationMethod = group.Add(new VocabularyKey(nameof(AllocationMethod), "Allocation method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AssignedHours = group.Add(new VocabularyKey(nameof(AssignedHours), "Assigned Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), "Calendar Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HardBookedHours = group.Add(new VocabularyKey(nameof(HardBookedHours), "Hard Booked Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Hours = group.Add(new VocabularyKey(nameof(Hours), "Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    HoursRequested = group.Add(new VocabularyKey(nameof(HoursRequested), "Required Hours (Deprecated in v3.0)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MembershipStatus = group.Add(new VocabularyKey(nameof(MembershipStatus), "Membership Status (Deprecated in v3.0)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MSProjectClientId = group.Add(new VocabularyKey(nameof(MSProjectClientId), "MS Project Client Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Number = group.Add(new VocabularyKey(nameof(Number), "Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Percentage = group.Add(new VocabularyKey(nameof(Percentage), "Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProjectApprover = group.Add(new VocabularyKey(nameof(ProjectApprover), "Project Approver", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RequiredHours = group.Add(new VocabularyKey(nameof(RequiredHours), "Required Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RoleDescription = group.Add(new VocabularyKey(nameof(RoleDescription), "Position Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SoftBookedHours = group.Add(new VocabularyKey(nameof(SoftBookedHours), "Soft Booked Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicantCount = group.Add(new VocabularyKey(nameof(ApplicantCount), "Applicant count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ApplicantCountDate = group.Add(new VocabularyKey(nameof(ApplicantCountDate), "Applicant count (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicantCountState = group.Add(new VocabularyKey(nameof(ApplicantCountState), "Applicant count (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ApplicantsAvailable = group.Add(new VocabularyKey(nameof(ApplicantsAvailable), "Applicants available (Deprecated in v3.0)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="BookableResourceId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ResourcingUnit"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="ResourceRequirementId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'ResourceRequirementId'
            ///Property <see cref="WorkTemplate"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/WorkHourTemplate.cdm.json/WorkHourTemplate' with Property 'WorkHourTemplateId'
            ///Property <see cref="TeamMembership"/> to Vocab 'ProjectTeam.cdm.json/ProjectTeam' with Property 'ProjectTeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="BookableResource"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ProjectTeamId"/> from Vocab 'FindWorkEvent.cdm.json/FindWorkEvent' with Property 'Work'
            ///Property <see cref="ProjectTeamId"/> from Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'AssignedTeamMembers'
            ///Property <see cref="ProjectTeamId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Schedule.cdm.json/Schedule' with Property 'ProjectTeamId'
            ///Property <see cref="ProjectTeamId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'ProjectTeamId'
            ///Property <see cref="ProjectTeamId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'ProjectTeamId'
            ///Property <see cref="ProjectTeamId"/> from Vocab 'ProjectTeamMemberSignUp.cdm.json/ProjectTeamMemberSignUp' with Property 'TeamMembership'
            ///Property <see cref="ProjectTeamId"/> from Vocab 'ResourceAssignment.cdm.json/ResourceAssignment' with Property 'ProjectTeam'
            #endregion
        }

        public VocabularyKey ProjectTeamId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey PositionName { get; private set; }
        public VocabularyKey AllocationMethod { get; private set; }
        public VocabularyKey AssignedHours { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey HardBookedHours { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey HoursRequested { get; private set; }
        public VocabularyKey MembershipStatus { get; private set; }
        public VocabularyKey MSProjectClientId { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey ProjectApprover { get; private set; }
        public VocabularyKey RequiredHours { get; private set; }
        public VocabularyKey RoleDescription { get; private set; }
        public VocabularyKey SoftBookedHours { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey ApplicantCount { get; private set; }
        public VocabularyKey ApplicantCountDate { get; private set; }
        public VocabularyKey ApplicantCountState { get; private set; }
        public VocabularyKey ApplicantsAvailable { get; private set; }
    }
}