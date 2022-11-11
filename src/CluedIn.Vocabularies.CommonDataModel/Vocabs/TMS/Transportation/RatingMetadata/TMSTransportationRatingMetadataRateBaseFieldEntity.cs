using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRatingMetadataRateBaseFieldEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRatingMetadataRateBaseFieldEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationRatingMetadataRateBaseFieldEntity";
            KeyPrefix = "commonDataModel.tmstransportationratingmetadataratebasefieldentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRatingMetadataRateBaseFieldEntity";

            AddGroup("Common Data Model TMSTransportationRatingMetadataRateBaseFieldEntity Details", group =>
            {
                FieldDataType = group.Add(new VocabularyKey(nameof(FieldDataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRatingMetadataId = group.Add(new VocabularyKey(nameof(TransportationRatingMetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldSequence = group.Add(new VocabularyKey(nameof(FieldSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMandatoryField = group.Add(new VocabularyKey(nameof(IsMandatoryField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldLookupType = group.Add(new VocabularyKey(nameof(FieldLookupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FieldDataType { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey TransportationRatingMetadataId { get; private set; }
        public VocabularyKey FieldSequence { get; private set; }
        public VocabularyKey IsMandatoryField { get; private set; }
        public VocabularyKey FieldLookupType { get; private set; }


    }
}