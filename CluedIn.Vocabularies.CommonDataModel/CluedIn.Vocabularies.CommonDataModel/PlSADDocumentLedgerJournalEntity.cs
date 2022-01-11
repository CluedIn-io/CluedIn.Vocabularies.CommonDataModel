using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADDocumentLedgerJournalEntityVocabulary : SimpleVocabulary
    {
        public PlSADDocumentLedgerJournalEntityVocabulary()
        {
            VocabularyName = "Common Data Model PlSADDocumentLedgerJournalEntity";
            KeyPrefix = "commonDataModel.plsaddocumentledgerjournalentity";
            KeySeparator = ".";
            Grouping = "/PlSADDocumentLedgerJournalEntity";

            AddGroup("Common Data Model PlSADDocumentLedgerJournalEntity Details", group =>
            {
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SADDate = group.Add(new VocabularyKey(nameof(SADDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DutyGovernment = group.Add(new VocabularyKey(nameof(DutyGovernment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MiscPayments = group.Add(new VocabularyKey(nameof(MiscPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SADNumber = group.Add(new VocabularyKey(nameof(SADNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Carrier = group.Add(new VocabularyKey(nameof(Carrier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateOfVATRegister = group.Add(new VocabularyKey(nameof(DateOfVATRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Currency { get; private set; }
public VocabularyKey ExchangeRate { get; private set; }
public VocabularyKey SADDate { get; private set; }
public VocabularyKey DutyGovernment { get; private set; }
public VocabularyKey MiscPayments { get; private set; }
public VocabularyKey SADNumber { get; private set; }
public VocabularyKey Transport { get; private set; }
public VocabularyKey Carrier { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey DateOfVATRegister { get; private set; }


    }
}