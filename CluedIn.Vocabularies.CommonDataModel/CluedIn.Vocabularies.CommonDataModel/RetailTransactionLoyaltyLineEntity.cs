using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionLoyaltyLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionLoyaltyLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionLoyaltyLineEntity";
            KeyPrefix = "commonDataModel.retailtransactionloyaltylineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionLoyaltyLineEntity";

            AddGroup("Common Data Model RetailTransactionLoyaltyLineEntity Details", group =>
            {
                AffiliationId = group.Add(new VocabularyKey(nameof(AffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptId = group.Add(new VocabularyKey(nameof(ReceiptId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OMOperatingUnitId = group.Add(new VocabularyKey(nameof(OMOperatingUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailLoyaltyTierAffiliation = group.Add(new VocabularyKey(nameof(RetailLoyaltyTierAffiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyName = group.Add(new VocabularyKey(nameof(LoyaltyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AffiliationId { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey LoyaltyTier { get; private set; }
public VocabularyKey ReceiptId { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey OMOperatingUnitId { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey RetailLoyaltyTierAffiliation { get; private set; }
public VocabularyKey LoyaltyTierId { get; private set; }
public VocabularyKey LoyaltyName { get; private set; }


    }
}