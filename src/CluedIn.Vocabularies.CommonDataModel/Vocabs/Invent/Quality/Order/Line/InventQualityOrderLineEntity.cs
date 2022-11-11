using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityOrderLineEntityVocabulary : SimpleVocabulary
    {
        public InventQualityOrderLineEntityVocabulary()
        {
            VocabularyName = "InventQualityOrderLineEntity";
            KeyPrefix = "commonDataModel.inventqualityorderlineentity";
            KeySeparator = ".";
            Grouping = "/InventQualityOrderLineEntity";

            AddGroup("InventQualityOrderLineEntity Details", group =>
            {
                AcceptableQualityLevelPercentage = group.Add(new VocabularyKey(nameof(AcceptableQualityLevelPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailureAction = group.Add(new VocabularyKey(nameof(FailureAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCertificateOfAnalysisReportIncludingTestMeasurement = group.Add(new VocabularyKey(nameof(IsCertificateOfAnalysisReportIncludingTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTestResultValidationIncludingLine = group.Add(new VocabularyKey(nameof(IsTestResultValidationIncludingLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceptableQuantitativeLowerTestMeasurementLimit = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeLowerTestMeasurementLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceptableQuantitativeLowerTestMeasurementLimitPercentage = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeLowerTestMeasurementLimitPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAttributeId = group.Add(new VocabularyKey(nameof(ItemBatchAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemBatchAttributeValueOverridden = group.Add(new VocabularyKey(nameof(IsItemBatchAttributeValueOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestResultValue = group.Add(new VocabularyKey(nameof(QualityTestResultValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchAttributeValueDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsBatchAttributeValueDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderNumber = group.Add(new VocabularyKey(nameof(QualityOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandardQuantitativeTestMeasurement = group.Add(new VocabularyKey(nameof(StandardQuantitativeTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestId = group.Add(new VocabularyKey(nameof(QualityTestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestInstrumentId = group.Add(new VocabularyKey(nameof(QualityTestInstrumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestOutcomeStatus = group.Add(new VocabularyKey(nameof(QualityTestOutcomeStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityOrderSequenceNumber = group.Add(new VocabularyKey(nameof(QualityOrderSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestMeasurementUnitSymbol = group.Add(new VocabularyKey(nameof(TestMeasurementUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceptableQuantitativeUpperTestMeasurementLimit = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeUpperTestMeasurementLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AcceptableQuantitativeUpperTestMeasurementLimitPercentage = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeUpperTestMeasurementLimitPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestVariableId = group.Add(new VocabularyKey(nameof(QualityTestVariableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultQualitativeTestMeasurementOutcome = group.Add(new VocabularyKey(nameof(DefaultQualitativeTestMeasurementOutcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAttributeIntegerValue = group.Add(new VocabularyKey(nameof(ItemBatchAttributeIntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestResultIntegerValue = group.Add(new VocabularyKey(nameof(QualityTestResultIntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestResultDecimalValue = group.Add(new VocabularyKey(nameof(QualityTestResultDecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QualityTestResultDateValue = group.Add(new VocabularyKey(nameof(QualityTestResultDateValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAttributeDecimalValue = group.Add(new VocabularyKey(nameof(ItemBatchAttributeDecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAttributeDateValue = group.Add(new VocabularyKey(nameof(ItemBatchAttributeDateValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PdsBatchAttribType = group.Add(new VocabularyKey(nameof(PdsBatchAttribType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemBatchAttributeValue = group.Add(new VocabularyKey(nameof(ItemBatchAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AcceptableQualityLevelPercentage { get; private set; }
        public VocabularyKey FailureAction { get; private set; }
        public VocabularyKey IsCertificateOfAnalysisReportIncludingTestMeasurement { get; private set; }
        public VocabularyKey IsTestResultValidationIncludingLine { get; private set; }
        public VocabularyKey AcceptableQuantitativeLowerTestMeasurementLimit { get; private set; }
        public VocabularyKey AcceptableQuantitativeLowerTestMeasurementLimitPercentage { get; private set; }
        public VocabularyKey ItemBatchAttributeId { get; private set; }
        public VocabularyKey IsItemBatchAttributeValueOverridden { get; private set; }
        public VocabularyKey QualityTestResultValue { get; private set; }
        public VocabularyKey IsBatchAttributeValueDefaultedWithTestMeasurement { get; private set; }
        public VocabularyKey QualityOrderNumber { get; private set; }
        public VocabularyKey StandardQuantitativeTestMeasurement { get; private set; }
        public VocabularyKey QualityTestId { get; private set; }
        public VocabularyKey QualityTestInstrumentId { get; private set; }
        public VocabularyKey QualityTestOutcomeStatus { get; private set; }
        public VocabularyKey QualityOrderSequenceNumber { get; private set; }
        public VocabularyKey TestMeasurementUnitSymbol { get; private set; }
        public VocabularyKey AcceptableQuantitativeUpperTestMeasurementLimit { get; private set; }
        public VocabularyKey AcceptableQuantitativeUpperTestMeasurementLimitPercentage { get; private set; }
        public VocabularyKey QualityTestVariableId { get; private set; }
        public VocabularyKey DefaultQualitativeTestMeasurementOutcome { get; private set; }
        public VocabularyKey ItemBatchAttributeIntegerValue { get; private set; }
        public VocabularyKey QualityTestResultIntegerValue { get; private set; }
        public VocabularyKey QualityTestResultDecimalValue { get; private set; }
        public VocabularyKey QualityTestResultDateValue { get; private set; }
        public VocabularyKey ItemBatchAttributeDecimalValue { get; private set; }
        public VocabularyKey ItemBatchAttributeDateValue { get; private set; }
        public VocabularyKey PdsBatchAttribType { get; private set; }
        public VocabularyKey ItemBatchAttributeValue { get; private set; }


    }
}