using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRatingMetadataEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRatingMetadataEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationRatingMetadataEntity";
            KeyPrefix = "commonDataModel.tmstransportationratingmetadataentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRatingMetadataEntity";

            AddGroup("Common Data Model TMSTransportationRatingMetadataEntity Details", group =>
            {
                MetadataName = group.Add(new VocabularyKey(nameof(MetadataName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MetadataId = group.Add(new VocabularyKey(nameof(MetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MetadataName { get; private set; }
public VocabularyKey MetadataId { get; private set; }


    }
}