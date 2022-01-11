using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesRebateEntity";
            KeyPrefix = "commonDataModel.salesrebateentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateEntity";

            AddGroup("Common Data Model SalesRebateEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesInvoiceLineRecId = group.Add(new VocabularyKey(nameof(SalesInvoiceLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesInvoiceLineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(SalesInvoiceLineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultAccrualLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultAccrualLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultAccrualLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultAccrualLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderLineInventoryLotId = group.Add(new VocabularyKey(nameof(SalesOrderLineInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultAccrualMainAccountId = group.Add(new VocabularyKey(nameof(DefaultAccrualMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultAccrualMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(DefaultAccrualMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultExpenseLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultExpenseLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultExpenseLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultExpenseLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultExpenseMainAccountId = group.Add(new VocabularyKey(nameof(DefaultExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(DefaultExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrectedRebateAmount = group.Add(new VocabularyKey(nameof(CorrectedRebateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesInvoiceRecId = group.Add(new VocabularyKey(nameof(SalesInvoiceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomersOrderReference = group.Add(new VocabularyKey(nameof(CustomersOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesRebateCustomerGroupId = group.Add(new VocabularyKey(nameof(SalesRebateCustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(InvoicedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesRebateProductGroupId = group.Add(new VocabularyKey(nameof(SalesRebateProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCreditRebate = group.Add(new VocabularyKey(nameof(IsCreditRebate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentType = group.Add(new VocabularyKey(nameof(PaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateAdjustmentDate = group.Add(new VocabularyKey(nameof(RebateAdjustmentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateAgreementRefRecId = group.Add(new VocabularyKey(nameof(RebateAgreementRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValueType = group.Add(new VocabularyKey(nameof(ValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateBalanceAmount = group.Add(new VocabularyKey(nameof(RebateBalanceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateId = group.Add(new VocabularyKey(nameof(RebateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VoucherNumber = group.Add(new VocabularyKey(nameof(VoucherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateStatus = group.Add(new VocabularyKey(nameof(RebateStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesRebateProgramTypeId = group.Add(new VocabularyKey(nameof(SalesRebateProgramTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartingRebateAmount = group.Add(new VocabularyKey(nameof(StartingRebateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateCalculationDate = group.Add(new VocabularyKey(nameof(RebateCalculationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateAgreementLineRefRecId = group.Add(new VocabularyKey(nameof(RebateAgreementLineRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateSalesAmount = group.Add(new VocabularyKey(nameof(RebateSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesInvoiceDate = group.Add(new VocabularyKey(nameof(SalesInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicedSalesQuantity = group.Add(new VocabularyKey(nameof(InvoicedSalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesInvoiceNumber = group.Add(new VocabularyKey(nameof(SalesInvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesLineRecId = group.Add(new VocabularyKey(nameof(SalesLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesLineAmount = group.Add(new VocabularyKey(nameof(SalesLineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPriceQuantity = group.Add(new VocabularyKey(nameof(SalesPriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTableRefRecId = group.Add(new VocabularyKey(nameof(SalesTableRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAllowanceAgreementMerchandisingEventId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementMerchandisingEventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateAmountPerProductUnitSold = group.Add(new VocabularyKey(nameof(RebateAmountPerProductUnitSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedRebateAmount = group.Add(new VocabularyKey(nameof(FixedRebateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebatePercentage = group.Add(new VocabularyKey(nameof(RebatePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesRebateAgreementId = group.Add(new VocabularyKey(nameof(SalesRebateAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey SalesInvoiceLineRecId { get; private set; }
public VocabularyKey SalesInvoiceLineCreationSequenceNumber { get; private set; }
public VocabularyKey DefaultAccrualLedgerDimension { get; private set; }
public VocabularyKey DefaultAccrualLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey SalesOrderLineInventoryLotId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey DefaultAccrualMainAccountId { get; private set; }
public VocabularyKey DefaultAccrualMainAccountIdDisplayValue { get; private set; }
public VocabularyKey DefaultExpenseLedgerDimension { get; private set; }
public VocabularyKey DefaultExpenseLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey DefaultExpenseMainAccountId { get; private set; }
public VocabularyKey DefaultExpenseMainAccountIdDisplayValue { get; private set; }
public VocabularyKey CorrectedRebateAmount { get; private set; }
public VocabularyKey SalesInvoiceRecId { get; private set; }
public VocabularyKey CustomersOrderReference { get; private set; }
public VocabularyKey SalesRebateCustomerGroupId { get; private set; }
public VocabularyKey InvoicedCatchWeightQuantity { get; private set; }
public VocabularyKey SalesRebateProductGroupId { get; private set; }
public VocabularyKey IsCreditRebate { get; private set; }
public VocabularyKey PaymentType { get; private set; }
public VocabularyKey AccountingDate { get; private set; }
public VocabularyKey RebateAdjustmentDate { get; private set; }
public VocabularyKey RebateAgreementRefRecId { get; private set; }
public VocabularyKey ValueType { get; private set; }
public VocabularyKey RebateBalanceAmount { get; private set; }
public VocabularyKey RebateId { get; private set; }
public VocabularyKey VoucherNumber { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey RebateStatus { get; private set; }
public VocabularyKey SalesRebateProgramTypeId { get; private set; }
public VocabularyKey StartingRebateAmount { get; private set; }
public VocabularyKey RebateCalculationDate { get; private set; }
public VocabularyKey RebateAgreementLineRefRecId { get; private set; }
public VocabularyKey RebateSalesAmount { get; private set; }
public VocabularyKey SalesOrderNumber { get; private set; }
public VocabularyKey SalesInvoiceDate { get; private set; }
public VocabularyKey InvoicedSalesQuantity { get; private set; }
public VocabularyKey SalesInvoiceNumber { get; private set; }
public VocabularyKey SalesLineRecId { get; private set; }
public VocabularyKey SalesLineAmount { get; private set; }
public VocabularyKey SalesPriceQuantity { get; private set; }
public VocabularyKey SalesTableRefRecId { get; private set; }
public VocabularyKey TradeAllowanceAgreementMerchandisingEventId { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey SalesTaxItemGroupCode { get; private set; }
public VocabularyKey RebateAmountPerProductUnitSold { get; private set; }
public VocabularyKey FixedRebateAmount { get; private set; }
public VocabularyKey RebatePercentage { get; private set; }
public VocabularyKey SalesRebateAgreementId { get; private set; }


    }
}