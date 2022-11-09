using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSharedParameterEntityVocabulary : SimpleVocabulary
    {
        public RetailSharedParameterEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailSharedParameterEntity";
            KeyPrefix = "commonDataModel.retailsharedparameterentity";
            KeySeparator = ".";
            Grouping = "/RetailSharedParameterEntity";

            AddGroup("Common Data Model RetailSharedParameterEntity Details", group =>
            {
                AllowTerminalAssociationFromDevice = group.Add(new VocabularyKey(nameof(AllowTerminalAssociationFromDevice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatalogDefaultAttributeGroup = group.Add(new VocabularyKey(nameof(CatalogDefaultAttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatalogAttributeBulkEditMaxRows = group.Add(new VocabularyKey(nameof(CatalogAttributeBulkEditMaxRows), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryDefaultAttributeGroup = group.Add(new VocabularyKey(nameof(CategoryDefaultAttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerDefaultAttributeGroup = group.Add(new VocabularyKey(nameof(CustomerDefaultAttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeviceTokenAlgorithm = group.Add(new VocabularyKey(nameof(DeviceTokenAlgorithm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarnLoyaltyOffline = group.Add(new VocabularyKey(nameof(EarnLoyaltyOffline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EFTPasswordEncryption = group.Add(new VocabularyKey(nameof(EFTPasswordEncryption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntityValidationTemplate = group.Add(new VocabularyKey(nameof(EntityValidationTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateType = group.Add(new VocabularyKey(nameof(ExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HtmlAttributeType = group.Add(new VocabularyKey(nameof(HtmlAttributeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ImagesAttributeType = group.Add(new VocabularyKey(nameof(ImagesAttributeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemLabelCreation = group.Add(new VocabularyKey(nameof(ItemLabelCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocalStoreId = group.Add(new VocabularyKey(nameof(LocalStoreId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductDefaultAttributeGroup = group.Add(new VocabularyKey(nameof(ProductDefaultAttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SharepointAssetPickerUrl = group.Add(new VocabularyKey(nameof(SharepointAssetPickerUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShelfLabelCreation = group.Add(new VocabularyKey(nameof(ShelfLabelCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StaffPasswordHash = group.Add(new VocabularyKey(nameof(StaffPasswordHash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionServiceProfile = group.Add(new VocabularyKey(nameof(TransactionServiceProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionServicePasswordEncryption = group.Add(new VocabularyKey(nameof(TransactionServicePasswordEncryption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VideosAttributeType = group.Add(new VocabularyKey(nameof(VideosAttributeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerDefaultAttributeGroup = group.Add(new VocabularyKey(nameof(WorkerDefaultAttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeploymentRootPath = group.Add(new VocabularyKey(nameof(DeploymentRootPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateTypeName = group.Add(new VocabularyKey(nameof(ExchangeRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WindowsPhoneAppInsightsInstrumentationKey = group.Add(new VocabularyKey(nameof(WindowsPhoneAppInsightsInstrumentationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AsyncClientAppInsightsInstrumentationKey = group.Add(new VocabularyKey(nameof(AsyncClientAppInsightsInstrumentationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HardwareStationAppInsightsInstrumentationKey = group.Add(new VocabularyKey(nameof(HardwareStationAppInsightsInstrumentationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CloudPosAppInsightsInstrumentationKey = group.Add(new VocabularyKey(nameof(CloudPosAppInsightsInstrumentationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailServerAppInsightsInstrumentationKey = group.Add(new VocabularyKey(nameof(RetailServerAppInsightsInstrumentationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClientAppInsightsInstrumentationKey = group.Add(new VocabularyKey(nameof(ClientAppInsightsInstrumentationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatalogDefaultAttributeGroupName = group.Add(new VocabularyKey(nameof(CatalogDefaultAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryDefaultAttributeGroupName = group.Add(new VocabularyKey(nameof(CategoryDefaultAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerDefaultAttributeGroupName = group.Add(new VocabularyKey(nameof(CustomerDefaultAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductDefaultAttributeGroupName = group.Add(new VocabularyKey(nameof(ProductDefaultAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerDefaultAttributeGroupName = group.Add(new VocabularyKey(nameof(WorkerDefaultAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HtmlAttributeTypeName = group.Add(new VocabularyKey(nameof(HtmlAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ImagesAttributeTypeName = group.Add(new VocabularyKey(nameof(ImagesAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VideosAttributeTypeName = group.Add(new VocabularyKey(nameof(VideosAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostLoyaltyPointsPerSalesLine = group.Add(new VocabularyKey(nameof(PostLoyaltyPointsPerSalesLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BlockTransferBetweenDifferentLoyalty = group.Add(new VocabularyKey(nameof(BlockTransferBetweenDifferentLoyalty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableOmniChannelPayments = group.Add(new VocabularyKey(nameof(EnableOmniChannelPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableFiscalIntegration = group.Add(new VocabularyKey(nameof(EnableFiscalIntegration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecoListEnabled = group.Add(new VocabularyKey(nameof(RecoListEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecoListBestsellingTransactionsIntervalDays = group.Add(new VocabularyKey(nameof(RecoListBestsellingTransactionsIntervalDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecoListTrendingMaxAgeDays = group.Add(new VocabularyKey(nameof(RecoListTrendingMaxAgeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecoListTrendingTransactionsIntervalDays = group.Add(new VocabularyKey(nameof(RecoListTrendingTransactionsIntervalDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecoPersonalizationEnabled = group.Add(new VocabularyKey(nameof(RecoPersonalizationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableLocalStorageBackup = group.Add(new VocabularyKey(nameof(EnableLocalStorageBackup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseSalesReceiptAsDefaultReceiptTypeInJournal = group.Add(new VocabularyKey(nameof(UseSalesReceiptAsDefaultReceiptTypeInJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductAvailabilityJobPolicy = group.Add(new VocabularyKey(nameof(ProductAvailabilityJobPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryAvailabilityCachePeriod = group.Add(new VocabularyKey(nameof(InventoryAvailabilityCachePeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryAvailabilitySumDeltaCachePeriod = group.Add(new VocabularyKey(nameof(InventoryAvailabilitySumDeltaCachePeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateCustomerToRedeemLoyalty = group.Add(new VocabularyKey(nameof(ValidateCustomerToRedeemLoyalty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableAdvancedExternalGiftCard = group.Add(new VocabularyKey(nameof(EnableAdvancedExternalGiftCard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableKitApprovalBatchFeature = group.Add(new VocabularyKey(nameof(EnableKitApprovalBatchFeature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AllowTerminalAssociationFromDevice { get; private set; }
public VocabularyKey CatalogDefaultAttributeGroup { get; private set; }
public VocabularyKey CatalogAttributeBulkEditMaxRows { get; private set; }
public VocabularyKey CategoryDefaultAttributeGroup { get; private set; }
public VocabularyKey CustomerDefaultAttributeGroup { get; private set; }
public VocabularyKey DeviceTokenAlgorithm { get; private set; }
public VocabularyKey EarnLoyaltyOffline { get; private set; }
public VocabularyKey EFTPasswordEncryption { get; private set; }
public VocabularyKey EntityValidationTemplate { get; private set; }
public VocabularyKey ExchangeRateType { get; private set; }
public VocabularyKey HtmlAttributeType { get; private set; }
public VocabularyKey ImagesAttributeType { get; private set; }
public VocabularyKey ItemLabelCreation { get; private set; }
public VocabularyKey Key { get; private set; }
public VocabularyKey LocalStoreId { get; private set; }
public VocabularyKey ProductDefaultAttributeGroup { get; private set; }
public VocabularyKey SharepointAssetPickerUrl { get; private set; }
public VocabularyKey ShelfLabelCreation { get; private set; }
public VocabularyKey StaffPasswordHash { get; private set; }
public VocabularyKey TransactionServiceProfile { get; private set; }
public VocabularyKey TransactionServicePasswordEncryption { get; private set; }
public VocabularyKey VideosAttributeType { get; private set; }
public VocabularyKey WorkerDefaultAttributeGroup { get; private set; }
public VocabularyKey DeploymentRootPath { get; private set; }
public VocabularyKey ExchangeRateTypeName { get; private set; }
public VocabularyKey WindowsPhoneAppInsightsInstrumentationKey { get; private set; }
public VocabularyKey AsyncClientAppInsightsInstrumentationKey { get; private set; }
public VocabularyKey HardwareStationAppInsightsInstrumentationKey { get; private set; }
public VocabularyKey CloudPosAppInsightsInstrumentationKey { get; private set; }
public VocabularyKey RetailServerAppInsightsInstrumentationKey { get; private set; }
public VocabularyKey ClientAppInsightsInstrumentationKey { get; private set; }
public VocabularyKey CatalogDefaultAttributeGroupName { get; private set; }
public VocabularyKey CategoryDefaultAttributeGroupName { get; private set; }
public VocabularyKey CustomerDefaultAttributeGroupName { get; private set; }
public VocabularyKey ProductDefaultAttributeGroupName { get; private set; }
public VocabularyKey WorkerDefaultAttributeGroupName { get; private set; }
public VocabularyKey HtmlAttributeTypeName { get; private set; }
public VocabularyKey ImagesAttributeTypeName { get; private set; }
public VocabularyKey VideosAttributeTypeName { get; private set; }
public VocabularyKey PostLoyaltyPointsPerSalesLine { get; private set; }
public VocabularyKey BlockTransferBetweenDifferentLoyalty { get; private set; }
public VocabularyKey EnableOmniChannelPayments { get; private set; }
public VocabularyKey EnableFiscalIntegration { get; private set; }
public VocabularyKey RecoListEnabled { get; private set; }
public VocabularyKey RecoListBestsellingTransactionsIntervalDays { get; private set; }
public VocabularyKey RecoListTrendingMaxAgeDays { get; private set; }
public VocabularyKey RecoListTrendingTransactionsIntervalDays { get; private set; }
public VocabularyKey RecoPersonalizationEnabled { get; private set; }
public VocabularyKey EnableLocalStorageBackup { get; private set; }
public VocabularyKey UseSalesReceiptAsDefaultReceiptTypeInJournal { get; private set; }
public VocabularyKey ProductAvailabilityJobPolicy { get; private set; }
public VocabularyKey InventoryAvailabilityCachePeriod { get; private set; }
public VocabularyKey InventoryAvailabilitySumDeltaCachePeriod { get; private set; }
public VocabularyKey ValidateCustomerToRedeemLoyalty { get; private set; }
public VocabularyKey EnableAdvancedExternalGiftCard { get; private set; }
public VocabularyKey EnableKitApprovalBatchFeature { get; private set; }


    }
}