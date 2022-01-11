using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventQualityOrderLineResultEntityVocabulary : SimpleVocabulary
    {
        public InventQualityOrderLineResultEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventQualityOrderLineResultEntity";
            KeyPrefix = "commonDataModel.inventqualityorderlineresultentity";
            KeySeparator = ".";
            Grouping = "/InventQualityOrderLineResultEntity";

            AddGroup("Common Data Model InventQualityOrderLineResultEntity Details", group =>
            {
                IsTestValidationIncludingResult = group.Add(new VocabularyKey(nameof(IsTestValidationIncludingResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultLineNumber = group.Add(new VocabularyKey(nameof(ResultLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ResultCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualityOrderNumber = group.Add(new VocabularyKey(nameof(QualityOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualityTestId = group.Add(new VocabularyKey(nameof(QualityTestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TestResult = group.Add(new VocabularyKey(nameof(TestResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultInventoryQuantity = group.Add(new VocabularyKey(nameof(ResultInventoryQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualityTestVariableOutcomeId = group.Add(new VocabularyKey(nameof(QualityTestVariableOutcomeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultValue = group.Add(new VocabularyKey(nameof(ResultValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualityOrderSequenceNumber = group.Add(new VocabularyKey(nameof(QualityOrderSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsTestValidationIncludingResult { get; private set; }
public VocabularyKey ResultLineNumber { get; private set; }
public VocabularyKey ResultCatchWeightQuantity { get; private set; }
public VocabularyKey QualityOrderNumber { get; private set; }
public VocabularyKey QualityTestId { get; private set; }
public VocabularyKey TestResult { get; private set; }
public VocabularyKey ResultInventoryQuantity { get; private set; }
public VocabularyKey QualityTestVariableOutcomeId { get; private set; }
public VocabularyKey ResultValue { get; private set; }
public VocabularyKey QualityOrderSequenceNumber { get; private set; }


    }
}