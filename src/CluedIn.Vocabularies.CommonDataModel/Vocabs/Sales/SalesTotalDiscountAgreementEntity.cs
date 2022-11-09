using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesTotalDiscountAgreementEntityVocabulary : SimpleVocabulary
    {
        public SalesTotalDiscountAgreementEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesTotalDiscountAgreementEntity";
            KeyPrefix = "commonDataModel.salestotaldiscountagreemententity";
            KeySeparator = ".";
            Grouping = "/SalesTotalDiscountAgreementEntity";

            AddGroup("Common Data Model SalesTotalDiscountAgreementEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountCurrencyCode = group.Add(new VocabularyKey(nameof(DiscountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountApplicableFromDate = group.Add(new VocabularyKey(nameof(DiscountApplicableFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountPercentage1 = group.Add(new VocabularyKey(nameof(DiscountPercentage1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountPercentage2 = group.Add(new VocabularyKey(nameof(DiscountPercentage2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromOrderSubtotalAmount = group.Add(new VocabularyKey(nameof(FromOrderSubtotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToOrderSubtotalAmount = group.Add(new VocabularyKey(nameof(ToOrderSubtotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillSearchContinue = group.Add(new VocabularyKey(nameof(WillSearchContinue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountApplicableToDate = group.Add(new VocabularyKey(nameof(DiscountApplicableToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountCode { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey DiscountAmount { get; private set; }
public VocabularyKey DiscountCurrencyCode { get; private set; }
public VocabularyKey DiscountApplicableFromDate { get; private set; }
public VocabularyKey InventDimId { get; private set; }
public VocabularyKey ItemCode { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey DiscountPercentage1 { get; private set; }
public VocabularyKey DiscountPercentage2 { get; private set; }
public VocabularyKey FromOrderSubtotalAmount { get; private set; }
public VocabularyKey ToOrderSubtotalAmount { get; private set; }
public VocabularyKey WillSearchContinue { get; private set; }
public VocabularyKey DiscountApplicableToDate { get; private set; }
public VocabularyKey RecordId { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey TotalDiscountCustomerGroupCode { get; private set; }


    }
}