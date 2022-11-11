using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStoreWorkShiftTranEntityVocabulary : SimpleVocabulary
    {
        public RetailStoreWorkShiftTranEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailStoreWorkShiftTranEntity";
            KeyPrefix = "commonDataModel.retailstoreworkshifttranentity";
            KeySeparator = ".";
            Grouping = "/RetailStoreWorkShiftTranEntity";

            AddGroup("Common Data Model RetailStoreWorkShiftTranEntity Details", group =>
            {
                ClosingDate = group.Add(new VocabularyKey(nameof(ClosingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosingTime = group.Add(new VocabularyKey(nameof(ClosingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpeningDate = group.Add(new VocabularyKey(nameof(OpeningDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpeningTime = group.Add(new VocabularyKey(nameof(OpeningTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftDate = group.Add(new VocabularyKey(nameof(ShiftDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftId = group.Add(new VocabularyKey(nameof(ShiftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementCode = group.Add(new VocabularyKey(nameof(StatementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementMethod = group.Add(new VocabularyKey(nameof(StatementMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreRecId = group.Add(new VocabularyKey(nameof(StoreRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ClosingDate { get; private set; }
        public VocabularyKey ClosingTime { get; private set; }
        public VocabularyKey OpeningDate { get; private set; }
        public VocabularyKey OpeningTime { get; private set; }
        public VocabularyKey ShiftDate { get; private set; }
        public VocabularyKey ShiftId { get; private set; }
        public VocabularyKey StatementCode { get; private set; }
        public VocabularyKey StatementMethod { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StoreRecId { get; private set; }
        public VocabularyKey OMOperatingUnitNumber { get; private set; }


    }
}