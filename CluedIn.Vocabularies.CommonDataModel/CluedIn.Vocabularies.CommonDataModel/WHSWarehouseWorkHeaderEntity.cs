using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkHeaderEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkHeaderEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkheaderentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkHeaderEntity";

            AddGroup("Common Data Model WHSWarehouseWorkHeaderEntity Details", group =>
            {
                ActualProcessingTimeSeconds = group.Add(new VocabularyKey(nameof(ActualProcessingTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerId = group.Add(new VocabularyKey(nameof(ContainerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedProcessingTimeSeconds = group.Add(new VocabularyKey(nameof(EstimatedProcessingTimeSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWarehouseWorkBlocked = group.Add(new VocabularyKey(nameof(IsWarehouseWorkBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkLockingWarehouseMobileDeviceUserId = group.Add(new VocabularyKey(nameof(WarehouseWorkLockingWarehouseMobileDeviceUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceOrderNumber = group.Add(new VocabularyKey(nameof(SourceOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShipmentId = group.Add(new VocabularyKey(nameof(ShipmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TargetLicensePlateNumber = group.Add(new VocabularyKey(nameof(TargetLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWarehouseWorkerManuallyAssigned = group.Add(new VocabularyKey(nameof(IsWarehouseWorkerManuallyAssigned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveId = group.Add(new VocabularyKey(nameof(WaveId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkCancellingUserId = group.Add(new VocabularyKey(nameof(WarehouseWorkCancellingUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkCancelledDateTime = group.Add(new VocabularyKey(nameof(WarehouseWorkCancelledDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkClosedDateTime = group.Add(new VocabularyKey(nameof(WarehouseWorkClosedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkId = group.Add(new VocabularyKey(nameof(WarehouseWorkId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkProcessingStartDateTime = group.Add(new VocabularyKey(nameof(WarehouseWorkProcessingStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkManuallyCompletingUserId = group.Add(new VocabularyKey(nameof(WarehouseWorkManuallyCompletingUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkPoolId = group.Add(new VocabularyKey(nameof(WarehouseWorkPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkPriority = group.Add(new VocabularyKey(nameof(WarehouseWorkPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkStatus = group.Add(new VocabularyKey(nameof(WarehouseWorkStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ActualProcessingTimeSeconds { get; private set; }
public VocabularyKey ContainerId { get; private set; }
public VocabularyKey EstimatedProcessingTimeSeconds { get; private set; }
public VocabularyKey IsWarehouseWorkBlocked { get; private set; }
public VocabularyKey WarehouseId { get; private set; }
public VocabularyKey InventorySiteId { get; private set; }
public VocabularyKey LoadId { get; private set; }
public VocabularyKey WarehouseWorkLockingWarehouseMobileDeviceUserId { get; private set; }
public VocabularyKey SourceOrderNumber { get; private set; }
public VocabularyKey ShipmentId { get; private set; }
public VocabularyKey TargetLicensePlateNumber { get; private set; }
public VocabularyKey IsWarehouseWorkerManuallyAssigned { get; private set; }
public VocabularyKey WaveId { get; private set; }
public VocabularyKey WarehouseWorkCancellingUserId { get; private set; }
public VocabularyKey WarehouseWorkCancelledDateTime { get; private set; }
public VocabularyKey WarehouseWorkClosedDateTime { get; private set; }
public VocabularyKey WarehouseWorkId { get; private set; }
public VocabularyKey WarehouseWorkProcessingStartDateTime { get; private set; }
public VocabularyKey WarehouseWorkManuallyCompletingUserId { get; private set; }
public VocabularyKey WarehouseWorkPoolId { get; private set; }
public VocabularyKey WarehouseWorkPriority { get; private set; }
public VocabularyKey WarehouseWorkStatus { get; private set; }
public VocabularyKey WarehouseWorkOrderType { get; private set; }


    }
}