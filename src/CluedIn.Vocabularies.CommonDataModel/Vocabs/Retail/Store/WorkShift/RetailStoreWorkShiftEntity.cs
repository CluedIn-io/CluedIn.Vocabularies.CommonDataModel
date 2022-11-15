using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStoreWorkShiftEntityVocabulary : SimpleVocabulary
    {
        public RetailStoreWorkShiftEntityVocabulary()
        {
            VocabularyName = "Retail Store Work Shift Entity";
            KeyPrefix = "commonDataModel.retailstoreworkshiftentity";
            KeySeparator = ".";
            Grouping = "/RetailStoreWorkShiftEntity";

            AddGroup("RetailStoreWorkShiftEntity Details", group =>
            {
                EndingDate = group.Add(new VocabularyKey(nameof(EndingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndingTime = group.Add(new VocabularyKey(nameof(EndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplicationCounter = group.Add(new VocabularyKey(nameof(ReplicationCounter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftDate = group.Add(new VocabularyKey(nameof(ShiftDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftId = group.Add(new VocabularyKey(nameof(ShiftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartingDate = group.Add(new VocabularyKey(nameof(StartingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartingTime = group.Add(new VocabularyKey(nameof(StartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementId = group.Add(new VocabularyKey(nameof(StatementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkShiftStatus = group.Add(new VocabularyKey(nameof(WorkShiftStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EndingDate { get; private set; }
        public VocabularyKey EndingTime { get; private set; }
        public VocabularyKey ReplicationCounter { get; private set; }
        public VocabularyKey ShiftDate { get; private set; }
        public VocabularyKey ShiftId { get; private set; }
        public VocabularyKey StartingDate { get; private set; }
        public VocabularyKey StartingTime { get; private set; }
        public VocabularyKey StatementId { get; private set; }
        public VocabularyKey WorkShiftStatus { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }
    }
}