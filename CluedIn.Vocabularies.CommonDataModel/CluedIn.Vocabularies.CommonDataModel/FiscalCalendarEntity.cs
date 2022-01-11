using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalCalendarEntityVocabulary : SimpleVocabulary
    {
        public FiscalCalendarEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalCalendarEntity";
            KeyPrefix = "commonDataModel.fiscalcalendarentity";
            KeySeparator = ".";
            Grouping = "/FiscalCalendarEntity";

            AddGroup("Common Data Model FiscalCalendarEntity Details", group =>
            {
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CalendarId { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}