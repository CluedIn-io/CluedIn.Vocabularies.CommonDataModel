using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationCollateralValuationVocabulary : SimpleVocabulary
    {
        public LoanApplicationCollateralValuationVocabulary()
        {
            VocabularyName = "Common Data Model LoanApplicationCollateralValuation";
            KeyPrefix = "commonDataModel.loanapplicationcollateralvaluation";
            KeySeparator = ".";
            Grouping = "/LoanApplicationCollateralValuation";

            AddGroup("Common Data Model LoanApplicationCollateralValuation Details", group =>
            {
                loanApplicationCollateralValuationId = group.Add(new VocabularyKey(nameof(loanApplicationCollateralValuationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                assessorName = group.Add(new VocabularyKey(nameof(assessorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                status = group.Add(new VocabularyKey(nameof(status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                valuation = group.Add(new VocabularyKey(nameof(valuation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                valuation_Base = group.Add(new VocabularyKey(nameof(valuation_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                valuationDate = group.Add(new VocabularyKey(nameof(valuationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                valuationInstructionDate = group.Add(new VocabularyKey(nameof(valuationInstructionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                valuationReceivedDate = group.Add(new VocabularyKey(nameof(valuationReceivedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey loanApplicationCollateralValuationId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey assessorName { get; private set; }
        public VocabularyKey status { get; private set; }
        public VocabularyKey type { get; private set; }
        public VocabularyKey valuation { get; private set; }
        public VocabularyKey valuation_Base { get; private set; }
        public VocabularyKey valuationDate { get; private set; }
        public VocabularyKey valuationInstructionDate { get; private set; }
        public VocabularyKey valuationReceivedDate { get; private set; }


    }
}