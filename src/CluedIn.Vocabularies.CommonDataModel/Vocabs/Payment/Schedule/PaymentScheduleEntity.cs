using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentScheduleEntityVocabulary : SimpleVocabulary
    {
        public PaymentScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymentScheduleEntity";
            KeyPrefix = "commonDataModel.paymentscheduleentity";
            KeySeparator = ".";
            Grouping = "/PaymentScheduleEntity";

            AddGroup("Common Data Model PaymentScheduleEntity Details", group =>
            {
                FixedPaymentAmount = group.Add(new VocabularyKey(nameof(FixedPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumPaymentAmount = group.Add(new VocabularyKey(nameof(MinimumPaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfPayments = group.Add(new VocabularyKey(nameof(NumberOfPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationMethod = group.Add(new VocabularyKey(nameof(AllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentFrequencyUnits = group.Add(new VocabularyKey(nameof(PaymentFrequencyUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentFrequency = group.Add(new VocabularyKey(nameof(PaymentFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxAllocationMethod = group.Add(new VocabularyKey(nameof(SalesTaxAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeAllocationMethod = group.Add(new VocabularyKey(nameof(ChargeAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFlexibleInstallmentPlan = group.Add(new VocabularyKey(nameof(IsFlexibleInstallmentPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentMaximumOrderAmount = group.Add(new VocabularyKey(nameof(InstallmentMaximumOrderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstallmentMinimumOrderAmount = group.Add(new VocabularyKey(nameof(InstallmentMinimumOrderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FixedPaymentAmount { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey MinimumPaymentAmount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey NumberOfPayments { get; private set; }
        public VocabularyKey AllocationMethod { get; private set; }
        public VocabularyKey PaymentFrequencyUnits { get; private set; }
        public VocabularyKey PaymentFrequency { get; private set; }
        public VocabularyKey SalesTaxAllocationMethod { get; private set; }
        public VocabularyKey ChargeAllocationMethod { get; private set; }
        public VocabularyKey IsFlexibleInstallmentPlan { get; private set; }
        public VocabularyKey InstallmentMaximumOrderAmount { get; private set; }
        public VocabularyKey InstallmentMinimumOrderAmount { get; private set; }


    }
}