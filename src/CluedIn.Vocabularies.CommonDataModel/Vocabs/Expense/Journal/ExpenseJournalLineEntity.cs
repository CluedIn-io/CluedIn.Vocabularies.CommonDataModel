using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExpenseJournalLineEntityVocabulary : SimpleVocabulary
    {
        public ExpenseJournalLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model ExpenseJournalLineEntity";
            KeyPrefix = "commonDataModel.expensejournallineentity";
            KeySeparator = ".";
            Grouping = "/ExpenseJournalLineEntity";

            AddGroup("Common Data Model ExpenseJournalLineEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetAccountType = group.Add(new VocabularyKey(nameof(OffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetTransactionText = group.Add(new VocabularyKey(nameof(OffsetTransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VoucherDate = group.Add(new VocabularyKey(nameof(VoucherDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DelayTaxCalculation = group.Add(new VocabularyKey(nameof(DelayTaxCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCostQuantity = group.Add(new VocabularyKey(nameof(ProjectCostQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategory = group.Add(new VocabularyKey(nameof(ProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCostPrice = group.Add(new VocabularyKey(nameof(ProjectCostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectLineProperty = group.Add(new VocabularyKey(nameof(ProjectLineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjId = group.Add(new VocabularyKey(nameof(ProjId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectSalesCurrencyCode = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectSalesPrice = group.Add(new VocabularyKey(nameof(ProjectSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Payment = group.Add(new VocabularyKey(nameof(Payment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentId = group.Add(new VocabularyKey(nameof(PaymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxExcemptNumber = group.Add(new VocabularyKey(nameof(TaxExcemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscount = group.Add(new VocabularyKey(nameof(CashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountAmount = group.Add(new VocabularyKey(nameof(CashDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountDate = group.Add(new VocabularyKey(nameof(CashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseOrder = group.Add(new VocabularyKey(nameof(PurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Document = group.Add(new VocabularyKey(nameof(Document), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentSpecification = group.Add(new VocabularyKey(nameof(PaymentSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Approver = group.Add(new VocabularyKey(nameof(Approver), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApprovedBy = group.Add(new VocabularyKey(nameof(ApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditAmount = group.Add(new VocabularyKey(nameof(CreditAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DebitAmount = group.Add(new VocabularyKey(nameof(DebitAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Approved = group.Add(new VocabularyKey(nameof(Approved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChineseVoucherTypeId = group.Add(new VocabularyKey(nameof(ChineseVoucherTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChineseVoucherType = group.Add(new VocabularyKey(nameof(ChineseVoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChineseVoucher = group.Add(new VocabularyKey(nameof(ChineseVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerJournalTrans_Project = group.Add(new VocabularyKey(nameof(LedgerJournalTrans_Project), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTaxGroupSales = group.Add(new VocabularyKey(nameof(ProjectTaxGroupSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTaxItemGroupSales = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectPriceGroupID = group.Add(new VocabularyKey(nameof(ProjectPriceGroupID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountCompany = group.Add(new VocabularyKey(nameof(AccountCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetCompany = group.Add(new VocabularyKey(nameof(OffsetCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReversingEntry = group.Add(new VocabularyKey(nameof(IsReversingEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReversingDate = group.Add(new VocabularyKey(nameof(ReversingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecondaryExchangeRate = group.Add(new VocabularyKey(nameof(SecondaryExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualSalesTaxAmount = group.Add(new VocabularyKey(nameof(ActualSalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetDefaultDimension = group.Add(new VocabularyKey(nameof(OffsetDefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OffsetDefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(OffsetDefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountType { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey JournalBatchNumber { get; private set; }
public VocabularyKey Account { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey OffsetAccountType { get; private set; }
public VocabularyKey OffsetAccount { get; private set; }
public VocabularyKey OffsetTransactionText { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey VoucherDate { get; private set; }
public VocabularyKey Text { get; private set; }
public VocabularyKey Voucher { get; private set; }
public VocabularyKey AccountDisplayValue { get; private set; }
public VocabularyKey OffsetAccountDisplayValue { get; private set; }
public VocabularyKey Resource { get; private set; }
public VocabularyKey DelayTaxCalculation { get; private set; }
public VocabularyKey ProjectCostQuantity { get; private set; }
public VocabularyKey ProjectCategory { get; private set; }
public VocabularyKey ProjectCostPrice { get; private set; }
public VocabularyKey ProjectLineProperty { get; private set; }
public VocabularyKey ProjId { get; private set; }
public VocabularyKey ActivityNumber { get; private set; }
public VocabularyKey ResourceId { get; private set; }
public VocabularyKey ResourceCompanyId { get; private set; }
public VocabularyKey ProjectSalesCurrencyCode { get; private set; }
public VocabularyKey Dimension { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }
public VocabularyKey ProjectDate { get; private set; }
public VocabularyKey ProjectSalesPrice { get; private set; }
public VocabularyKey Invoice { get; private set; }
public VocabularyKey DueDate { get; private set; }
public VocabularyKey Payment { get; private set; }
public VocabularyKey PaymentId { get; private set; }
public VocabularyKey TaxExcemptNumber { get; private set; }
public VocabularyKey SalesTaxCode { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey CashDiscount { get; private set; }
public VocabularyKey CashDiscountAmount { get; private set; }
public VocabularyKey CashDiscountDate { get; private set; }
public VocabularyKey PurchaseOrder { get; private set; }
public VocabularyKey Document { get; private set; }
public VocabularyKey DocumentDate { get; private set; }
public VocabularyKey PaymentMethod { get; private set; }
public VocabularyKey PaymentSpecification { get; private set; }
public VocabularyKey Approver { get; private set; }
public VocabularyKey ApprovedBy { get; private set; }
public VocabularyKey PostingProfile { get; private set; }
public VocabularyKey CreditAmount { get; private set; }
public VocabularyKey DebitAmount { get; private set; }
public VocabularyKey Approved { get; private set; }
public VocabularyKey ChineseVoucherTypeId { get; private set; }
public VocabularyKey ChineseVoucherType { get; private set; }
public VocabularyKey ChineseVoucher { get; private set; }
public VocabularyKey LedgerJournalTrans_Project { get; private set; }
public VocabularyKey ProjectTaxGroupSales { get; private set; }
public VocabularyKey ProjectTaxItemGroupSales { get; private set; }
public VocabularyKey ProjectPriceGroupID { get; private set; }
public VocabularyKey AccountCompany { get; private set; }
public VocabularyKey OffsetCompany { get; private set; }
public VocabularyKey IsReversingEntry { get; private set; }
public VocabularyKey ReversingDate { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ExchangeRate { get; private set; }
public VocabularyKey SecondaryExchangeRate { get; private set; }
public VocabularyKey ActualSalesTaxAmount { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey OffsetDefaultDimension { get; private set; }
public VocabularyKey OffsetDefaultDimensionDisplayValue { get; private set; }


    }
}