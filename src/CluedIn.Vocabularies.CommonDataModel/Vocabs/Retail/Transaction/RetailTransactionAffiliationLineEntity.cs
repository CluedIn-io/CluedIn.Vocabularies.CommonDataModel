using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionAffiliationLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionAffiliationLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionAffiliationLineEntity";
            KeyPrefix = "commonDataModel.retailtransactionaffiliationlineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionAffiliationLineEntity";

            AddGroup("Common Data Model RetailTransactionAffiliationLineEntity Details", group =>
            {
                AffiliationId = group.Add(new VocabularyKey(nameof(AffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptNumber = group.Add(new VocabularyKey(nameof(ReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AffiliationName = group.Add(new VocabularyKey(nameof(AffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AffiliationId { get; private set; }
public VocabularyKey Channel { get; private set; }
public VocabularyKey ReceiptNumber { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey AffiliationName { get; private set; }
public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}