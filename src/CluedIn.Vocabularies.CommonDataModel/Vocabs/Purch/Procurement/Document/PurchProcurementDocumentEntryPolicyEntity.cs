using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchProcurementDocumentEntryPolicyEntityVocabulary : SimpleVocabulary
    {
        public PurchProcurementDocumentEntryPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchProcurementDocumentEntryPolicyEntity";
            KeyPrefix = "commonDataModel.purchprocurementdocumententrypolicyentity";
            KeySeparator = ".";
            Grouping = "/PurchProcurementDocumentEntryPolicyEntity";

            AddGroup("Common Data Model PurchProcurementDocumentEntryPolicyEntity Details", group =>
            {
                AreFactBoxesAutomaticallyRecalculated = group.Add(new VocabularyKey(nameof(AreFactBoxesAutomaticallyRecalculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillDocumentEntryAutomaticallyAllocateHeaderLevelCharges = group.Add(new VocabularyKey(nameof(WillDocumentEntryAutomaticallyAllocateHeaderLevelCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillDocumentEntryAutomaticallyAllocateLineLevelCharges = group.Add(new VocabularyKey(nameof(WillDocumentEntryAutomaticallyAllocateLineLevelCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillDocumentEntryRecordPriceDetails = group.Add(new VocabularyKey(nameof(WillDocumentEntryRecordPriceDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillDocumentEntryDisplayPriceMarginAlerts = group.Add(new VocabularyKey(nameof(WillDocumentEntryDisplayPriceMarginAlerts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePurchaseCyclesActivated = group.Add(new VocabularyKey(nameof(ArePurchaseCyclesActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicedPurchaseOrderMaintenanceRule = group.Add(new VocabularyKey(nameof(InvoicedPurchaseOrderMaintenanceRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsChangeManagementActivated = group.Add(new VocabularyKey(nameof(IsChangeManagementActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsChangeManagementActivationOverridable = group.Add(new VocabularyKey(nameof(IsChangeManagementActivationOverridable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseOrderLineAgreementLineMatched = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderLineAgreementLineMatched), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSentRFQLocked = group.Add(new VocabularyKey(nameof(IsSentRFQLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsVendorInformationTransferBeingPrompted = group.Add(new VocabularyKey(nameof(IsVendorInformationTransferBeingPrompted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineLevelDiscountCalculationRule = group.Add(new VocabularyKey(nameof(LineLevelDiscountCalculationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceMarginThresholdRule = group.Add(new VocabularyKey(nameof(PriceMarginThresholdRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAgreementSearchDateType = group.Add(new VocabularyKey(nameof(TradeAgreementSearchDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AreFactBoxesAutomaticallyRecalculated { get; private set; }
public VocabularyKey WillDocumentEntryAutomaticallyAllocateHeaderLevelCharges { get; private set; }
public VocabularyKey WillDocumentEntryAutomaticallyAllocateLineLevelCharges { get; private set; }
public VocabularyKey WillDocumentEntryRecordPriceDetails { get; private set; }
public VocabularyKey WillDocumentEntryDisplayPriceMarginAlerts { get; private set; }
public VocabularyKey ArePurchaseCyclesActivated { get; private set; }
public VocabularyKey InvoicedPurchaseOrderMaintenanceRule { get; private set; }
public VocabularyKey IsChangeManagementActivated { get; private set; }
public VocabularyKey IsChangeManagementActivationOverridable { get; private set; }
public VocabularyKey IsIntercompanyPurchaseOrderLineAgreementLineMatched { get; private set; }
public VocabularyKey IsSentRFQLocked { get; private set; }
public VocabularyKey IsVendorInformationTransferBeingPrompted { get; private set; }
public VocabularyKey LineLevelDiscountCalculationRule { get; private set; }
public VocabularyKey PriceMarginThresholdRule { get; private set; }
public VocabularyKey TradeAgreementSearchDateType { get; private set; }


    }
}