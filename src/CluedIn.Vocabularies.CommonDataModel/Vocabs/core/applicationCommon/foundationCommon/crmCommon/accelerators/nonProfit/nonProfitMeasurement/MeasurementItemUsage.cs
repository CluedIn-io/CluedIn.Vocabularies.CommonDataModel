using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitMeasurement
{
    public class MeasurementItemUsageVocabulary : SimpleVocabulary
    {
        public MeasurementItemUsageVocabulary()
        {
            VocabularyName = "Measurement Item Usage";
            KeyPrefix = "commonDataModel.measurementitemusage.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = "/MeasurementItemUsage";

            AddGroup("MeasurementItemUsage Details for NonProfitMeasurement", group =>
            {
			    MeasurementItemUsageId = group.Add(new VocabularyKey(nameof(MeasurementItemUsageId), "Measurement Item Usage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MeasurementItemUsageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}