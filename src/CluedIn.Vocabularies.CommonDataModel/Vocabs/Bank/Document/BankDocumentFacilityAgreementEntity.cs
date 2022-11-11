using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankDocumentFacilityAgreementEntityVocabulary : SimpleVocabulary
    {
        public BankDocumentFacilityAgreementEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankDocumentFacilityAgreementEntity";
            KeyPrefix = "commonDataModel.bankdocumentfacilityagreemententity";
            KeySeparator = ".";
            Grouping = "/BankDocumentFacilityAgreementEntity";

            AddGroup("Common Data Model BankDocumentFacilityAgreementEntity Details", group =>
            {
                FacilityTypeRecId = group.Add(new VocabularyKey(nameof(FacilityTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementLine = group.Add(new VocabularyKey(nameof(AgreementLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountUsed = group.Add(new VocabularyKey(nameof(AmountUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountLimit = group.Add(new VocabularyKey(nameof(AmountLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementNumber = group.Add(new VocabularyKey(nameof(AgreementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FacilityType = group.Add(new VocabularyKey(nameof(FacilityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGCashMarginAmount = group.Add(new VocabularyKey(nameof(LGCashMarginAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGCashMarginPercentage = group.Add(new VocabularyKey(nameof(LGCashMarginPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGCashMarginCalcMethod = group.Add(new VocabularyKey(nameof(LGCashMarginCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGDecreaseValueCommissionAmount = group.Add(new VocabularyKey(nameof(LGDecreaseValueCommissionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGDecreaseValueCommissionCalcMethod = group.Add(new VocabularyKey(nameof(LGDecreaseValueCommissionCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGDecreaseValueCommissionPercentage = group.Add(new VocabularyKey(nameof(LGDecreaseValueCommissionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGExtensionCommissionAmount = group.Add(new VocabularyKey(nameof(LGExtensionCommissionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGExtensionCommissionCalcMethod = group.Add(new VocabularyKey(nameof(LGExtensionCommissionCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGExtensionCommissionPercentage = group.Add(new VocabularyKey(nameof(LGExtensionCommissionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGIncreaseValueCommissionAmount = group.Add(new VocabularyKey(nameof(LGIncreaseValueCommissionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGIncreaseValueCommissionPercentage = group.Add(new VocabularyKey(nameof(LGIncreaseValueCommissionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGIncreaseValueCommissionCalcMethod = group.Add(new VocabularyKey(nameof(LGIncreaseValueCommissionCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGIssuanceCommissionAmount = group.Add(new VocabularyKey(nameof(LGIssuanceCommissionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGIssuanceCommissionPercentage = group.Add(new VocabularyKey(nameof(LGIssuanceCommissionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGIssuanceCommissionCalcMethod = group.Add(new VocabularyKey(nameof(LGIssuanceCommissionCalcMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FacilityTypeRecId { get; private set; }
        public VocabularyKey AgreementLine { get; private set; }
        public VocabularyKey AmountUsed { get; private set; }
        public VocabularyKey AmountLimit { get; private set; }
        public VocabularyKey AgreementNumber { get; private set; }
        public VocabularyKey BankAccount { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey FacilityType { get; private set; }
        public VocabularyKey LGCashMarginAmount { get; private set; }
        public VocabularyKey LGCashMarginPercentage { get; private set; }
        public VocabularyKey LGCashMarginCalcMethod { get; private set; }
        public VocabularyKey LGDecreaseValueCommissionAmount { get; private set; }
        public VocabularyKey LGDecreaseValueCommissionCalcMethod { get; private set; }
        public VocabularyKey LGDecreaseValueCommissionPercentage { get; private set; }
        public VocabularyKey LGExtensionCommissionAmount { get; private set; }
        public VocabularyKey LGExtensionCommissionCalcMethod { get; private set; }
        public VocabularyKey LGExtensionCommissionPercentage { get; private set; }
        public VocabularyKey LGIncreaseValueCommissionAmount { get; private set; }
        public VocabularyKey LGIncreaseValueCommissionPercentage { get; private set; }
        public VocabularyKey LGIncreaseValueCommissionCalcMethod { get; private set; }
        public VocabularyKey LGIssuanceCommissionAmount { get; private set; }
        public VocabularyKey LGIssuanceCommissionPercentage { get; private set; }
        public VocabularyKey LGIssuanceCommissionCalcMethod { get; private set; }


    }
}