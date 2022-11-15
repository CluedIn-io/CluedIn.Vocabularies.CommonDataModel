using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningCodeEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningCodeEntityVocabulary()
        {
            VocabularyName = "Payroll Earning Code Entity";
            KeyPrefix = "commonDataModel.payrollearningcodeentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningCodeEntity";

            AddGroup("PayrollEarningCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeInPaymentType = group.Add(new VocabularyKey(nameof(IncludeInPaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductive = group.Add(new VocabularyKey(nameof(IsProductive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityUnit = group.Add(new VocabularyKey(nameof(QuantityUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackFMLAHours = group.Add(new VocabularyKey(nameof(TrackFMLAHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultFormula = group.Add(new VocabularyKey(nameof(DefaultFormula), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateBasis = group.Add(new VocabularyKey(nameof(RateBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FringeBenefitType = group.Add(new VocabularyKey(nameof(FringeBenefitType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxMethod = group.Add(new VocabularyKey(nameof(TaxMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeGroupId = group.Add(new VocabularyKey(nameof(EarningCodeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeGroup = group.Add(new VocabularyKey(nameof(EarningCodeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossUpEarningCodeId = group.Add(new VocabularyKey(nameof(GrossUpEarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossUpEarningCode = group.Add(new VocabularyKey(nameof(GrossUpEarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBaseEarningsComponent = group.Add(new VocabularyKey(nameof(IsBaseEarningsComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRetroactive = group.Add(new VocabularyKey(nameof(IsRetroactive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetroactiveEarningCode = group.Add(new VocabularyKey(nameof(RetroactiveEarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetroactiveEarningCodeId = group.Add(new VocabularyKey(nameof(RetroactiveEarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseDefinition = group.Add(new VocabularyKey(nameof(BaseDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEarningStatementLineRateEditable = group.Add(new VocabularyKey(nameof(IsEarningStatementLineRateEditable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey IncludeInPaymentType { get; private set; }
        public VocabularyKey IsProductive { get; private set; }
        public VocabularyKey QuantityUnit { get; private set; }
        public VocabularyKey TrackFMLAHours { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey DefaultFormula { get; private set; }
        public VocabularyKey RateBasis { get; private set; }
        public VocabularyKey FringeBenefitType { get; private set; }
        public VocabularyKey TaxMethod { get; private set; }
        public VocabularyKey EarningCodeGroupId { get; private set; }
        public VocabularyKey EarningCodeGroup { get; private set; }
        public VocabularyKey GrossUpEarningCodeId { get; private set; }
        public VocabularyKey GrossUpEarningCode { get; private set; }
        public VocabularyKey IsBaseEarningsComponent { get; private set; }
        public VocabularyKey IsRetroactive { get; private set; }
        public VocabularyKey RetroactiveEarningCode { get; private set; }
        public VocabularyKey RetroactiveEarningCodeId { get; private set; }
        public VocabularyKey BaseDefinition { get; private set; }
        public VocabularyKey IsEarningStatementLineRateEditable { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey TaxGroupId { get; private set; }
    }
}