using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetValueModelSetupEntityVocabulary : SimpleVocabulary
    {
        public AssetValueModelSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetValueModelSetupEntity";
            KeyPrefix = "commonDataModel.assetvaluemodelsetupentity";
            KeySeparator = ".";
            Grouping = "/AssetValueModelSetupEntity";

            AddGroup("Common Data Model AssetValueModelSetupEntity Details", group =>
            {
                AllowNegativeNetBookValue = group.Add(new VocabularyKey(nameof(AllowNegativeNetBookValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowNetBookValueHigherThanAcquisitionCosts = group.Add(new VocabularyKey(nameof(AllowNetBookValueHigherThanAcquisitionCosts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlternativeDepreciationProfileId = group.Add(new VocabularyKey(nameof(AlternativeDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculateDepreciation = group.Add(new VocabularyKey(nameof(CalculateDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Calendar = group.Add(new VocabularyKey(nameof(Calendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateDepreciationAdjustmentsWithBasisAdjustments = group.Add(new VocabularyKey(nameof(CreateDepreciationAdjustmentsWithBasisAdjustments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepreciationProfileId = group.Add(new VocabularyKey(nameof(DepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtraordinaryDepreciationProfileId = group.Add(new VocabularyKey(nameof(ExtraordinaryDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeaveNetBookValueAt = group.Add(new VocabularyKey(nameof(LeaveNetBookValueAt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundOffDepreciation = group.Add(new VocabularyKey(nameof(RoundOffDepreciation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueModelId = group.Add(new VocabularyKey(nameof(ValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceleratedDepreciationProfileId = group.Add(new VocabularyKey(nameof(AcceleratedDepreciationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionForAcquisitionOnJanuary1st = group.Add(new VocabularyKey(nameof(ActionForAcquisitionOnJanuary1st), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerogatoryCalculation = group.Add(new VocabularyKey(nameof(DerogatoryCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerogatoryTaxModel = group.Add(new VocabularyKey(nameof(DerogatoryTaxModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferencedValueModelId = group.Add(new VocabularyKey(nameof(ReferencedValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingMethod = group.Add(new VocabularyKey(nameof(RoundingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOverrideFixedAssetCalendarDays = group.Add(new VocabularyKey(nameof(IsOverrideFixedAssetCalendarDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetWorkingDays = group.Add(new VocabularyKey(nameof(AssetWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDepreciationRequiredInDisposal = group.Add(new VocabularyKey(nameof(IsDepreciationRequiredInDisposal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpectedScrapPercentage = group.Add(new VocabularyKey(nameof(ExpectedScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundOffDepreciationReportingCurrency = group.Add(new VocabularyKey(nameof(RoundOffDepreciationReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllowNegativeNetBookValue { get; private set; }
        public VocabularyKey AllowNetBookValueHigherThanAcquisitionCosts { get; private set; }
        public VocabularyKey AlternativeDepreciationProfileId { get; private set; }
        public VocabularyKey CalculateDepreciation { get; private set; }
        public VocabularyKey Calendar { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey CreateDepreciationAdjustmentsWithBasisAdjustments { get; private set; }
        public VocabularyKey DepreciationProfileId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExtraordinaryDepreciationProfileId { get; private set; }
        public VocabularyKey LeaveNetBookValueAt { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey RoundOffDepreciation { get; private set; }
        public VocabularyKey ValueModelId { get; private set; }
        public VocabularyKey AcceleratedDepreciationProfileId { get; private set; }
        public VocabularyKey ActionForAcquisitionOnJanuary1st { get; private set; }
        public VocabularyKey DerogatoryCalculation { get; private set; }
        public VocabularyKey DerogatoryTaxModel { get; private set; }
        public VocabularyKey ReferencedValueModelId { get; private set; }
        public VocabularyKey RoundingMethod { get; private set; }
        public VocabularyKey IsOverrideFixedAssetCalendarDays { get; private set; }
        public VocabularyKey AssetWorkingDays { get; private set; }
        public VocabularyKey IsDepreciationRequiredInDisposal { get; private set; }
        public VocabularyKey ExpectedScrapPercentage { get; private set; }
        public VocabularyKey RoundOffDepreciationReportingCurrency { get; private set; }


    }
}