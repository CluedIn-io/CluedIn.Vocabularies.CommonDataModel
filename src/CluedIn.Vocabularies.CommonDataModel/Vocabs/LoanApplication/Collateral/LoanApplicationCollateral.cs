using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationCollateralVocabulary : SimpleVocabulary
    {
        public LoanApplicationCollateralVocabulary()
        {
            VocabularyName = "Loan Application Collateral";
            KeyPrefix = "commonDataModel.loanapplicationcollateral";
            KeySeparator = ".";
            Grouping = "/LoanApplicationCollateral";

            AddGroup("LoanApplicationCollateral Details", group =>
            {
                LoanApplicationCollateralId = group.Add(new VocabularyKey(nameof(LoanApplicationCollateralId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountExisitingLiens = group.Add(new VocabularyKey(nameof(AmountExisitingLiens), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amountexisitingliens_Base = group.Add(new VocabularyKey(nameof(Amountexisitingliens_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLegalCheckSuccessful = group.Add(new VocabularyKey(nameof(IsLegalCheckSuccessful), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalCheckCompletionDate = group.Add(new VocabularyKey(nameof(LegalCheckCompletionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalDescription = group.Add(new VocabularyKey(nameof(LegalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lientype = group.Add(new VocabularyKey(nameof(Lientype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseDate = group.Add(new VocabularyKey(nameof(PurchaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsageType = group.Add(new VocabularyKey(nameof(UsageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LoanApplicationCollateralId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AmountExisitingLiens { get; private set; }
        public VocabularyKey Amountexisitingliens_Base { get; private set; }
        public VocabularyKey IsLegalCheckSuccessful { get; private set; }
        public VocabularyKey LegalCheckCompletionDate { get; private set; }
        public VocabularyKey LegalDescription { get; private set; }
        public VocabularyKey Lientype { get; private set; }
        public VocabularyKey PurchaseDate { get; private set; }
        public VocabularyKey UsageType { get; private set; }
    }
}