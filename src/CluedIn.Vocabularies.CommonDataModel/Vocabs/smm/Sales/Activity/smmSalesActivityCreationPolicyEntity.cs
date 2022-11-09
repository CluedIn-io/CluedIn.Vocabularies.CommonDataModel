using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalesActivityCreationPolicyEntityVocabulary : SimpleVocabulary
    {
        public smmSalesActivityCreationPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmSalesActivityCreationPolicyEntity";
            KeyPrefix = "commonDataModel.smmsalesactivitycreationpolicyentity";
            KeySeparator = ".";
            Grouping = "/smmSalesActivityCreationPolicyEntity";

            AddGroup("Common Data Model smmSalesActivityCreationPolicyEntity Details", group =>
            {
                WillBatchProcessingCreateActivities = group.Add(new VocabularyKey(nameof(WillBatchProcessingCreateActivities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultQuotationActivityCategory = group.Add(new VocabularyKey(nameof(DefaultQuotationActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultQuotationActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultQuotationActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultQuotationActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultQuotationActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultQuotationActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultQuotationActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuotationActivityCreationRule = group.Add(new VocabularyKey(nameof(QuotationActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignFollowUpActivityCategory = group.Add(new VocabularyKey(nameof(DefaultCampaignFollowUpActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignFollowUpActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultCampaignFollowUpActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignFollowUpActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultCampaignFollowUpActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignFollowUpActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultCampaignFollowUpActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CampaignFollowUpActivityCreationRule = group.Add(new VocabularyKey(nameof(CampaignFollowUpActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignTargetActivityCategory = group.Add(new VocabularyKey(nameof(DefaultCampaignTargetActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignTargetActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultCampaignTargetActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignTargetActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultCampaignTargetActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCampaignTargetActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultCampaignTargetActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CampaignTargetActivityCreationRule = group.Add(new VocabularyKey(nameof(CampaignTargetActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallListActivityCategory = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallListActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallListActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallListActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallListActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallListActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallListActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallListActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TelemarketingCallListActivityCreationRule = group.Add(new VocabularyKey(nameof(TelemarketingCallListActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallBackActivityCategory = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallBackActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallBackActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallBackActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallBackActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallBackActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarketingCallbackActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultTelemarketingCallbackActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TelemarketingCallBackActivityCreationRule = group.Add(new VocabularyKey(nameof(TelemarketingCallBackActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarkeringTargetActivityCategory = group.Add(new VocabularyKey(nameof(DefaultTelemarkeringTargetActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarkeringTargetActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultTelemarkeringTargetActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarkeringTargetActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultTelemarkeringTargetActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTelemarkeringTargetActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultTelemarkeringTargetActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TelemarkeringTargetActivityCreationRule = group.Add(new VocabularyKey(nameof(TelemarkeringTargetActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogRequestActivityCategory = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogRequestActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogRequestActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogRequestActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogRequestActivityPurpose = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogRequestActivityPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogRequestActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogRequestActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCatalogRequestActivityCreationRule = group.Add(new VocabularyKey(nameof(SalesCatalogRequestActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogSentActivityCategory = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogSentActivityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogSentActivityPhaseId = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogSentActivityPhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogSentActivityPurposeId = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogSentActivityPurposeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesCatalogSentActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultSalesCatalogSentActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCatalogSentActivityCreationRule = group.Add(new VocabularyKey(nameof(SalesCatalogSentActivityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WillBatchProcessingCreateActivities { get; private set; }
public VocabularyKey DefaultQuotationActivityCategory { get; private set; }
public VocabularyKey DefaultQuotationActivityPhaseId { get; private set; }
public VocabularyKey DefaultQuotationActivityPurpose { get; private set; }
public VocabularyKey DefaultQuotationActivityTypeId { get; private set; }
public VocabularyKey QuotationActivityCreationRule { get; private set; }
public VocabularyKey DefaultCampaignFollowUpActivityCategory { get; private set; }
public VocabularyKey DefaultCampaignFollowUpActivityPhaseId { get; private set; }
public VocabularyKey DefaultCampaignFollowUpActivityPurpose { get; private set; }
public VocabularyKey DefaultCampaignFollowUpActivityTypeId { get; private set; }
public VocabularyKey CampaignFollowUpActivityCreationRule { get; private set; }
public VocabularyKey DefaultCampaignTargetActivityCategory { get; private set; }
public VocabularyKey DefaultCampaignTargetActivityPhaseId { get; private set; }
public VocabularyKey DefaultCampaignTargetActivityPurpose { get; private set; }
public VocabularyKey DefaultCampaignTargetActivityTypeId { get; private set; }
public VocabularyKey CampaignTargetActivityCreationRule { get; private set; }
public VocabularyKey DefaultTelemarketingCallListActivityCategory { get; private set; }
public VocabularyKey DefaultTelemarketingCallListActivityPhaseId { get; private set; }
public VocabularyKey DefaultTelemarketingCallListActivityPurpose { get; private set; }
public VocabularyKey DefaultTelemarketingCallListActivityTypeId { get; private set; }
public VocabularyKey TelemarketingCallListActivityCreationRule { get; private set; }
public VocabularyKey DefaultTelemarketingCallBackActivityCategory { get; private set; }
public VocabularyKey DefaultTelemarketingCallBackActivityPhaseId { get; private set; }
public VocabularyKey DefaultTelemarketingCallBackActivityPurpose { get; private set; }
public VocabularyKey DefaultTelemarketingCallbackActivityTypeId { get; private set; }
public VocabularyKey TelemarketingCallBackActivityCreationRule { get; private set; }
public VocabularyKey DefaultTelemarkeringTargetActivityCategory { get; private set; }
public VocabularyKey DefaultTelemarkeringTargetActivityPhaseId { get; private set; }
public VocabularyKey DefaultTelemarkeringTargetActivityPurpose { get; private set; }
public VocabularyKey DefaultTelemarkeringTargetActivityTypeId { get; private set; }
public VocabularyKey TelemarkeringTargetActivityCreationRule { get; private set; }
public VocabularyKey DefaultSalesCatalogRequestActivityCategory { get; private set; }
public VocabularyKey DefaultSalesCatalogRequestActivityPhaseId { get; private set; }
public VocabularyKey DefaultSalesCatalogRequestActivityPurpose { get; private set; }
public VocabularyKey DefaultSalesCatalogRequestActivityTypeId { get; private set; }
public VocabularyKey SalesCatalogRequestActivityCreationRule { get; private set; }
public VocabularyKey DefaultSalesCatalogSentActivityCategory { get; private set; }
public VocabularyKey DefaultSalesCatalogSentActivityPhaseId { get; private set; }
public VocabularyKey DefaultSalesCatalogSentActivityPurposeId { get; private set; }
public VocabularyKey DefaultSalesCatalogSentActivityTypeId { get; private set; }
public VocabularyKey SalesCatalogSentActivityCreationRule { get; private set; }


    }
}