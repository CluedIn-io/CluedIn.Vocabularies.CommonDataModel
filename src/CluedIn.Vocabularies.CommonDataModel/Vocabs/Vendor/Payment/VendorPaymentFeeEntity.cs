using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPaymentFeeEntityVocabulary : SimpleVocabulary
    {
        public VendorPaymentFeeEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorPaymentFeeEntity";
            KeyPrefix = "commonDataModel.vendorpaymentfeeentity";
            KeySeparator = ".";
            Grouping = "/VendorPaymentFeeEntity";

            AddGroup("Common Data Model VendorPaymentFeeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeType = group.Add(new VocabularyKey(nameof(ChargeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdForLedgerFeeTypes = group.Add(new VocabularyKey(nameof(MainAccountIdForLedgerFeeTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdForLedgerFeeTypesDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdForLedgerFeeTypesDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionText = group.Add(new VocabularyKey(nameof(TransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FeeLedgerAccount = group.Add(new VocabularyKey(nameof(FeeLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FeeLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(FeeLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorCoveredFeeLedgerAccount = group.Add(new VocabularyKey(nameof(VendorCoveredFeeLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorCoveredFeeLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(VendorCoveredFeeLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ChargeType { get; private set; }
public VocabularyKey MainAccountIdForLedgerFeeTypes { get; private set; }
public VocabularyKey MainAccountIdForLedgerFeeTypesDisplayValue { get; private set; }
public VocabularyKey JournalType { get; private set; }
public VocabularyKey TransactionText { get; private set; }
public VocabularyKey FeeLedgerAccount { get; private set; }
public VocabularyKey FeeLedgerAccountDisplayValue { get; private set; }
public VocabularyKey VendorCoveredFeeLedgerAccount { get; private set; }
public VocabularyKey VendorCoveredFeeLedgerAccountDisplayValue { get; private set; }


    }
}