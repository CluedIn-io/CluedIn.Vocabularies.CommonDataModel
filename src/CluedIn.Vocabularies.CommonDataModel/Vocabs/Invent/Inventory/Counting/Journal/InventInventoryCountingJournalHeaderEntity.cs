using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryCountingJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryCountingJournalHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryCountingJournalHeaderEntity";
            KeyPrefix = "commonDataModel.inventinventorycountingjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryCountingJournalHeaderEntity";

            AddGroup("Common Data Model InventInventoryCountingJournalHeaderEntity Details", group =>
            {
                AreLinesDeletedAfterPosting = group.Add(new VocabularyKey(nameof(AreLinesDeletedAfterPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDetailLevel = group.Add(new VocabularyKey(nameof(PostingDetailLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventorySiteId = group.Add(new VocabularyKey(nameof(DefaultInventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWarehouseId = group.Add(new VocabularyKey(nameof(DefaultWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedDateTime = group.Add(new VocabularyKey(nameof(PostedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedUserId = group.Add(new VocabularyKey(nameof(PostedUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservationMode = group.Add(new VocabularyKey(nameof(ReservationMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumberSelectionRule = group.Add(new VocabularyKey(nameof(VoucherNumberSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumberAllocationRule = group.Add(new VocabularyKey(nameof(VoucherNumberAllocationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumberSequenceRecId = group.Add(new VocabularyKey(nameof(VoucherNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumberSequenceCode = group.Add(new VocabularyKey(nameof(VoucherNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerRecId = group.Add(new VocabularyKey(nameof(WorkerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimFixed = group.Add(new VocabularyKey(nameof(InventDimFixed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingWarehouseSpecific = group.Add(new VocabularyKey(nameof(IsCountingWarehouseSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingInventoryStatusSpecific = group.Add(new VocabularyKey(nameof(IsCountingInventoryStatusSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingWarehouseLocationSpecific = group.Add(new VocabularyKey(nameof(IsCountingWarehouseLocationSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingLicensePlateSpecific = group.Add(new VocabularyKey(nameof(IsCountingLicensePlateSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingItemBatchSpecific = group.Add(new VocabularyKey(nameof(IsCountingItemBatchSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingItemSerialNumberSpecific = group.Add(new VocabularyKey(nameof(IsCountingItemSerialNumberSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountingStatusRegistrationPolicy = group.Add(new VocabularyKey(nameof(CountingStatusRegistrationPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AreLinesDeletedAfterPosting { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PostingDetailLevel { get; private set; }
        public VocabularyKey DefaultInventorySiteId { get; private set; }
        public VocabularyKey DefaultWarehouseId { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey PostedDateTime { get; private set; }
        public VocabularyKey PostedUserId { get; private set; }
        public VocabularyKey ReservationMode { get; private set; }
        public VocabularyKey VoucherNumberSelectionRule { get; private set; }
        public VocabularyKey VoucherNumberAllocationRule { get; private set; }
        public VocabularyKey VoucherNumberSequenceRecId { get; private set; }
        public VocabularyKey VoucherNumberSequenceCode { get; private set; }
        public VocabularyKey WorkerRecId { get; private set; }
        public VocabularyKey WorkerPersonnelNumber { get; private set; }
        public VocabularyKey InventDimFixed { get; private set; }
        public VocabularyKey IsCountingWarehouseSpecific { get; private set; }
        public VocabularyKey IsCountingInventoryStatusSpecific { get; private set; }
        public VocabularyKey IsCountingWarehouseLocationSpecific { get; private set; }
        public VocabularyKey IsCountingLicensePlateSpecific { get; private set; }
        public VocabularyKey IsCountingItemBatchSpecific { get; private set; }
        public VocabularyKey IsCountingItemSerialNumberSpecific { get; private set; }
        public VocabularyKey CountingStatusRegistrationPolicy { get; private set; }


    }
}