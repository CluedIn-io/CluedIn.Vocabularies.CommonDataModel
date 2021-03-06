using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCustPaymModeBankAccountsEntityVocabulary : SimpleVocabulary
    {
        public BankCustPaymModeBankAccountsEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankCustPaymModeBankAccountsEntity";
            KeyPrefix = "commonDataModel.bankcustpaymmodebankaccountsentity";
            KeySeparator = ".";
            Grouping = "/BankCustPaymModeBankAccountsEntity";

            AddGroup("Common Data Model BankCustPaymModeBankAccountsEntity Details", group =>
            {
                BankAccountID = group.Add(new VocabularyKey(nameof(BankAccountID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymMode = group.Add(new VocabularyKey(nameof(PaymMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BankAccountID { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey LineId { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
public VocabularyKey PaymMode { get; private set; }


    }
}