using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetJournalLineEntityVocabulary : SimpleVocabulary
    {
        public AssetJournalLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetJournalLineEntity";
            KeyPrefix = "commonDataModel.assetjournallineentity";
            KeySeparator = ".";
            Grouping = "/AssetJournalLineEntity";

            AddGroup("Common Data Model AssetJournalLineEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValueModel = group.Add(new VocabularyKey(nameof(ValueModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionUnits = group.Add(new VocabularyKey(nameof(ConsumptionUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChineseVoucherTypeRecId = group.Add(new VocabularyKey(nameof(ChineseVoucherTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChineseVoucherType = group.Add(new VocabularyKey(nameof(ChineseVoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChineseVoucher = group.Add(new VocabularyKey(nameof(ChineseVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssetDocumentEntry = group.Add(new VocabularyKey(nameof(AssetDocumentEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentType = group.Add(new VocabularyKey(nameof(DocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentId = group.Add(new VocabularyKey(nameof(DocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditAmountReportingCurrency = group.Add(new VocabularyKey(nameof(CreditAmountReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DebitAmountReportingCurrency = group.Add(new VocabularyKey(nameof(DebitAmountReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountType { get; private set; }
public VocabularyKey CreditAmount { get; private set; }
public VocabularyKey DebitAmount { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey JournalBatchNumber { get; private set; }
public VocabularyKey Account { get; private set; }
public VocabularyKey AccountDisplayValue { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey OffsetAccountType { get; private set; }
public VocabularyKey OffsetAccount { get; private set; }
public VocabularyKey OffsetAccountDisplayValue { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey Text { get; private set; }
public VocabularyKey Voucher { get; private set; }
public VocabularyKey ValueModel { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey FixedAssetNumber { get; private set; }
public VocabularyKey ConsumptionUnits { get; private set; }
public VocabularyKey ChineseVoucherTypeRecId { get; private set; }
public VocabularyKey ChineseVoucherType { get; private set; }
public VocabularyKey ChineseVoucher { get; private set; }
public VocabularyKey AssetDocumentEntry { get; private set; }
public VocabularyKey DocumentType { get; private set; }
public VocabularyKey DocumentId { get; private set; }
public VocabularyKey CreditAmountReportingCurrency { get; private set; }
public VocabularyKey DebitAmountReportingCurrency { get; private set; }


    }
}