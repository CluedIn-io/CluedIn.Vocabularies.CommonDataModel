using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationCollateralValuationVocabulary : SimpleVocabulary
    {
        public LoanApplicationCollateralValuationVocabulary()
        {
            VocabularyName = "Loan Application Collateral Valuation";
            KeyPrefix = "commonDataModel.loanapplicationcollateralvaluation";
            KeySeparator = ".";
            Grouping = "/LoanApplicationCollateralValuation";

            AddGroup("LoanApplicationCollateralValuation Details", group =>
            {
                LoanApplicationCollateralValuationId = group.Add(new VocabularyKey(nameof(LoanApplicationCollateralValuationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessorName = group.Add(new VocabularyKey(nameof(AssessorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Valuation = group.Add(new VocabularyKey(nameof(Valuation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Valuation_Base = group.Add(new VocabularyKey(nameof(Valuation_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValuationDate = group.Add(new VocabularyKey(nameof(ValuationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValuationInstructionDate = group.Add(new VocabularyKey(nameof(ValuationInstructionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValuationReceivedDate = group.Add(new VocabularyKey(nameof(ValuationReceivedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LoanApplicationCollateralValuationId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AssessorName { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Valuation { get; private set; }
        public VocabularyKey Valuation_Base { get; private set; }
        public VocabularyKey ValuationDate { get; private set; }
        public VocabularyKey ValuationInstructionDate { get; private set; }
        public VocabularyKey ValuationReceivedDate { get; private set; }
    }
}