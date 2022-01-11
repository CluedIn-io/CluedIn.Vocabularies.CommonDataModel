using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionDiscountLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionDiscountLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionDiscountLineEntity";
            KeyPrefix = "commonDataModel.retailtransactiondiscountlineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionDiscountLineEntity";

            AddGroup("Common Data Model RetailTransactionDiscountLineEntity Details", group =>
            {
                EffectiveAmount = group.Add(new VocabularyKey(nameof(EffectiveAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerDiscountType = group.Add(new VocabularyKey(nameof(CustomerDiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DealPrice = group.Add(new VocabularyKey(nameof(DealPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountCode = group.Add(new VocabularyKey(nameof(DiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountOriginType = group.Add(new VocabularyKey(nameof(DiscountOriginType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ManualDiscountType = group.Add(new VocabularyKey(nameof(ManualDiscountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DiscountOfferId = group.Add(new VocabularyKey(nameof(DiscountOfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesLineNumber = group.Add(new VocabularyKey(nameof(SalesLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BundleId = group.Add(new VocabularyKey(nameof(BundleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EffectiveAmount { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey CustomerDiscountType { get; private set; }
public VocabularyKey DealPrice { get; private set; }
public VocabularyKey DiscountAmount { get; private set; }
public VocabularyKey DiscountCode { get; private set; }
public VocabularyKey DiscountOriginType { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey ManualDiscountType { get; private set; }
public VocabularyKey DiscountPercentage { get; private set; }
public VocabularyKey DiscountOfferId { get; private set; }
public VocabularyKey SalesLineNumber { get; private set; }
public VocabularyKey BundleId { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}