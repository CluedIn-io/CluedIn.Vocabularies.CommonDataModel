using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FieldMappingVocabulary : SimpleVocabulary
    {
        public FieldMappingVocabulary()
        {
            VocabularyName = "Field Mapping";
            KeyPrefix = "commonDataModel.fieldmapping";
            KeySeparator = ".";
            Grouping = "/FieldMapping";

            AddGroup("FieldMapping Details", group =>
            {
                LeadField = group.Add(new VocabularyKey(nameof(LeadField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedinfieldmappingId = group.Add(new VocabularyKey(nameof(LinkedinfieldmappingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInPredefinedField = group.Add(new VocabularyKey(nameof(LinkedInPredefinedField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LeadField { get; private set; }
        public VocabularyKey LinkedinfieldmappingId { get; private set; }
        public VocabularyKey LinkedInPredefinedField { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}