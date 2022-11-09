using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WMSItemArrivalJournalHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public WMSItemArrivalJournalHeaderV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WMSItemArrivalJournalHeaderV2Entity";
            KeyPrefix = "commonDataModel.wmsitemarrivaljournalheaderv2entity";
            KeySeparator = ".";
            Grouping = "/WMSItemArrivalJournalHeaderV2Entity";

            AddGroup("Common Data Model WMSItemArrivalJournalHeaderV2Entity Details", group =>
            {
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalDescription = group.Add(new VocabularyKey(nameof(JournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultReceivingSiteId = group.Add(new VocabularyKey(nameof(DefaultReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultReceivingWarehouseId = group.Add(new VocabularyKey(nameof(DefaultReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultReceivingWarehouseLocationId = group.Add(new VocabularyKey(nameof(DefaultReceivingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultReceivingInventoryStatusId = group.Add(new VocabularyKey(nameof(DefaultReceivingInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultReceivingLicensePlateNumber = group.Add(new VocabularyKey(nameof(DefaultReceivingLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTransactionReferenceType = group.Add(new VocabularyKey(nameof(DefaultTransactionReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultTransactionReferenceNumber = group.Add(new VocabularyKey(nameof(DefaultTransactionReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsItemMovedToDefaultItemPickingWarehouseLocation = group.Add(new VocabularyKey(nameof(IsItemMovedToDefaultItemPickingWarehouseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsQuarantineOrderCreatedForReceivedItem = group.Add(new VocabularyKey(nameof(IsQuarantineOrderCreatedForReceivedItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingSlipId = group.Add(new VocabularyKey(nameof(PackingSlipId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultReturnDispositionCodeId = group.Add(new VocabularyKey(nameof(DefaultReturnDispositionCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultReturnItemNumber = group.Add(new VocabularyKey(nameof(DefaultReturnItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultAccountNumber = group.Add(new VocabularyKey(nameof(DefaultAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostedDateTime = group.Add(new VocabularyKey(nameof(PostedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostedUserId = group.Add(new VocabularyKey(nameof(PostedUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreLinesDeletedAfterPosting = group.Add(new VocabularyKey(nameof(AreLinesDeletedAfterPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey JournalNumber { get; private set; }
public VocabularyKey JournalNameId { get; private set; }
public VocabularyKey JournalDescription { get; private set; }
public VocabularyKey DefaultReceivingSiteId { get; private set; }
public VocabularyKey DefaultReceivingWarehouseId { get; private set; }
public VocabularyKey DefaultReceivingWarehouseLocationId { get; private set; }
public VocabularyKey DefaultReceivingInventoryStatusId { get; private set; }
public VocabularyKey DefaultReceivingLicensePlateNumber { get; private set; }
public VocabularyKey DefaultTransactionReferenceType { get; private set; }
public VocabularyKey DefaultTransactionReferenceNumber { get; private set; }
public VocabularyKey IsItemMovedToDefaultItemPickingWarehouseLocation { get; private set; }
public VocabularyKey IsQuarantineOrderCreatedForReceivedItem { get; private set; }
public VocabularyKey PackingSlipId { get; private set; }
public VocabularyKey DefaultReturnDispositionCodeId { get; private set; }
public VocabularyKey DefaultReturnItemNumber { get; private set; }
public VocabularyKey DefaultAccountNumber { get; private set; }
public VocabularyKey IsPosted { get; private set; }
public VocabularyKey PostedDateTime { get; private set; }
public VocabularyKey PostedUserId { get; private set; }
public VocabularyKey AreLinesDeletedAfterPosting { get; private set; }


    }
}