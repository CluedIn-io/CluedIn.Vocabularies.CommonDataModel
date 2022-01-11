using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashAccountsEntityVocabulary : SimpleVocabulary
    {
        public CashAccountsEntityVocabulary()
        {
            VocabularyName = "Common Data Model CashAccountsEntity";
            KeyPrefix = "commonDataModel.cashaccountsentity";
            KeySeparator = ".";
            Grouping = "/CashAccountsEntity";

            AddGroup("Common Data Model CashAccountsEntity Details", group =>
            {
                Cash = group.Add(new VocabularyKey(nameof(Cash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MoreCurrencies = group.Add(new VocabularyKey(nameof(MoreCurrencies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NegativeCash = group.Add(new VocabularyKey(nameof(NegativeCash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Cash { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey MoreCurrencies { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey NegativeCash { get; private set; }
public VocabularyKey NumberSequenceGroup { get; private set; }


    }
}