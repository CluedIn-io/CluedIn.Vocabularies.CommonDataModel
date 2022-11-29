using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class CampaignVocabulary : SimpleVocabulary
    {
        public CampaignVocabulary()
        {
            VocabularyName = "Campaign";
            KeyPrefix = "commonDataModel.campaign.crmcommon";
            KeySeparator = ".";
            Grouping = "/Campaign";

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
        }

        public VocabularyKey CampaignId { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey BudgetedCost { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey BudgetedCostBase { get; private set; }
        public VocabularyKey CodeName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExpectedResponse { get; private set; }
        public VocabularyKey ExpectedRevenue { get; private set; }
        public VocabularyKey ExpectedRevenueBase { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey Message { get; private set; }
        public VocabularyKey Objective { get; private set; }
        public VocabularyKey OtherCost { get; private set; }
        public VocabularyKey OtherCostBase { get; private set; }
        public VocabularyKey PromotionCodeName { get; private set; }
        public VocabularyKey ProposedEnd { get; private set; }
        public VocabularyKey ProposedStart { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalActualCost { get; private set; }
        public VocabularyKey TotalActualCostBase { get; private set; }
        public VocabularyKey TotalCampaignActivityActualCost { get; private set; }
        public VocabularyKey TotalCampaignActivityActualCostBase { get; private set; }
        public VocabularyKey TypeCode { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
    }
}