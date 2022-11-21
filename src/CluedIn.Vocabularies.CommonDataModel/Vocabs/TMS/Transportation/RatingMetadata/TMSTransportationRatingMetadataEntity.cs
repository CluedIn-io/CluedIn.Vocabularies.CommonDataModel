using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRatingMetadataEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRatingMetadataEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Rating Metadata Entity";
            KeyPrefix = "commonDataModel.tmstransportationratingmetadataentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRatingMetadataEntity";

            AddGroup("TMSTransportationRatingMetadataEntity Details", group =>
            {
                MetadataName = group.Add(new VocabularyKey(nameof(MetadataName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MetadataId = group.Add(new VocabularyKey(nameof(MetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MetadataName { get; private set; }
        public VocabularyKey MetadataId { get; private set; }
    }
}