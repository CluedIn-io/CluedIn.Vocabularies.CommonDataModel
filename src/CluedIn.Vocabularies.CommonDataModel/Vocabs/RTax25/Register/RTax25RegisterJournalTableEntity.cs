using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25RegisterJournalTableEntityVocabulary : SimpleVocabulary
    {
        public RTax25RegisterJournalTableEntityVocabulary()
        {
            VocabularyName = "RTax25RegisterJournalTableEntity";
            KeyPrefix = "commonDataModel.rtax25registerjournaltableentity";
            KeySeparator = ".";
            Grouping = "/RTax25RegisterJournalTableEntity";

            AddGroup("RTax25RegisterJournalTableEntity Details", group =>
            {
                FinishDate = group.Add(new VocabularyKey(nameof(FinishDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Years = group.Add(new VocabularyKey(nameof(Years), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNumber = group.Add(new VocabularyKey(nameof(JournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodNumber = group.Add(new VocabularyKey(nameof(PeriodNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodTypes = group.Add(new VocabularyKey(nameof(PeriodTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationDate = group.Add(new VocabularyKey(nameof(CalculationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FinishDate { get; private set; }
        public VocabularyKey Years { get; private set; }
        public VocabularyKey JournalNumber { get; private set; }
        public VocabularyKey JournalType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PeriodNumber { get; private set; }
        public VocabularyKey PeriodTypes { get; private set; }
        public VocabularyKey CalculationDate { get; private set; }


    }
}