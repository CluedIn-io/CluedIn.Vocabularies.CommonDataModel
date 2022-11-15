using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalCalendarEntityVocabulary : SimpleVocabulary
    {
        public FiscalCalendarEntityVocabulary()
        {
            VocabularyName = "Fiscal Calendar Entity";
            KeyPrefix = "commonDataModel.fiscalcalendarentity";
            KeySeparator = ".";
            Grouping = "/FiscalCalendarEntity";

            AddGroup("FiscalCalendarEntity Details", group =>
            {
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}