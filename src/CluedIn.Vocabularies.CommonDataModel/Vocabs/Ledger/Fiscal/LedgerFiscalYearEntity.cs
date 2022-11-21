using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFiscalYearEntityVocabulary : SimpleVocabulary
    {
        public LedgerFiscalYearEntityVocabulary()
        {
            VocabularyName = "Ledger Fiscal Year Entity";
            KeyPrefix = "commonDataModel.ledgerfiscalyearentity";
            KeySeparator = ".";
            Grouping = "/LedgerFiscalYearEntity";

            AddGroup("LedgerFiscalYearEntity Details", group =>
            {
                FiscalYear = group.Add(new VocabularyKey(nameof(FiscalYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Calendar = group.Add(new VocabularyKey(nameof(Calendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarYearRecId = group.Add(new VocabularyKey(nameof(FiscalCalendarYearRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarRecId = group.Add(new VocabularyKey(nameof(FiscalCalendarRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerRecId = group.Add(new VocabularyKey(nameof(LedgerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityName = group.Add(new VocabularyKey(nameof(LegalEntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FiscalYear { get; private set; }
        public VocabularyKey Calendar { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey FiscalCalendarYearRecId { get; private set; }
        public VocabularyKey FiscalCalendarRecId { get; private set; }
        public VocabularyKey LedgerRecId { get; private set; }
        public VocabularyKey LegalEntityName { get; private set; }
    }
}