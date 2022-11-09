using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBICustTransVocabulary : SimpleVocabulary
    {
        public CustCollectionsBICustTransVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBICustTrans";
            KeyPrefix = "commonDataModel.custcollectionsbicusttrans";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBICustTrans";

            AddGroup("Common Data Model CustCollectionsBICustTrans Details", group =>
            {
                AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetter = group.Add(new VocabularyKey(nameof(CollectionLetter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetterCode = group.Add(new VocabularyKey(nameof(CollectionLetterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditMax = group.Add(new VocabularyKey(nameof(CreditMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditRating = group.Add(new VocabularyKey(nameof(CreditRating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CrossRate = group.Add(new VocabularyKey(nameof(CrossRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustTransOpenRecId = group.Add(new VocabularyKey(nameof(CustTransOpenRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustTransRecId = group.Add(new VocabularyKey(nameof(CustTransRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustTransSystemCurrencyAmount = group.Add(new VocabularyKey(nameof(CustTransSystemCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustTransTableId = group.Add(new VocabularyKey(nameof(CustTransTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GregorianDate = group.Add(new VocabularyKey(nameof(GregorianDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OpenAmountMST = group.Add(new VocabularyKey(nameof(OpenAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OpenSystemCurrencyAmount = group.Add(new VocabularyKey(nameof(OpenSystemCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Party = group.Add(new VocabularyKey(nameof(Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonRefRecId = group.Add(new VocabularyKey(nameof(ReasonRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SystemCurrencyCode = group.Add(new VocabularyKey(nameof(SystemCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SystemCurrencyCreditMax = group.Add(new VocabularyKey(nameof(SystemCurrencyCreditMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isDSO30 = group.Add(new VocabularyKey(nameof(isDSO30), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FollowUpDate = group.Add(new VocabularyKey(nameof(FollowUpDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisputeStatusTranslated = group.Add(new VocabularyKey(nameof(DisputeStatusTranslated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountingCurrency { get; private set; }
public VocabularyKey AccountNum { get; private set; }
public VocabularyKey CollectionLetter { get; private set; }
public VocabularyKey CollectionLetterCode { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey CreditMax { get; private set; }
public VocabularyKey CreditRating { get; private set; }
public VocabularyKey CrossRate { get; private set; }
public VocabularyKey CustTransOpenRecId { get; private set; }
public VocabularyKey CustTransRecId { get; private set; }
public VocabularyKey CustTransSystemCurrencyAmount { get; private set; }
public VocabularyKey CustTransTableId { get; private set; }
public VocabularyKey DueDate { get; private set; }
public VocabularyKey GregorianDate { get; private set; }
public VocabularyKey Invoice { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey OpenAmountMST { get; private set; }
public VocabularyKey OpenSystemCurrencyAmount { get; private set; }
public VocabularyKey Party { get; private set; }
public VocabularyKey ReasonRefRecId { get; private set; }
public VocabularyKey SystemCurrencyCode { get; private set; }
public VocabularyKey SystemCurrencyCreditMax { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey TransType { get; private set; }
public VocabularyKey Voucher { get; private set; }
public VocabularyKey isDSO30 { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey FollowUpDate { get; private set; }
public VocabularyKey DisputeStatusTranslated { get; private set; }


    }
}