using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollParametersEntityVocabulary : SimpleVocabulary
    {
        public PayrollParametersEntityVocabulary()
        {
            VocabularyName = "Payroll Parameters Entity";
            KeyPrefix = "commonDataModel.payrollparametersentity";
            KeySeparator = ".";
            Grouping = "/PayrollParametersEntity";

            AddGroup("PayrollParametersEntity Details", group =>
            {
                AccrualDateBasis = group.Add(new VocabularyKey(nameof(AccrualDateBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplyRetirementAnnualWageLimit = group.Add(new VocabularyKey(nameof(ApplyRetirementAnnualWageLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrearThresholdOverride = group.Add(new VocabularyKey(nameof(ArrearThresholdOverride), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningAccountingDate = group.Add(new VocabularyKey(nameof(EarningAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicPaymentMode = group.Add(new VocabularyKey(nameof(ElectronicPaymentMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentJournalName = group.Add(new VocabularyKey(nameof(PaymentJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTaskGroupingCount = group.Add(new VocabularyKey(nameof(PaymentTaskGroupingCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMode = group.Add(new VocabularyKey(nameof(PaymentMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaySlipContributions = group.Add(new VocabularyKey(nameof(PaySlipContributions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCategory = group.Add(new VocabularyKey(nameof(ProcurementCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecoverArrearInAllRunTypes = group.Add(new VocabularyKey(nameof(RecoverArrearInAllRunTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalaryClearingAccountLedgerDimension = group.Add(new VocabularyKey(nameof(SalaryClearingAccountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalaryClearingAccountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(SalaryClearingAccountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccrualDateBasis { get; private set; }
        public VocabularyKey ApplyRetirementAnnualWageLimit { get; private set; }
        public VocabularyKey ArrearThresholdOverride { get; private set; }
        public VocabularyKey EarningAccountingDate { get; private set; }
        public VocabularyKey ElectronicPaymentMode { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey PaymentJournalName { get; private set; }
        public VocabularyKey PaymentTaskGroupingCount { get; private set; }
        public VocabularyKey PaymentMode { get; private set; }
        public VocabularyKey PaySlipContributions { get; private set; }
        public VocabularyKey ProcurementCategory { get; private set; }
        public VocabularyKey RecoverArrearInAllRunTypes { get; private set; }
        public VocabularyKey SalaryClearingAccountLedgerDimension { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey SalaryClearingAccountLedgerDimensionDisplayValue { get; private set; }
    }
}