using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailIncomeExpenseAccountEntityVocabulary : SimpleVocabulary
    {
        public RetailIncomeExpenseAccountEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailIncomeExpenseAccountEntity";
            KeyPrefix = "commonDataModel.retailincomeexpenseaccountentity";
            KeySeparator = ".";
            Grouping = "/RetailIncomeExpenseAccountEntity";

            AddGroup("Common Data Model RetailIncomeExpenseAccountEntity Details", group =>
            {
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerAccount = group.Add(new VocabularyKey(nameof(LedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MessageLine1 = group.Add(new VocabularyKey(nameof(MessageLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MessageLine2 = group.Add(new VocabularyKey(nameof(MessageLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SlipText1 = group.Add(new VocabularyKey(nameof(SlipText1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SlipText2 = group.Add(new VocabularyKey(nameof(SlipText2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountNumber { get; private set; }
public VocabularyKey AccountType { get; private set; }
public VocabularyKey LedgerAccount { get; private set; }
public VocabularyKey MessageLine1 { get; private set; }
public VocabularyKey MessageLine2 { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey SearchName { get; private set; }
public VocabularyKey SlipText1 { get; private set; }
public VocabularyKey SlipText2 { get; private set; }
public VocabularyKey StoreNumber { get; private set; }
public VocabularyKey LedgerAccountDisplayValue { get; private set; }


    }
}