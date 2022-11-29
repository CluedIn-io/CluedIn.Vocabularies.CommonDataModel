using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceMetricVocabulary : SimpleVocabulary
    {
        public DeviceMetricVocabulary()
        {
            VocabularyName = "Device Metric";
            KeyPrefix = "commonDataModel.devicemetric.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceMetric";

            AddGroup("DeviceMetric Details for ElectronicMedicalRecords", group =>
            {
			    Category = group.Add(new VocabularyKey(nameof(Category), "Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Color = group.Add(new VocabularyKey(nameof(Color), "Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceMetricId = group.Add(new VocabularyKey(nameof(DeviceMetricId), "Device Metric", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MetricOperationalStatus = group.Add(new VocabularyKey(nameof(MetricOperationalStatus), "Metric Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Category { get; private set; }
        public VocabularyKey Color { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceMetricId { get; private set; }
        public VocabularyKey MetricOperationalStatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}