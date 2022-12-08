using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitIati
{
    public class CampaignVocabulary : SimpleVocabulary
    {
        public CampaignVocabulary()
        {
            VocabularyName = "Campaign";
            KeyPrefix = "commonDataModel.campaign.nonprofitiati";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Campaign;

            AddGroup("Campaign Details for NonProfitIati", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
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
            
            #region Incoming Relationships
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
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PriceListId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="Campaign_DefaultDesignationId"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
            ///Property <see cref="Campaign_DefaultDesignation"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="Campaign_DefaultDesignationId"/> to Vocab 'Designation.cdm.json/Designation' with Property 'DesignationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CampaignId"/> from Vocab 'DonorCommitment.cdm.json/DonorCommitment' with Property 'Commitment_CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/CreditPlan.cdm.json/CreditPlan' with Property 'CreditPlan_CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/DesignationPlan.cdm.json/DesignationPlan' with Property 'DesignationPlan_CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/DonorCommitment.cdm.json/DonorCommitment' with Property 'Commitment_CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/PlannedGiving.cdm.json/PlannedGiving' with Property 'PlannedGiving_CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Transaction.cdm.json/Transaction' with Property 'EffectiveCampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Transaction.cdm.json/Transaction' with Property 'OriginatingCampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignActivity.cdm.json/CampaignActivity' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignItem.cdm.json/CampaignItem' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/automotive/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/financialServices/banking/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Order.cdm.json/Order' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Quote.cdm.json/Quote' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Quote.cdm.json/Quote' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Lead.cdm.json/Lead' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="CampaignId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'PlannedGiving.cdm.json/PlannedGiving' with Property 'PlannedGiving_CampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'EffectiveCampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'OriginatingCampaignId'
            ///Property <see cref="CampaignId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'CampaignId'
            #endregion
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AppealSegment { get; private set; }
        public VocabularyKey AquisitionSource { get; private set; }
        public VocabularyKey CampaignCategory { get; private set; }
        public VocabularyKey CampaignType { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey FirstResponseDate { get; private set; }
        public VocabularyKey LastResponseDate { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey SubChannel { get; private set; }
    }
}