using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerReportingCurrencyAdjustmentJournalLineEntityVocabulary : SimpleVocabulary
    {
        public LedgerReportingCurrencyAdjustmentJournalLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerReportingCurrencyAdjustmentJournalLineEntity";
            KeyPrefix = "commonDataModel.ledgerreportingcurrencyadjustmentjournallineentity";
            KeySeparator = ".";
            Grouping = "/LedgerReportingCurrencyAdjustmentJournalLineEntity";

            AddGroup("Common Data Model LedgerReportingCurrencyAdjustmentJournalLineEntity Details", group =>
            {
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TransDate { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey Account { get; private set; }
public VocabularyKey Text { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey DebitAmount { get; private set; }
public VocabularyKey CreditAmount { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey JournalBatchNumber { get; private set; }
public VocabularyKey AccountType { get; private set; }
public VocabularyKey AccountDisplayValue { get; private set; }
public VocabularyKey JournalName { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}