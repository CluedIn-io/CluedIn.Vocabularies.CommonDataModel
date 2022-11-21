using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFiscalCloseGroupEntityVocabulary : SimpleVocabulary
    {
        public LedgerFiscalCloseGroupEntityVocabulary()
        {
            VocabularyName = "Ledger Fiscal Close Group Entity";
            KeyPrefix = "commonDataModel.ledgerfiscalclosegroupentity";
            KeySeparator = ".";
            Grouping = "/LedgerFiscalCloseGroupEntity";

            AddGroup("LedgerFiscalCloseGroupEntity Details", group =>
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