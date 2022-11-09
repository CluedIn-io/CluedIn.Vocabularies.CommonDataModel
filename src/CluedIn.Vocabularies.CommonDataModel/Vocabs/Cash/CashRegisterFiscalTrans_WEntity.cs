using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CashRegisterFiscalTrans_WEntityVocabulary : SimpleVocabulary
    {
        public CashRegisterFiscalTrans_WEntityVocabulary()
        {
            VocabularyName = "Common Data Model CashRegisterFiscalTrans_WEntity";
            KeyPrefix = "commonDataModel.cashregisterfiscaltrans_wentity";
            KeySeparator = ".";
            Grouping = "/CashRegisterFiscalTrans_WEntity";

            AddGroup("Common Data Model CashRegisterFiscalTrans_WEntity Details", group =>
            {
                IsOffline = group.Add(new VocabularyKey(nameof(IsOffline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDateTime = group.Add(new VocabularyKey(nameof(TransDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransId = group.Add(new VocabularyKey(nameof(TransId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsOffline { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey TransDateTime { get; private set; }
public VocabularyKey TransId { get; private set; }
public VocabularyKey Voucher { get; private set; }
public VocabularyKey Status { get; private set; }


    }
}