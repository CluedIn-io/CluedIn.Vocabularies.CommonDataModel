using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CustomerJourneyVocabulary : SimpleVocabulary
    {
        public CustomerJourneyVocabulary()
        {
            VocabularyName = "Customer Journey";
            KeyPrefix = "commonDataModel.customerjourney";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CustomerJourney;

            AddGroup("CustomerJourney Details for Banking", group =>
            {
			    ActiveStageStartedOn = group.Add(new VocabularyKey(nameof(ActiveStageStartedOn), "Active Stage Started On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BpfDuration = group.Add(new VocabularyKey(nameof(BpfDuration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BusinessProcessFlowInstanceId = group.Add(new VocabularyKey(nameof(BusinessProcessFlowInstanceId), "Customer Journey", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CompletedOn = group.Add(new VocabularyKey(nameof(CompletedOn), "Completed On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("CustomerJourney Details for Marketing", group =>
            {
			    CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), "Customer journey", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyDesignerState = group.Add(new VocabularyKey(nameof(CustomerJourneyDesignerState), "Customer journey designer state", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyTemplate = group.Add(new VocabularyKey(nameof(CustomerJourneyTemplate), "Customer journey template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyTimeZone = group.Add(new VocabularyKey(nameof(CustomerJourneyTimeZone), "Time zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), "End date and time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRecurring = group.Add(new VocabularyKey(nameof(IsRecurring), "Is recurring", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PublishedBy = group.Add(new VocabularyKey(nameof(PublishedBy), "Published by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecurrenceCount = group.Add(new VocabularyKey(nameof(RecurrenceCount), "Recurrence count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RecurrenceIntervalDays = group.Add(new VocabularyKey(nameof(RecurrenceIntervalDays), "Recurrence interval (days)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), "Start date and time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidationResults = group.Add(new VocabularyKey(nameof(ValidationResults), "Error check results", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkflowDefinition = group.Add(new VocabularyKey(nameof(WorkflowDefinition), "Workflow definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="ContentSettingsId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/ContentSettings.cdm.json/ContentSettings' with Property 'ContentSettingsId'
            ///Property <see cref="SuppressionSegmentId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Segment.cdm.json/Segment' with Property 'SegmentId'
            ///Property <see cref="LinkedInCampaign"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/LinkedInLeads/LinkedInCampaign.cdm.json/LinkedInCampaign' with Property 'LinkedInCampaignID'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ActiveStageStartedOn { get; private set; }
        public VocabularyKey BpfDuration { get; private set; }
        public VocabularyKey BusinessProcessFlowInstanceId { get; private set; }
        public VocabularyKey CompletedOn { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey CustomerJourneyDesignerState { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey CustomerJourneyTemplate { get; private set; }
        public VocabularyKey CustomerJourneyTimeZone { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey IsRecurring { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey PublishedBy { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RecurrenceCount { get; private set; }
        public VocabularyKey RecurrenceIntervalDays { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey ValidationResults { get; private set; }
        public VocabularyKey WorkflowDefinition { get; private set; }
    }
}