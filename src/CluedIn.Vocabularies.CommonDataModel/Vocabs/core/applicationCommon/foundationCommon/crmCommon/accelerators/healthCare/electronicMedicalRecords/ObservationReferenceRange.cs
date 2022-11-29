using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationReferenceRangeVocabulary : SimpleVocabulary
    {
        public ObservationReferenceRangeVocabulary()
        {
            VocabularyName = "Observation Reference Range";
            KeyPrefix = "commonDataModel.observationreferencerange.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationReferenceRange";

            AddGroup("ObservationReferenceRange Details for ElectronicMedicalRecords", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationReferenceRangeId = group.Add(new VocabularyKey(nameof(ObservationReferenceRangeId), "Observation Reference Range", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RangeHigh = group.Add(new VocabularyKey(nameof(RangeHigh), "Reference Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RangeLow = group.Add(new VocabularyKey(nameof(RangeLow), "Reference Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RangeText = group.Add(new VocabularyKey(nameof(RangeText), "Range Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReferenceRangeAgeHigh = group.Add(new VocabularyKey(nameof(ReferenceRangeAgeHigh), "Reference Range Age High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ReferenceRangeAgeLow = group.Add(new VocabularyKey(nameof(ReferenceRangeAgeLow), "Reference Range Age Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ObservationReferenceRangeId { get; private set; }
        public VocabularyKey RangeHigh { get; private set; }
        public VocabularyKey RangeLow { get; private set; }
        public VocabularyKey RangeText { get; private set; }
        public VocabularyKey ReferenceRangeAgeHigh { get; private set; }
        public VocabularyKey ReferenceRangeAgeLow { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}