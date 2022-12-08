using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Service
{
    public class CaseVocabulary : SimpleVocabulary
    {
        public CaseVocabulary()
        {
            VocabularyName = "Case";
            KeyPrefix = "commonDataModel.case.service";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Case;

            AddGroup("Case Details for Service", group =>
            {
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Case Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivitiesComplete = group.Add(new VocabularyKey(nameof(ActivitiesComplete), "Activities Complete", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ActualServiceUnits = group.Add(new VocabularyKey(nameof(ActualServiceUnits), "Actual Service Units", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    BilledServiceUnits = group.Add(new VocabularyKey(nameof(BilledServiceUnits), "Billed Service Units", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    BlockedProfile = group.Add(new VocabularyKey(nameof(BlockedProfile), "Blocked Profile", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CaseOriginCode = group.Add(new VocabularyKey(nameof(CaseOriginCode), "Origin", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CaseTypeCode = group.Add(new VocabularyKey(nameof(CaseTypeCode), "Case Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CheckEmail = group.Add(new VocabularyKey(nameof(CheckEmail), "Check Email", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ContractServiceLevelCode = group.Add(new VocabularyKey(nameof(ContractServiceLevelCode), "Service Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerSatisfactionCode = group.Add(new VocabularyKey(nameof(CustomerSatisfactionCode), "Satisfaction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstResponseSLAStatus = group.Add(new VocabularyKey(nameof(FirstResponseSLAStatus), "First Response SLA Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FollowupBy = group.Add(new VocabularyKey(nameof(FollowupBy), "Follow Up By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FollowUpTaskCreated = group.Add(new VocabularyKey(nameof(FollowUpTaskCreated), "Follow up Task Created", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncidentStageCode = group.Add(new VocabularyKey(nameof(IncidentStageCode), "Case Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDecrementing = group.Add(new VocabularyKey(nameof(IsDecrementing), "Decrementing", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MessageTypeCode = group.Add(new VocabularyKey(nameof(MessageTypeCode), "Received As", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductSerialNumber = group.Add(new VocabularyKey(nameof(ProductSerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResolveBySLAStatus = group.Add(new VocabularyKey(nameof(ResolveBySLAStatus), "Resolve By SLA Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SentimentValue = group.Add(new VocabularyKey(nameof(SentimentValue), "Sentiment Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    InfluenceScore = group.Add(new VocabularyKey(nameof(InfluenceScore), "Influence Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ServiceStage = group.Add(new VocabularyKey(nameof(ServiceStage), "Service Stage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeverityCode = group.Add(new VocabularyKey(nameof(SeverityCode), "Severity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TicketNumber = group.Add(new VocabularyKey(nameof(TicketNumber), "Case Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfChildIncidents = group.Add(new VocabularyKey(nameof(NumberOfChildIncidents), "Child Cases", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Merged = group.Add(new VocabularyKey(nameof(Merged), "Internal Use Only", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RouteCase = group.Add(new VocabularyKey(nameof(RouteCase), "Route Case", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ResolveBy = group.Add(new VocabularyKey(nameof(ResolveBy), "Resolve By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResponseBy = group.Add(new VocabularyKey(nameof(ResponseBy), "First Response By", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerContacted = group.Add(new VocabularyKey(nameof(CustomerContacted), "Customer Contacted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    FirstResponseSent = group.Add(new VocabularyKey(nameof(FirstResponseSent), "First Response Sent", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsEscalated = group.Add(new VocabularyKey(nameof(IsEscalated), "Is Escalated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EscalatedOn = group.Add(new VocabularyKey(nameof(EscalatedOn), "Escalated On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DecrementEntitlementTerm = group.Add(new VocabularyKey(nameof(DecrementEntitlementTerm), "Decrement Entitlement Terms", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="IncidentId"/> to Vocab 'ChildIncidentCount.cdm.json/ChildIncidentCount' with Property 'ParentCaseId'
            ///Property <see cref="ContractDetailId"/> to Vocab 'ContractLine.cdm.json/ContractLine' with Property 'ContractDetailId'
            ///Property <see cref="ContractId"/> to Vocab 'Contract.cdm.json/Contract' with Property 'ContractId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="EntitlementId"/> to Vocab 'Entitlement.cdm.json/Entitlement' with Property 'EntitlementId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="KbArticleId"/> to Vocab '/core/applicationCommon/Article.cdm.json/Article' with Property 'KbArticleId'
            ///Property <see cref="ProductId"/> to Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ExistingCase"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="ResponsibleContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SocialProfileId"/> to Vocab '/core/applicationCommon/SocialProfile.cdm.json/SocialProfile' with Property 'SocialProfileId'
            ///Property <see cref="MasterId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="ParentCaseId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="PrimaryContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ResolveByKPIId"/> to Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'SLAKPIInstanceId'
            ///Property <see cref="FirstResponseByKPIId"/> to Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'SLAKPIInstanceId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Entitlement.cdm.json/Entitlement' with Property 'EntitlementId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookableResourceBookingId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="ServiceId"/> to Vocab 'Service.cdm.json/Service' with Property 'ServiceId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="IncidentId"/> to Vocab 'ChildIncidentCount.cdm.json/ChildIncidentCount' with Property 'ParentCaseId'
            ///Property <see cref="ContractId"/> to Vocab 'Contract.cdm.json/Contract' with Property 'ContractId'
            ///Property <see cref="ContractDetailId"/> to Vocab 'ContractLine.cdm.json/ContractLine' with Property 'ContractDetailId'
            ///Property <see cref="EntitlementId"/> to Vocab 'Entitlement.cdm.json/Entitlement' with Property 'EntitlementId'
            ///Property <see cref="ResolveByKPIId"/> to Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'SLAKPIInstanceId'
            ///Property <see cref="FirstResponseByKPIId"/> to Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'SLAKPIInstanceId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="IncidentId"/> from Vocab 'Case.cdm.json/Case' with Property 'ExistingCase'
            ///Property <see cref="IncidentId"/> from Vocab 'Case.cdm.json/Case' with Property 'MasterId'
            ///Property <see cref="IncidentId"/> from Vocab 'Case.cdm.json/Case' with Property 'ParentCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Lead.cdm.json/Lead' with Property 'OriginatingCaseId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab 'IncidentKnowledgeBaseRecord.cdm.json/IncidentKnowledgeBaseRecord' with Property 'IncidentId'
            ///Property <see cref="IncidentId"/> from Vocab 'KnowledgeArticleIncident.cdm.json/KnowledgeArticleIncident' with Property 'IncidentId'
            ///Property <see cref="IncidentId"/> from Vocab 'ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="IncidentId"/> from Vocab 'SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            #endregion
        }

        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ActivitiesComplete { get; private set; }
        public VocabularyKey ActualServiceUnits { get; private set; }
        public VocabularyKey BilledServiceUnits { get; private set; }
        public VocabularyKey BlockedProfile { get; private set; }
        public VocabularyKey CaseOriginCode { get; private set; }
        public VocabularyKey CaseTypeCode { get; private set; }
        public VocabularyKey CheckEmail { get; private set; }
        public VocabularyKey ContractServiceLevelCode { get; private set; }
        public VocabularyKey CustomerSatisfactionCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FirstResponseSLAStatus { get; private set; }
        public VocabularyKey FollowupBy { get; private set; }
        public VocabularyKey FollowUpTaskCreated { get; private set; }
        public VocabularyKey IncidentStageCode { get; private set; }
        public VocabularyKey IsDecrementing { get; private set; }
        public VocabularyKey MessageTypeCode { get; private set; }
        public VocabularyKey PriorityCode { get; private set; }
        public VocabularyKey ProductSerialNumber { get; private set; }
        public VocabularyKey ResolveBySLAStatus { get; private set; }
        public VocabularyKey SentimentValue { get; private set; }
        public VocabularyKey InfluenceScore { get; private set; }
        public VocabularyKey ServiceStage { get; private set; }
        public VocabularyKey SeverityCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey TicketNumber { get; private set; }
        public VocabularyKey NumberOfChildIncidents { get; private set; }
        public VocabularyKey Merged { get; private set; }
        public VocabularyKey RouteCase { get; private set; }
        public VocabularyKey ResolveBy { get; private set; }
        public VocabularyKey ResponseBy { get; private set; }
        public VocabularyKey CustomerContacted { get; private set; }
        public VocabularyKey FirstResponseSent { get; private set; }
        public VocabularyKey IsEscalated { get; private set; }
        public VocabularyKey EscalatedOn { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey DecrementEntitlementTerm { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
    }
}