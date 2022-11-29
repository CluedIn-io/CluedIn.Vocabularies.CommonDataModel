using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationComponentVocabulary : SimpleVocabulary
    {
        public ObservationComponentVocabulary()
        {
            VocabularyName = "Observation Component";
            KeyPrefix = "commonDataModel.observationcomponent.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationComponent";

            AddGroup("ObservationComponent Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationComponentId = group.Add(new VocabularyKey(nameof(ObservationComponentId), "Observation Component", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueDateTime = group.Add(new VocabularyKey(nameof(ValueDateTime), "Component Value Date Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValuePeriodEndDate = group.Add(new VocabularyKey(nameof(ValuePeriodEndDate), "Component Value Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValuePeriodStartDate = group.Add(new VocabularyKey(nameof(ValuePeriodStartDate), "Component Value Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueQuantityComparator = group.Add(new VocabularyKey(nameof(ValueQuantityComparator), "Value Quantity Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueQuantitySystem = group.Add(new VocabularyKey(nameof(ValueQuantitySystem), "Value Quantity System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueQuantityUnit = group.Add(new VocabularyKey(nameof(ValueQuantityUnit), "Value Quantity Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueQuantityValue = group.Add(new VocabularyKey(nameof(ValueQuantityValue), "Value Quantity Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueRangeHighLimit = group.Add(new VocabularyKey(nameof(ValueRangeHighLimit), "Component Value Range High Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueRangeLowLimit = group.Add(new VocabularyKey(nameof(ValueRangeLowLimit), "Component Value Range Low Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominator = group.Add(new VocabularyKey(nameof(ValueRatioDenominator), "Component Value Ratio Denominator", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorComparator = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorComparator), "Value ratio Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorSystem = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorSystem), "Value ratio Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorUnit = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorUnit), "Value ratio Denominator unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorValue = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorValue), "Value ratio Denominator value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumerator = group.Add(new VocabularyKey(nameof(ValueRatioNumerator), "Component Value Ratio Numerator", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumeratorComparator = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorComparator), "Value Ratio Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumeratorSystem = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorSystem), "Value Ratio Numerator system", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumeratorUnit = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorUnit), "Value Ratio Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeData = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeData), "Component Value Sampled Data Type Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeDimension = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeDimension), "Component Value Sampled Data Type Dimension", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeFactor = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeFactor), "Component Value Sampled Data Type Factor", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeLowerLimit = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeLowerLimit), "Component Value Sampled Data Type Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeOrigin = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeOrigin), "Component Value Sampled Data Type Origin", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypePeriod = group.Add(new VocabularyKey(nameof(ValueSampledDataTypePeriod), "Component Value Sampled Data Type Period", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeUpperLimit = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeUpperLimit), "Component Value Sampled Data Type Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueString = group.Add(new VocabularyKey(nameof(ValueString), "Component Value String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueTime = group.Add(new VocabularyKey(nameof(ValueTime), "Component Value Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueType = group.Add(new VocabularyKey(nameof(ValueType), "Component Value Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObservationComponentId { get; private set; }
        public VocabularyKey ValueDateTime { get; private set; }
        public VocabularyKey ValuePeriodEndDate { get; private set; }
        public VocabularyKey ValuePeriodStartDate { get; private set; }
        public VocabularyKey ValueQuantityComparator { get; private set; }
        public VocabularyKey ValueQuantitySystem { get; private set; }
        public VocabularyKey ValueQuantityUnit { get; private set; }
        public VocabularyKey ValueQuantityValue { get; private set; }
        public VocabularyKey ValueRangeHighLimit { get; private set; }
        public VocabularyKey ValueRangeLowLimit { get; private set; }
        public VocabularyKey ValueRatioDenominator { get; private set; }
        public VocabularyKey ValueRatioDenominatorComparator { get; private set; }
        public VocabularyKey ValueRatioDenominatorSystem { get; private set; }
        public VocabularyKey ValueRatioDenominatorUnit { get; private set; }
        public VocabularyKey ValueRatioDenominatorValue { get; private set; }
        public VocabularyKey ValueRatioNumerator { get; private set; }
        public VocabularyKey ValueRatioNumeratorComparator { get; private set; }
        public VocabularyKey ValueRatioNumeratorSystem { get; private set; }
        public VocabularyKey ValueRatioNumeratorUnit { get; private set; }
        public VocabularyKey ValueSampledDataTypeData { get; private set; }
        public VocabularyKey ValueSampledDataTypeDimension { get; private set; }
        public VocabularyKey ValueSampledDataTypeFactor { get; private set; }
        public VocabularyKey ValueSampledDataTypeLowerLimit { get; private set; }
        public VocabularyKey ValueSampledDataTypeOrigin { get; private set; }
        public VocabularyKey ValueSampledDataTypePeriod { get; private set; }
        public VocabularyKey ValueSampledDataTypeUpperLimit { get; private set; }
        public VocabularyKey ValueString { get; private set; }
        public VocabularyKey ValueTime { get; private set; }
        public VocabularyKey ValueType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}