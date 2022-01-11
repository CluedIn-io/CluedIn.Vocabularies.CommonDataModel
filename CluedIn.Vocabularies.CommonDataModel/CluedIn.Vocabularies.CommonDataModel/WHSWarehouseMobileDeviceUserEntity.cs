using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceUserEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceUserEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseMobileDeviceUserEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledeviceuserentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceUserEntity";

            AddGroup("Common Data Model WHSWarehouseMobileDeviceUserEntity Details", group =>
            {
                WarehouseWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WarehouseWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserName = group.Add(new VocabularyKey(nameof(UserName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultWarehouseId = group.Add(new VocabularyKey(nameof(DefaultWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultMobileDeviceMenuItemName = group.Add(new VocabularyKey(nameof(DefaultMobileDeviceMenuItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInactive = group.Add(new VocabularyKey(nameof(IsInactive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWarehousePickLocationOverrideAllowed = group.Add(new VocabularyKey(nameof(IsWarehousePickLocationOverrideAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWarehousePutLocationOverrideAllowed = group.Add(new VocabularyKey(nameof(IsWarehousePutLocationOverrideAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCountingSupervisor = group.Add(new VocabularyKey(nameof(IsCountingSupervisor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountingApprovalPercentageLimit = group.Add(new VocabularyKey(nameof(CountingApprovalPercentageLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountingApprovalQuantityLimit = group.Add(new VocabularyKey(nameof(CountingApprovalQuantityLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountingApprovalValueLimit = group.Add(new VocabularyKey(nameof(CountingApprovalValueLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkerId = group.Add(new VocabularyKey(nameof(WarehouseWorkerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAutomatedWarehouseWorkUser = group.Add(new VocabularyKey(nameof(IsAutomatedWarehouseWorkUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInventoryMovementWithAssociatedWorkAllowed = group.Add(new VocabularyKey(nameof(IsInventoryMovementWithAssociatedWorkAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSalesOrderOverpickingAllowed = group.Add(new VocabularyKey(nameof(IsSalesOrderOverpickingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTransferOrderOverpickingAllowed = group.Add(new VocabularyKey(nameof(IsTransferOrderOverpickingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsManualItemReallocationAllowed = group.Add(new VocabularyKey(nameof(IsManualItemReallocationAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WarehouseWorkerPersonnelNumber { get; private set; }
public VocabularyKey UserId { get; private set; }
public VocabularyKey UserName { get; private set; }
public VocabularyKey DefaultWarehouseId { get; private set; }
public VocabularyKey DefaultMobileDeviceMenuItemName { get; private set; }
public VocabularyKey IsInactive { get; private set; }
public VocabularyKey IsWarehousePickLocationOverrideAllowed { get; private set; }
public VocabularyKey IsWarehousePutLocationOverrideAllowed { get; private set; }
public VocabularyKey IsCountingSupervisor { get; private set; }
public VocabularyKey CountingApprovalPercentageLimit { get; private set; }
public VocabularyKey CountingApprovalQuantityLimit { get; private set; }
public VocabularyKey CountingApprovalValueLimit { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey WarehouseWorkerId { get; private set; }
public VocabularyKey IsAutomatedWarehouseWorkUser { get; private set; }
public VocabularyKey IsInventoryMovementWithAssociatedWorkAllowed { get; private set; }
public VocabularyKey IsSalesOrderOverpickingAllowed { get; private set; }
public VocabularyKey IsTransferOrderOverpickingAllowed { get; private set; }
public VocabularyKey IsManualItemReallocationAllowed { get; private set; }


    }
}