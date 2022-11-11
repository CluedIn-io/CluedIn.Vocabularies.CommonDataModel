using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationLiabilityVocabulary : SimpleVocabulary
    {
        public LoanApplicationLiabilityVocabulary()
        {
            VocabularyName = "Common Data Model LoanApplicationLiability";
            KeyPrefix = "commonDataModel.loanapplicationliability";
            KeySeparator = ".";
            Grouping = "/LoanApplicationLiability";

            AddGroup("Common Data Model LoanApplicationLiability Details", group =>
            {
                loanApplicationLiabilityId = group.Add(new VocabularyKey(nameof(loanApplicationLiabilityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                accountNumber = group.Add(new VocabularyKey(nameof(accountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balance = group.Add(new VocabularyKey(nameof(balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balance_Base = group.Add(new VocabularyKey(nameof(balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                countryRegion = group.Add(new VocabularyKey(nameof(countryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isPayOffPending = group.Add(new VocabularyKey(nameof(isPayOffPending), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                liabilityType = group.Add(new VocabularyKey(nameof(liabilityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                monthlyPaymentAmount = group.Add(new VocabularyKey(nameof(monthlyPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                monthlypaymentamount_Base = group.Add(new VocabularyKey(nameof(monthlypaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                remainingTermsMonths = group.Add(new VocabularyKey(nameof(remainingTermsMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateProvince = group.Add(new VocabularyKey(nameof(stateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                street1 = group.Add(new VocabularyKey(nameof(street1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                street2 = group.Add(new VocabularyKey(nameof(street2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                street3 = group.Add(new VocabularyKey(nameof(street3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                zipPostalCode = group.Add(new VocabularyKey(nameof(zipPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balancedisplayvalue = group.Add(new VocabularyKey(nameof(balancedisplayvalue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey loanApplicationLiabilityId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey accountNumber { get; private set; }
        public VocabularyKey balance { get; private set; }
        public VocabularyKey balance_Base { get; private set; }
        public VocabularyKey city { get; private set; }
        public VocabularyKey countryRegion { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey isPayOffPending { get; private set; }
        public VocabularyKey liabilityType { get; private set; }
        public VocabularyKey monthlyPaymentAmount { get; private set; }
        public VocabularyKey monthlypaymentamount_Base { get; private set; }
        public VocabularyKey remainingTermsMonths { get; private set; }
        public VocabularyKey stateProvince { get; private set; }
        public VocabularyKey street1 { get; private set; }
        public VocabularyKey street2 { get; private set; }
        public VocabularyKey street3 { get; private set; }
        public VocabularyKey zipPostalCode { get; private set; }
        public VocabularyKey balancedisplayvalue { get; private set; }
        public VocabularyKey balancedisplayvalue_Base { get; private set; }


    }
}