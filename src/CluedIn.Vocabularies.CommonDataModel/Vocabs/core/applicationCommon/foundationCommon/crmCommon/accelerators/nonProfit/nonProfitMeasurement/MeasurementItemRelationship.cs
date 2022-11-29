using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitMeasurement
{
    public class MeasurementItemRelationshipVocabulary : SimpleVocabulary
    {
        public MeasurementItemRelationshipVocabulary()
        {
            VocabularyName = "Measurement Item Relationship";
            KeyPrefix = "commonDataModel.measurementitemrelationship.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = "/MeasurementItemRelationship";

            AddGroup("MeasurementItemRelationship Details for NonProfitMeasurement", group =>
            {
			    MeasurementItemRelationshipId = group.Add(new VocabularyKey(nameof(MeasurementItemRelationshipId), "Measurement Item Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Proportion = group.Add(new VocabularyKey(nameof(Proportion), "Proportion", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), "Relationship Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MeasurementItemRelationshipId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Proportion { get; private set; }
        public VocabularyKey RelationshipType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}