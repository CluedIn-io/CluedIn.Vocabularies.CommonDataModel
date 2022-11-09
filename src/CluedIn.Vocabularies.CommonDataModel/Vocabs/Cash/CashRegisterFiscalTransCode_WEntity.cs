using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashRegisterFiscalTransCode_WEntityVocabulary : SimpleVocabulary
    {
        public CashRegisterFiscalTransCode_WEntityVocabulary()
        {
            VocabularyName = "Common Data Model CashRegisterFiscalTransCode_WEntity";
            KeyPrefix = "commonDataModel.cashregisterfiscaltranscode_wentity";
            KeySeparator = ".";
            Grouping = "/CashRegisterFiscalTransCode_WEntity";

            AddGroup("Common Data Model CashRegisterFiscalTransCode_WEntity Details", group =>
            {
                Label = group.Add(new VocabularyKey(nameof(Label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Label { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Value { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey Voucher { get; private set; }


    }
}