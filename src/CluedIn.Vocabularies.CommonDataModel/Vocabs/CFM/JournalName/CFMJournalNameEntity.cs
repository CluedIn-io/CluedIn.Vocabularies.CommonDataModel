using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMJournalNameEntityVocabulary : SimpleVocabulary
    {
        public CFMJournalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFMJournalNameEntity";
            KeyPrefix = "commonDataModel.cfmjournalnameentity";
            KeySeparator = ".";
            Grouping = "/CFMJournalNameEntity";

            AddGroup("Common Data Model CFMJournalNameEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeEmptyPaymentAccount = group.Add(new VocabularyKey(nameof(IncludeEmptyPaymentAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OverduePayments = group.Add(new VocabularyKey(nameof(OverduePayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentOnCashDiscountDate = group.Add(new VocabularyKey(nameof(PaymentOnCashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowActive = group.Add(new VocabularyKey(nameof(WorkflowActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowID = group.Add(new VocabularyKey(nameof(WorkflowID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey IncludeEmptyPaymentAccount { get; private set; }
public VocabularyKey OverduePayments { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey JournalType { get; private set; }
public VocabularyKey PaymentOnCashDiscountDate { get; private set; }
public VocabularyKey WorkflowActive { get; private set; }
public VocabularyKey WorkflowID { get; private set; }


    }
}