using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFiscalCloseGroupEntityVocabulary : SimpleVocabulary
    {
        public LedgerFiscalCloseGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerFiscalCloseGroupEntity";
            KeyPrefix = "commonDataModel.ledgerfiscalclosegroupentity";
            KeySeparator = ".";
            Grouping = "/LedgerFiscalCloseGroupEntity";

            AddGroup("Common Data Model LedgerFiscalCloseGroupEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey FiscalCalendar { get; private set; }
public VocabularyKey CalendarId { get; private set; }


    }
}