using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryPolicyEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryPolicyEntity";
            KeyPrefix = "commonDataModel.inventinventorypolicyentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryPolicyEntity";

            AddGroup("Common Data Model InventInventoryPolicyEntity Details", group =>
            {
                PolicyId = group.Add(new VocabularyKey(nameof(PolicyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsNegativePhysicalInventoryAllowed = group.Add(new VocabularyKey(nameof(IsNegativePhysicalInventoryAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsNegativeFinancialInventoryAllowed = group.Add(new VocabularyKey(nameof(IsNegativeFinancialInventoryAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreQuarantineManagementProcessesEnabled = group.Add(new VocabularyKey(nameof(AreQuarantineManagementProcessesEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRegistrationRequired = group.Add(new VocabularyKey(nameof(IsRegistrationRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingRequired = group.Add(new VocabularyKey(nameof(IsReceivingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPickingRequired = group.Add(new VocabularyKey(nameof(IsPickingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeductionRequired = group.Add(new VocabularyKey(nameof(IsDeductionRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillInventoryReservationUseFIFOReservation = group.Add(new VocabularyKey(nameof(WillInventoryReservationUseFIFOReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShouldFIFODateReserveBackwards = group.Add(new VocabularyKey(nameof(ShouldFIFODateReserveBackwards), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesReservationMode = group.Add(new VocabularyKey(nameof(DefaultSalesReservationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillInventoryReservationReserveSameBatch = group.Add(new VocabularyKey(nameof(WillInventoryReservationReserveSameBatch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShouldConsolidateSameBatchReservations = group.Add(new VocabularyKey(nameof(ShouldConsolidateSameBatchReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillInventoryReservationUseFEFOReservation = group.Add(new VocabularyKey(nameof(WillInventoryReservationUseFEFOReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FEFODateControlledInventoryReservationCriteria = group.Add(new VocabularyKey(nameof(FEFODateControlledInventoryReservationCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchDispositionCode = group.Add(new VocabularyKey(nameof(BatchDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillRegistrationProvideVendorBatchDetails = group.Add(new VocabularyKey(nameof(WillRegistrationProvideVendorBatchDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApprovedVendorCheckMethod = group.Add(new VocabularyKey(nameof(ApprovedVendorCheckMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PolicyId { get; private set; }
public VocabularyKey IsNegativePhysicalInventoryAllowed { get; private set; }
public VocabularyKey IsNegativeFinancialInventoryAllowed { get; private set; }
public VocabularyKey AreQuarantineManagementProcessesEnabled { get; private set; }
public VocabularyKey IsRegistrationRequired { get; private set; }
public VocabularyKey IsReceivingRequired { get; private set; }
public VocabularyKey IsPickingRequired { get; private set; }
public VocabularyKey IsDeductionRequired { get; private set; }
public VocabularyKey WillInventoryReservationUseFIFOReservation { get; private set; }
public VocabularyKey ShouldFIFODateReserveBackwards { get; private set; }
public VocabularyKey DefaultSalesReservationMode { get; private set; }
public VocabularyKey WillInventoryReservationReserveSameBatch { get; private set; }
public VocabularyKey ShouldConsolidateSameBatchReservations { get; private set; }
public VocabularyKey WillInventoryReservationUseFEFOReservation { get; private set; }
public VocabularyKey FEFODateControlledInventoryReservationCriteria { get; private set; }
public VocabularyKey BatchDispositionCode { get; private set; }
public VocabularyKey WillRegistrationProvideVendorBatchDetails { get; private set; }
public VocabularyKey ApprovedVendorCheckMethod { get; private set; }


    }
}