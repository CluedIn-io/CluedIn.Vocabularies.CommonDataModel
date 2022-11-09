using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementMerchandisingEventBillBackEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementMerchandisingEventBillBackEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMTradeAllowanceAgreementMerchandisingEventBillBackEntity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementmerchandisingeventbillbackentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementMerchandisingEventBillBackEntity";

            AddGroup("Common Data Model TAMTradeAllowanceAgreementMerchandisingEventBillBackEntity Details", group =>
            {
                IsTaxable = group.Add(new VocabularyKey(nameof(IsTaxable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccrualMainAccountId = group.Add(new VocabularyKey(nameof(AccrualMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseMainAccountId = group.Add(new VocabularyKey(nameof(ExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsApprovalRequired = group.Add(new VocabularyKey(nameof(IsApprovalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCumulationMethod = group.Add(new VocabularyKey(nameof(SalesCumulationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RebateBreakBasis = group.Add(new VocabularyKey(nameof(RebateBreakBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumBillBackAmountQualifyingRebate = group.Add(new VocabularyKey(nameof(MinimumBillBackAmountQualifyingRebate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumBillBackQuantityQualifyingRebate = group.Add(new VocabularyKey(nameof(MinimumBillBackQuantityQualifyingRebate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmountBasis = group.Add(new VocabularyKey(nameof(LineAmountBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillBackUnitSymbol = group.Add(new VocabularyKey(nameof(BillBackUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillBackQuantityType = group.Add(new VocabularyKey(nameof(BillBackQuantityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculationSearchDateType = group.Add(new VocabularyKey(nameof(CalculationSearchDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCumulationMethodCustomizedPeriodType = group.Add(new VocabularyKey(nameof(SalesCumulationMethodCustomizedPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillBackAmountCalculationOption = group.Add(new VocabularyKey(nameof(BillBackAmountCalculationOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccrualMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(AccrualMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(ExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesRebateProgramTypeId = group.Add(new VocabularyKey(nameof(SalesRebateProgramTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillBackId = group.Add(new VocabularyKey(nameof(BillBackId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillBackClaimVendorAccountNumber = group.Add(new VocabularyKey(nameof(BillBackClaimVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAllowanceAgreementMerchandisingEventId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementMerchandisingEventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsTaxable { get; private set; }
public VocabularyKey AccrualMainAccountId { get; private set; }
public VocabularyKey ExpenseMainAccountId { get; private set; }
public VocabularyKey IsApprovalRequired { get; private set; }
public VocabularyKey SalesCumulationMethod { get; private set; }
public VocabularyKey RebateBreakBasis { get; private set; }
public VocabularyKey MinimumBillBackAmountQualifyingRebate { get; private set; }
public VocabularyKey MinimumBillBackQuantityQualifyingRebate { get; private set; }
public VocabularyKey LineAmountBasis { get; private set; }
public VocabularyKey BillBackUnitSymbol { get; private set; }
public VocabularyKey BillBackQuantityType { get; private set; }
public VocabularyKey CalculationSearchDateType { get; private set; }
public VocabularyKey SalesCumulationMethodCustomizedPeriodType { get; private set; }
public VocabularyKey BillBackAmountCalculationOption { get; private set; }
public VocabularyKey AccrualMainAccountIdDisplayValue { get; private set; }
public VocabularyKey ExpenseMainAccountIdDisplayValue { get; private set; }
public VocabularyKey SalesRebateProgramTypeId { get; private set; }
public VocabularyKey BillBackId { get; private set; }
public VocabularyKey BillBackClaimVendorAccountNumber { get; private set; }
public VocabularyKey TradeAllowanceAgreementMerchandisingEventId { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey TradeAllowanceAgreementId { get; private set; }


    }
}