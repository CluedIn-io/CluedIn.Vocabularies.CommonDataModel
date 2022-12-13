using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CampaignVocabulary : SimpleVocabulary
    {
        public CampaignVocabulary()
        {
            VocabularyName = "Campaign";
            KeyPrefix = "commonDataModel.campaign";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Campaign;

            AddGroup("Campaign Details for CrmCommon", group =>
            {
                CampaignId = group.Add(new VocabularyKey(nameof(CampaignId), "Campaign", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), "Actual End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetedCost = group.Add(new VocabularyKey(nameof(BudgetedCost), "Budget Allocated", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                BudgetedCostBase = group.Add(new VocabularyKey(nameof(BudgetedCostBase), "Budget Allocated (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodeName = group.Add(new VocabularyKey(nameof(CodeName), "Campaign Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedResponse = group.Add(new VocabularyKey(nameof(ExpectedResponse), "Expected Response Percentage", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ExpectedRevenue = group.Add(new VocabularyKey(nameof(ExpectedRevenue), "Estimated Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExpectedRevenueBase = group.Add(new VocabularyKey(nameof(ExpectedRevenueBase), "Estimated Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), "Template", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Message = group.Add(new VocabularyKey(nameof(Message), "Message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Objective = group.Add(new VocabularyKey(nameof(Objective), "Offer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherCost = group.Add(new VocabularyKey(nameof(OtherCost), "Miscellaneous Costs", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                OtherCostBase = group.Add(new VocabularyKey(nameof(OtherCostBase), "Miscellaneous Costs (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PromotionCodeName = group.Add(new VocabularyKey(nameof(PromotionCodeName), "Promotion Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedEnd = group.Add(new VocabularyKey(nameof(ProposedEnd), "Proposed End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProposedStart = group.Add(new VocabularyKey(nameof(ProposedStart), "Proposed Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalActualCost = group.Add(new VocabularyKey(nameof(TotalActualCost), "Total Cost of Campaign", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalActualCostBase = group.Add(new VocabularyKey(nameof(TotalActualCostBase), "Total Cost of Campaign (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCampaignActivityActualCost = group.Add(new VocabularyKey(nameof(TotalCampaignActivityActualCost), "Total Cost of Campaign Activities", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TotalCampaignActivityActualCostBase = group.Add(new VocabularyKey(nameof(TotalCampaignActivityActualCostBase), "Total Cost of Campaign Activities (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeCode = group.Add(new VocabularyKey(nameof(TypeCode), "Campaign Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Campaign Details for NonProfitForSales", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppealSegment = group.Add(new VocabularyKey(nameof(AppealSegment), "Appeal Segment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AquisitionSource = group.Add(new VocabularyKey(nameof(AquisitionSource), "Acquisition Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CampaignCategory = group.Add(new VocabularyKey(nameof(CampaignCategory), "Campaign Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CampaignType = group.Add(new VocabularyKey(nameof(CampaignType), "Campaign Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), "Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Effort = group.Add(new VocabularyKey(nameof(Effort), "Effort", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstResponseDate = group.Add(new VocabularyKey(nameof(FirstResponseDate), "First Response Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastResponseDate = group.Add(new VocabularyKey(nameof(LastResponseDate), "Last Response Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), "Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubChannel = group.Add(new VocabularyKey(nameof(SubChannel), "SubChannel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Campaign Details for NonProfitIati", group =>
            {

            });

            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CampaignActivityId"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PriceListId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookableResourceBookingId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CampaignActivityId"/> to Vocab 'CampaignActivity.cdm.json/CampaignActivity' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'CampaignActivity.cdm.json/CampaignActivity' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'CampaignActivity.cdm.json/CampaignActivity' with Property 'ActivityId'
            ///Property <see cref="ItemId"/> to Vocab 'MarketingList.cdm.json/MarketingList' with Property 'ListId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookableResourceBookingId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'QuickCampaign.cdm.json/QuickCampaign' with Property 'ActivityId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="OriginatingActivityId"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'MarketingList.cdm.json/MarketingList' with Property 'ListId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookableResourceBookingId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookableResourceBookingHeaderId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="CampaignId"/> from Vocab 'CampaignActivity.cdm.json/CampaignActivity' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'CampaignItem.cdm.json/CampaignItem' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'accelerators/automotive/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'accelerators/financialServices/banking/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'projectCommon/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'projectCommon/projectServiceAutomation/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'projectCommon/projectServiceAutomation/Order.cdm.json/Order' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'projectCommon/projectServiceAutomation/Quote.cdm.json/Quote' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'sales/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'sales/Order.cdm.json/Order' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'sales/Quote.cdm.json/Quote' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'solutions/marketing/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab 'solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="ActivityId"/> from Vocab 'CampaignActivityItem.cdm.json/CampaignActivityItem' with Property 'CampaignActivityId'
            ///Property <see cref="ActivityId"/> from Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'accelerators/automotive/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'projectCommon/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'solutions/marketing/Lead.cdm.json/Lead' with Property 'RelatedObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="ActivityId"/> from Vocab 'solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey AppealSegment { get; private set; }
        public VocabularyKey AquisitionSource { get; private set; }
        public VocabularyKey BudgetedCost { get; private set; }
        public VocabularyKey BudgetedCostBase { get; private set; }
        public VocabularyKey CampaignCategory { get; private set; }
        public VocabularyKey CampaignId { get; private set; }
        public VocabularyKey CampaignType { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey CodeName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExpectedResponse { get; private set; }
        public VocabularyKey ExpectedRevenue { get; private set; }
        public VocabularyKey ExpectedRevenueBase { get; private set; }
        public VocabularyKey FirstResponseDate { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey LastResponseDate { get; private set; }
        public VocabularyKey Message { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Objective { get; private set; }
        public VocabularyKey OtherCost { get; private set; }
        public VocabularyKey OtherCostBase { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey PromotionCodeName { get; private set; }
        public VocabularyKey ProposedEnd { get; private set; }
        public VocabularyKey ProposedStart { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubChannel { get; private set; }
        public VocabularyKey TotalActualCost { get; private set; }
        public VocabularyKey TotalActualCostBase { get; private set; }
        public VocabularyKey TotalCampaignActivityActualCost { get; private set; }
        public VocabularyKey TotalCampaignActivityActualCostBase { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey TypeCode { get; private set; }
    }
}