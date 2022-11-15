using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationLiabilityVocabulary : SimpleVocabulary
    {
        public LoanApplicationLiabilityVocabulary()
        {
            VocabularyName = "Loan Application Liability";
            KeyPrefix = "commonDataModel.loanapplicationliability";
            KeySeparator = ".";
            Grouping = "/LoanApplicationLiability";

            AddGroup("LoanApplicationLiability Details", group =>
            {
                LoanApplicationLiabilityId = group.Add(new VocabularyKey(nameof(LoanApplicationLiabilityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance_Base = group.Add(new VocabularyKey(nameof(Balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPayOffPending = group.Add(new VocabularyKey(nameof(IsPayOffPending), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LiabilityType = group.Add(new VocabularyKey(nameof(LiabilityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MonthlyPaymentAmount = group.Add(new VocabularyKey(nameof(MonthlyPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Monthlypaymentamount_Base = group.Add(new VocabularyKey(nameof(Monthlypaymentamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingTermsMonths = group.Add(new VocabularyKey(nameof(RemainingTermsMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street1 = group.Add(new VocabularyKey(nameof(Street1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street2 = group.Add(new VocabularyKey(nameof(Street2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street3 = group.Add(new VocabularyKey(nameof(Street3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipPostalCode = group.Add(new VocabularyKey(nameof(ZipPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balancedisplayvalue = group.Add(new VocabularyKey(nameof(Balancedisplayvalue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(Balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LoanApplicationLiabilityId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey Balance { get; private set; }
        public VocabularyKey Balance_Base { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsPayOffPending { get; private set; }
        public VocabularyKey LiabilityType { get; private set; }
        public VocabularyKey MonthlyPaymentAmount { get; private set; }
        public VocabularyKey Monthlypaymentamount_Base { get; private set; }
        public VocabularyKey RemainingTermsMonths { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey Street1 { get; private set; }
        public VocabularyKey Street2 { get; private set; }
        public VocabularyKey Street3 { get; private set; }
        public VocabularyKey ZipPostalCode { get; private set; }
        public VocabularyKey Balancedisplayvalue { get; private set; }
        public VocabularyKey Balancedisplayvalue_Base { get; private set; }
    }
}