using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LoanApplicationCollateralVocabulary : SimpleVocabulary
    {
        public LoanApplicationCollateralVocabulary()
        {
            VocabularyName = "Common Data Model LoanApplicationCollateral";
            KeyPrefix = "commonDataModel.loanapplicationcollateral";
            KeySeparator = ".";
            Grouping = "/LoanApplicationCollateral";

            AddGroup("Common Data Model LoanApplicationCollateral Details", group =>
            {
                loanApplicationCollateralId = group.Add(new VocabularyKey(nameof(loanApplicationCollateralId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                amountExisitingLiens = group.Add(new VocabularyKey(nameof(amountExisitingLiens), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                amountexisitingliens_Base = group.Add(new VocabularyKey(nameof(amountexisitingliens_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isLegalCheckSuccessful = group.Add(new VocabularyKey(nameof(isLegalCheckSuccessful), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                legalCheckCompletionDate = group.Add(new VocabularyKey(nameof(legalCheckCompletionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                legalDescription = group.Add(new VocabularyKey(nameof(legalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lientype = group.Add(new VocabularyKey(nameof(lientype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                purchaseDate = group.Add(new VocabularyKey(nameof(purchaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                usageType = group.Add(new VocabularyKey(nameof(usageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey loanApplicationCollateralId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey amountExisitingLiens { get; private set; }
        public VocabularyKey amountexisitingliens_Base { get; private set; }
        public VocabularyKey isLegalCheckSuccessful { get; private set; }
        public VocabularyKey legalCheckCompletionDate { get; private set; }
        public VocabularyKey legalDescription { get; private set; }
        public VocabularyKey lientype { get; private set; }
        public VocabularyKey purchaseDate { get; private set; }
        public VocabularyKey usageType { get; private set; }


    }
}