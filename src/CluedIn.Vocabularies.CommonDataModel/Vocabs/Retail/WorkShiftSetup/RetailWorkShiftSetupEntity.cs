using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailWorkShiftSetupEntityVocabulary : SimpleVocabulary
    {
        public RetailWorkShiftSetupEntityVocabulary()
        {
            VocabularyName = "Retail Work Shift Setup Entity";
            KeyPrefix = "commonDataModel.retailworkshiftsetupentity";
            KeySeparator = ".";
            Grouping = "/RetailWorkShiftSetupEntity";

            AddGroup("RetailWorkShiftSetupEntity Details", group =>
            {
                Abbreviation = group.Add(new VocabularyKey(nameof(Abbreviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbbreviationText = group.Add(new VocabularyKey(nameof(AbbreviationText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateReference = group.Add(new VocabularyKey(nameof(DateReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndingTime = group.Add(new VocabularyKey(nameof(EndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreRecId = group.Add(new VocabularyKey(nameof(StoreRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkShiftId = group.Add(new VocabularyKey(nameof(WorkShiftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Abbreviation { get; private set; }
        public VocabularyKey AbbreviationText { get; private set; }
        public VocabularyKey DateReference { get; private set; }
        public VocabularyKey EndingTime { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey StoreRecId { get; private set; }
        public VocabularyKey WorkShiftId { get; private set; }
        public VocabularyKey OMOperatingUnitNumber { get; private set; }
    }
}