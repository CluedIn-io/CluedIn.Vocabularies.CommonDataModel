using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationVocabulary : SimpleVocabulary
    {
        public ObservationVocabulary()
        {
            VocabularyName = "Observation";
            KeyPrefix = "commonDataModel.observation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Observation";

            AddGroup("Observation Details for ElectronicMedicalRecords", group =>
            {
			    Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceType = group.Add(new VocabularyKey(nameof(DeviceType), "Device Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveEnd = group.Add(new VocabularyKey(nameof(EffectiveEnd), "Effective End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveStart = group.Add(new VocabularyKey(nameof(EffectiveStart), "Effective Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveType = group.Add(new VocabularyKey(nameof(EffectiveType), "Effective Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveTypeDateTime = group.Add(new VocabularyKey(nameof(EffectiveTypeDateTime), "Effective Type Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Identifier = group.Add(new VocabularyKey(nameof(Identifier), "Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IssuedDate = group.Add(new VocabularyKey(nameof(IssuedDate), "Issued Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationId = group.Add(new VocabularyKey(nameof(ObservationId), "Observation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationNumber = group.Add(new VocabularyKey(nameof(ObservationNumber), "Observation Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueBoolean = group.Add(new VocabularyKey(nameof(ValueBoolean), "Value Boolean", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ValueDateType = group.Add(new VocabularyKey(nameof(ValueDateType), "Value Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValuePeriodEndDate = group.Add(new VocabularyKey(nameof(ValuePeriodEndDate), "Value Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValuePeriodStartDate = group.Add(new VocabularyKey(nameof(ValuePeriodStartDate), "Value Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueQuantitySystem = group.Add(new VocabularyKey(nameof(ValueQuantitySystem), "Value Quantity System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueQuantityUnit = group.Add(new VocabularyKey(nameof(ValueQuantityUnit), "Value Quantity Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRangeHighLimit = group.Add(new VocabularyKey(nameof(ValueRangeHighLimit), "Value Range High Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueRangeLowLimit = group.Add(new VocabularyKey(nameof(ValueRangeLowLimit), "Value Range Low Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorComparator = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorComparator), "Ratio Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorSystem = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorSystem), "Ratio Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorUnit = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorUnit), "Ratio Denominator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioDenominatorValue = group.Add(new VocabularyKey(nameof(ValueRatioDenominatorValue), "Ratio Denominator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumeratorComparator = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorComparator), "Ratio Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumeratorSystem = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorSystem), "Ratio Numerator  System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumeratorUnit = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorUnit), "Ratio Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueRatioNumeratorValue = group.Add(new VocabularyKey(nameof(ValueRatioNumeratorValue), "Ratio Numerator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeData = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeData), "Value Sampled DataType Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeDimension = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeDimension), "Value Sampled Data Type Dimension", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeFactor = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeFactor), "Value Sampled Data Type Factor", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeLowerLimit = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeLowerLimit), "Value Sampled Data Type Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeOrigin = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeOrigin), "Value Sampled Data Type Origin", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypePeriod = group.Add(new VocabularyKey(nameof(ValueSampledDataTypePeriod), "Value Sampled Data Type Period", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueSampledDataTypeUpperLimit = group.Add(new VocabularyKey(nameof(ValueSampledDataTypeUpperLimit), "Value Sampled Data Type Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueString = group.Add(new VocabularyKey(nameof(ValueString), "Value String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueType = group.Add(new VocabularyKey(nameof(ValueType), "Value Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueTypeQuantityComparator = group.Add(new VocabularyKey(nameof(ValueTypeQuantityComparator), "Quantity Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueTypeQuantityValue = group.Add(new VocabularyKey(nameof(ValueTypeQuantityValue), "Quantity Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Observation Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Comment { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceType { get; private set; }
        public VocabularyKey EffectiveEnd { get; private set; }
        public VocabularyKey EffectiveStart { get; private set; }
        public VocabularyKey EffectiveType { get; private set; }
        public VocabularyKey EffectiveTypeDateTime { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey IssuedDate { get; private set; }
        public VocabularyKey ObservationId { get; private set; }
        public VocabularyKey ObservationNumber { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey ValueBoolean { get; private set; }
        public VocabularyKey ValueDateType { get; private set; }
        public VocabularyKey ValuePeriodEndDate { get; private set; }
        public VocabularyKey ValuePeriodStartDate { get; private set; }
        public VocabularyKey ValueQuantitySystem { get; private set; }
        public VocabularyKey ValueQuantityUnit { get; private set; }
        public VocabularyKey ValueRangeHighLimit { get; private set; }
        public VocabularyKey ValueRangeLowLimit { get; private set; }
        public VocabularyKey ValueRatioDenominatorComparator { get; private set; }
        public VocabularyKey ValueRatioDenominatorSystem { get; private set; }
        public VocabularyKey ValueRatioDenominatorUnit { get; private set; }
        public VocabularyKey ValueRatioDenominatorValue { get; private set; }
        public VocabularyKey ValueRatioNumeratorComparator { get; private set; }
        public VocabularyKey ValueRatioNumeratorSystem { get; private set; }
        public VocabularyKey ValueRatioNumeratorUnit { get; private set; }
        public VocabularyKey ValueRatioNumeratorValue { get; private set; }
        public VocabularyKey ValueSampledDataTypeData { get; private set; }
        public VocabularyKey ValueSampledDataTypeDimension { get; private set; }
        public VocabularyKey ValueSampledDataTypeFactor { get; private set; }
        public VocabularyKey ValueSampledDataTypeLowerLimit { get; private set; }
        public VocabularyKey ValueSampledDataTypeOrigin { get; private set; }
        public VocabularyKey ValueSampledDataTypePeriod { get; private set; }
        public VocabularyKey ValueSampledDataTypeUpperLimit { get; private set; }
        public VocabularyKey ValueString { get; private set; }
        public VocabularyKey ValueType { get; private set; }
        public VocabularyKey ValueTypeQuantityComparator { get; private set; }
        public VocabularyKey ValueTypeQuantityValue { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}