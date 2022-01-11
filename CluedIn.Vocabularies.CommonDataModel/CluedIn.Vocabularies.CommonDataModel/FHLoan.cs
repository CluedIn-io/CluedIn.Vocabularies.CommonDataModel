using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHLoanVocabulary : SimpleVocabulary
    {
        public FHLoanVocabulary()
        {
            VocabularyName = "Common Data Model FHLoan";
            KeyPrefix = "commonDataModel.fhloan";
            KeySeparator = ".";
            Grouping = "/FHLoan";

            AddGroup("Common Data Model FHLoan Details", group =>
            {
                FH_LoanId = group.Add(new VocabularyKey(nameof(FH_LoanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accountingClassification = group.Add(new VocabularyKey(nameof(accountingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balance = group.Add(new VocabularyKey(nameof(balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balance_Base = group.Add(new VocabularyKey(nameof(balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceDefault = group.Add(new VocabularyKey(nameof(balanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceExchangerate = group.Add(new VocabularyKey(nameof(balanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
capitalArrears = group.Add(new VocabularyKey(nameof(capitalArrears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
capitalarrears_Base = group.Add(new VocabularyKey(nameof(capitalarrears_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
capitalArrears_default = group.Add(new VocabularyKey(nameof(capitalArrears_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
collectionRisk = group.Add(new VocabularyKey(nameof(collectionRisk), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
delinquencyStatus = group.Add(new VocabularyKey(nameof(delinquencyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disbursedAmount = group.Add(new VocabularyKey(nameof(disbursedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disbursedamount_Base = group.Add(new VocabularyKey(nameof(disbursedamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disbursedAmount_default = group.Add(new VocabularyKey(nameof(disbursedAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disbursementDate = group.Add(new VocabularyKey(nameof(disbursementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
feeArrears = group.Add(new VocabularyKey(nameof(feeArrears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
feearrears_Base = group.Add(new VocabularyKey(nameof(feearrears_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
feeArrears_default = group.Add(new VocabularyKey(nameof(feeArrears_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financialHoldingCategory = group.Add(new VocabularyKey(nameof(financialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financialHoldingType = group.Add(new VocabularyKey(nameof(financialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
installmentAmount = group.Add(new VocabularyKey(nameof(installmentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
installmentamount_Base = group.Add(new VocabularyKey(nameof(installmentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
installmentAmount_default = group.Add(new VocabularyKey(nameof(installmentAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestArrears = group.Add(new VocabularyKey(nameof(interestArrears), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestarrears_Base = group.Add(new VocabularyKey(nameof(interestarrears_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestArrears_default = group.Add(new VocabularyKey(nameof(interestArrears_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestrate = group.Add(new VocabularyKey(nameof(interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestReviewPeriod = group.Add(new VocabularyKey(nameof(interestReviewPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestType = group.Add(new VocabularyKey(nameof(interestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastPaymentAmount = group.Add(new VocabularyKey(nameof(lastPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastpaymentamount_Base = group.Add(new VocabularyKey(nameof(lastpaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastPaymentAmount_default = group.Add(new VocabularyKey(nameof(lastPaymentAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastPaymentDate = group.Add(new VocabularyKey(nameof(lastPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanStartDate = group.Add(new VocabularyKey(nameof(loanStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maturitydate = group.Add(new VocabularyKey(nameof(maturitydate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modeofPayment = group.Add(new VocabularyKey(nameof(modeofPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextInterestReviewDate = group.Add(new VocabularyKey(nameof(nextInterestReviewDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextPaymentAmount = group.Add(new VocabularyKey(nameof(nextPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextpaymentamount_Base = group.Add(new VocabularyKey(nameof(nextpaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextPaymentAmount_default = group.Add(new VocabularyKey(nameof(nextPaymentAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextPaymentDate = group.Add(new VocabularyKey(nameof(nextPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberofDeferralsMade = group.Add(new VocabularyKey(nameof(numberofDeferralsMade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberofInstallmentsPaid = group.Add(new VocabularyKey(nameof(numberofInstallmentsPaid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdueDate = group.Add(new VocabularyKey(nameof(overdueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
principalAmount = group.Add(new VocabularyKey(nameof(principalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
principalamount_Base = group.Add(new VocabularyKey(nameof(principalamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
principalAmount_default = group.Add(new VocabularyKey(nameof(principalAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
repaymentAccount = group.Add(new VocabularyKey(nameof(repaymentAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalArrear = group.Add(new VocabularyKey(nameof(totalArrear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalarrear_Base = group.Add(new VocabularyKey(nameof(totalarrear_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalArrear_default = group.Add(new VocabularyKey(nameof(totalArrear_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalInterestPaid = group.Add(new VocabularyKey(nameof(totalInterestPaid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalinterestpaid_Base = group.Add(new VocabularyKey(nameof(totalinterestpaid_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
totalInterestPaid_default = group.Add(new VocabularyKey(nameof(totalInterestPaid_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(balanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceDisplayValue = group.Add(new VocabularyKey(nameof(balanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
dayspastdue = group.Add(new VocabularyKey(nameof(dayspastdue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FH_LoanId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey accountingClassification { get; private set; }
public VocabularyKey balance { get; private set; }
public VocabularyKey balance_Base { get; private set; }
public VocabularyKey balanceDefault { get; private set; }
public VocabularyKey balanceExchangerate { get; private set; }
public VocabularyKey capitalArrears { get; private set; }
public VocabularyKey capitalarrears_Base { get; private set; }
public VocabularyKey capitalArrears_default { get; private set; }
public VocabularyKey collectionRisk { get; private set; }
public VocabularyKey delinquencyStatus { get; private set; }
public VocabularyKey disbursedAmount { get; private set; }
public VocabularyKey disbursedamount_Base { get; private set; }
public VocabularyKey disbursedAmount_default { get; private set; }
public VocabularyKey disbursementDate { get; private set; }
public VocabularyKey feeArrears { get; private set; }
public VocabularyKey feearrears_Base { get; private set; }
public VocabularyKey feeArrears_default { get; private set; }
public VocabularyKey financialHoldingCategory { get; private set; }
public VocabularyKey financialHoldingType { get; private set; }
public VocabularyKey installmentAmount { get; private set; }
public VocabularyKey installmentamount_Base { get; private set; }
public VocabularyKey installmentAmount_default { get; private set; }
public VocabularyKey integrationKey { get; private set; }
public VocabularyKey interestArrears { get; private set; }
public VocabularyKey interestarrears_Base { get; private set; }
public VocabularyKey interestArrears_default { get; private set; }
public VocabularyKey interestrate { get; private set; }
public VocabularyKey interestReviewPeriod { get; private set; }
public VocabularyKey interestType { get; private set; }
public VocabularyKey lastPaymentAmount { get; private set; }
public VocabularyKey lastpaymentamount_Base { get; private set; }
public VocabularyKey lastPaymentAmount_default { get; private set; }
public VocabularyKey lastPaymentDate { get; private set; }
public VocabularyKey loanStartDate { get; private set; }
public VocabularyKey maturitydate { get; private set; }
public VocabularyKey modeofPayment { get; private set; }
public VocabularyKey nextInterestReviewDate { get; private set; }
public VocabularyKey nextPaymentAmount { get; private set; }
public VocabularyKey nextpaymentamount_Base { get; private set; }
public VocabularyKey nextPaymentAmount_default { get; private set; }
public VocabularyKey nextPaymentDate { get; private set; }
public VocabularyKey numberofDeferralsMade { get; private set; }
public VocabularyKey numberofInstallmentsPaid { get; private set; }
public VocabularyKey overdueDate { get; private set; }
public VocabularyKey principalAmount { get; private set; }
public VocabularyKey principalamount_Base { get; private set; }
public VocabularyKey principalAmount_default { get; private set; }
public VocabularyKey repaymentAccount { get; private set; }
public VocabularyKey totalArrear { get; private set; }
public VocabularyKey totalarrear_Base { get; private set; }
public VocabularyKey totalArrear_default { get; private set; }
public VocabularyKey totalInterestPaid { get; private set; }
public VocabularyKey totalinterestpaid_Base { get; private set; }
public VocabularyKey totalInterestPaid_default { get; private set; }
public VocabularyKey balanceDefaultDisplayValue { get; private set; }
public VocabularyKey balanceDisplayValue { get; private set; }
public VocabularyKey balancedisplayvalue_Base { get; private set; }
public VocabularyKey dayspastdue { get; private set; }


    }
}