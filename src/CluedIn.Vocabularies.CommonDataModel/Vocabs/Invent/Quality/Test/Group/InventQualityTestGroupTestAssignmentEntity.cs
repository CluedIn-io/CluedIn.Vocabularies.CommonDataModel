using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityTestGroupTestAssignmentEntityVocabulary : SimpleVocabulary
    {
        public InventQualityTestGroupTestAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventQualityTestGroupTestAssignmentEntity";
            KeyPrefix = "commonDataModel.inventqualitytestgrouptestassignmententity";
            KeySeparator = ".";
            Grouping = "/InventQualityTestGroupTestAssignmentEntity";

            AddGroup("Common Data Model InventQualityTestGroupTestAssignmentEntity Details", group =>
            {
                AcceptableQualityLevelPercentage = group.Add(new VocabularyKey(nameof(AcceptableQualityLevelPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FailureAction = group.Add(new VocabularyKey(nameof(FailureAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCertificateOfAnalysisReportIncludingTestMeasurement = group.Add(new VocabularyKey(nameof(IsCertificateOfAnalysisReportIncludingTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcceptableQuantitativeLowerTestMeasurementLimit = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeLowerTestMeasurementLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcceptableQuantitativeLowerTestMeasurementLimitPercentage = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeLowerTestMeasurementLimitPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchAttributeId = group.Add(new VocabularyKey(nameof(ItemBatchAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TestResultDeterminationMethod = group.Add(new VocabularyKey(nameof(TestResultDeterminationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBatchAttributeValueDefaultedWithTestMeasurement = group.Add(new VocabularyKey(nameof(IsBatchAttributeValueDefaultedWithTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StandardQuantitativeTestMeasurement = group.Add(new VocabularyKey(nameof(StandardQuantitativeTestMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualityTestGroupId = group.Add(new VocabularyKey(nameof(QualityTestGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualityTestId = group.Add(new VocabularyKey(nameof(QualityTestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultQualityTestInstrumentId = group.Add(new VocabularyKey(nameof(DefaultQualityTestInstrumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TestMeasurementUnitSymbol = group.Add(new VocabularyKey(nameof(TestMeasurementUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcceptableQuantitativeUpperTestMeasurementLimit = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeUpperTestMeasurementLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AcceptableQuantitativeUpperTestMeasurementLimitPercentage = group.Add(new VocabularyKey(nameof(AcceptableQuantitativeUpperTestMeasurementLimitPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EffectiveDateTime = group.Add(new VocabularyKey(nameof(EffectiveDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpirationDateTime = group.Add(new VocabularyKey(nameof(ExpirationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualitativeTestVariableId = group.Add(new VocabularyKey(nameof(QualitativeTestVariableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultQualitativeTestMeasurementOutcome = group.Add(new VocabularyKey(nameof(DefaultQualitativeTestMeasurementOutcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AcceptableQualityLevelPercentage { get; private set; }
public VocabularyKey FailureAction { get; private set; }
public VocabularyKey IsCertificateOfAnalysisReportIncludingTestMeasurement { get; private set; }
public VocabularyKey AcceptableQuantitativeLowerTestMeasurementLimit { get; private set; }
public VocabularyKey AcceptableQuantitativeLowerTestMeasurementLimitPercentage { get; private set; }
public VocabularyKey ItemBatchAttributeId { get; private set; }
public VocabularyKey TestResultDeterminationMethod { get; private set; }
public VocabularyKey IsBatchAttributeValueDefaultedWithTestMeasurement { get; private set; }
public VocabularyKey StandardQuantitativeTestMeasurement { get; private set; }
public VocabularyKey QualityTestGroupId { get; private set; }
public VocabularyKey QualityTestId { get; private set; }
public VocabularyKey DefaultQualityTestInstrumentId { get; private set; }
public VocabularyKey SequenceNumber { get; private set; }
public VocabularyKey TestMeasurementUnitSymbol { get; private set; }
public VocabularyKey AcceptableQuantitativeUpperTestMeasurementLimit { get; private set; }
public VocabularyKey AcceptableQuantitativeUpperTestMeasurementLimitPercentage { get; private set; }
public VocabularyKey EffectiveDateTime { get; private set; }
public VocabularyKey ExpirationDateTime { get; private set; }
public VocabularyKey QualitativeTestVariableId { get; private set; }
public VocabularyKey DefaultQualitativeTestMeasurementOutcome { get; private set; }


    }
}