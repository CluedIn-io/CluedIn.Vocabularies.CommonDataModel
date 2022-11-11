using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateMasterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateMasterEntityVocabulary()
        {
            VocabularyName = "TMSTransportationRateMasterEntity";
            KeyPrefix = "commonDataModel.tmstransportationratemasterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateMasterEntity";

            AddGroup("TMSTransportationRateMasterEntity Details", group =>
            {
                MasterDescription = group.Add(new VocabularyKey(nameof(MasterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRatingMetadataId = group.Add(new VocabularyKey(nameof(TransportationRatingMetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterCode = group.Add(new VocabularyKey(nameof(MasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MasterDescription { get; private set; }
        public VocabularyKey TransportationRatingMetadataId { get; private set; }
        public VocabularyKey MasterCode { get; private set; }


    }
}