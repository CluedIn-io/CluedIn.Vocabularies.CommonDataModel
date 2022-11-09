using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationVocabulary : SimpleVocabulary
    {
        public LoanApplicationVocabulary()
        {
            VocabularyName = "Common Data Model LoanApplication";
            KeyPrefix = "commonDataModel.loanapplication";
            KeySeparator = ".";
            Grouping = "/LoanApplication";

            AddGroup("Common Data Model LoanApplication Details", group =>
            {
                loanApplicationId = group.Add(new VocabularyKey(nameof(loanApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
amortizationType = group.Add(new VocabularyKey(nameof(amortizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
applicationnumber = group.Add(new VocabularyKey(nameof(applicationnumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balloonAmount = group.Add(new VocabularyKey(nameof(balloonAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balloonamount_Base = group.Add(new VocabularyKey(nameof(balloonamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balloonTermCount = group.Add(new VocabularyKey(nameof(balloonTermCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
costofimprovements = group.Add(new VocabularyKey(nameof(costofimprovements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
costofimprovements_Base = group.Add(new VocabularyKey(nameof(costofimprovements_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
depositAmount = group.Add(new VocabularyKey(nameof(depositAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
depositamount_Base = group.Add(new VocabularyKey(nameof(depositamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
describeimprovements = group.Add(new VocabularyKey(nameof(describeimprovements), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
discountpointstotalamount = group.Add(new VocabularyKey(nameof(discountpointstotalamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
discountpointstotalamount_Base = group.Add(new VocabularyKey(nameof(discountpointstotalamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
downPayment = group.Add(new VocabularyKey(nameof(downPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
downpayment_Base = group.Add(new VocabularyKey(nameof(downpayment_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
escrowPaymentAmount = group.Add(new VocabularyKey(nameof(escrowPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
escrowpaymentamount_Base = group.Add(new VocabularyKey(nameof(escrowpaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financingType = group.Add(new VocabularyKey(nameof(financingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
firstMonthInterestAmount = group.Add(new VocabularyKey(nameof(firstMonthInterestAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
firstmonthinterestamount_Base = group.Add(new VocabularyKey(nameof(firstmonthinterestamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestOnlyTermMonthCount = group.Add(new VocabularyKey(nameof(interestOnlyTermMonthCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestRate = group.Add(new VocabularyKey(nameof(interestRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestType = group.Add(new VocabularyKey(nameof(interestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isBalloonPayment = group.Add(new VocabularyKey(nameof(isBalloonPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isInterestOnly = group.Add(new VocabularyKey(nameof(isInterestOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isNegativeAmortization = group.Add(new VocabularyKey(nameof(isNegativeAmortization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lendingLimit = group.Add(new VocabularyKey(nameof(lendingLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lendinglimit_Base = group.Add(new VocabularyKey(nameof(lendinglimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanApplicationClosingDate = group.Add(new VocabularyKey(nameof(loanApplicationClosingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanCategory = group.Add(new VocabularyKey(nameof(loanCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanorrefinancePurpose = group.Add(new VocabularyKey(nameof(loanorrefinancePurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanTerm = group.Add(new VocabularyKey(nameof(loanTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanToValue = group.Add(new VocabularyKey(nameof(loanToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
loanType = group.Add(new VocabularyKey(nameof(loanType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maxLoanToValue = group.Add(new VocabularyKey(nameof(maxLoanToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
noteAmount = group.Add(new VocabularyKey(nameof(noteAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
noteamount_Base = group.Add(new VocabularyKey(nameof(noteamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
principalAmount = group.Add(new VocabularyKey(nameof(principalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
principalamount_Base = group.Add(new VocabularyKey(nameof(principalamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
refinanceType = group.Add(new VocabularyKey(nameof(refinanceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sourceofDownPayment = group.Add(new VocabularyKey(nameof(sourceofDownPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
verificationStatus = group.Add(new VocabularyKey(nameof(verificationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
primaryMemberHelper = group.Add(new VocabularyKey(nameof(primaryMemberHelper), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey loanApplicationId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey amortizationType { get; private set; }
public VocabularyKey applicationnumber { get; private set; }
public VocabularyKey balloonAmount { get; private set; }
public VocabularyKey balloonamount_Base { get; private set; }
public VocabularyKey balloonTermCount { get; private set; }
public VocabularyKey costofimprovements { get; private set; }
public VocabularyKey costofimprovements_Base { get; private set; }
public VocabularyKey depositAmount { get; private set; }
public VocabularyKey depositamount_Base { get; private set; }
public VocabularyKey describeimprovements { get; private set; }
public VocabularyKey discountpointstotalamount { get; private set; }
public VocabularyKey discountpointstotalamount_Base { get; private set; }
public VocabularyKey downPayment { get; private set; }
public VocabularyKey downpayment_Base { get; private set; }
public VocabularyKey escrowPaymentAmount { get; private set; }
public VocabularyKey escrowpaymentamount_Base { get; private set; }
public VocabularyKey financingType { get; private set; }
public VocabularyKey firstMonthInterestAmount { get; private set; }
public VocabularyKey firstmonthinterestamount_Base { get; private set; }
public VocabularyKey integrationKey { get; private set; }
public VocabularyKey interestOnlyTermMonthCount { get; private set; }
public VocabularyKey interestRate { get; private set; }
public VocabularyKey interestType { get; private set; }
public VocabularyKey isBalloonPayment { get; private set; }
public VocabularyKey isInterestOnly { get; private set; }
public VocabularyKey isNegativeAmortization { get; private set; }
public VocabularyKey lendingLimit { get; private set; }
public VocabularyKey lendinglimit_Base { get; private set; }
public VocabularyKey loanApplicationClosingDate { get; private set; }
public VocabularyKey loanCategory { get; private set; }
public VocabularyKey loanorrefinancePurpose { get; private set; }
public VocabularyKey loanTerm { get; private set; }
public VocabularyKey loanToValue { get; private set; }
public VocabularyKey loanType { get; private set; }
public VocabularyKey maxLoanToValue { get; private set; }
public VocabularyKey noteAmount { get; private set; }
public VocabularyKey noteamount_Base { get; private set; }
public VocabularyKey principalAmount { get; private set; }
public VocabularyKey principalamount_Base { get; private set; }
public VocabularyKey refinanceType { get; private set; }
public VocabularyKey sourceofDownPayment { get; private set; }
public VocabularyKey verificationStatus { get; private set; }
public VocabularyKey primaryMemberHelper { get; private set; }


    }
}