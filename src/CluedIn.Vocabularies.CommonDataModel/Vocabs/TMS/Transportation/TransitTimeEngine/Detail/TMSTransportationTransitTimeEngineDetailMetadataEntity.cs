using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTransitTimeEngineDetailMetadataEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTransitTimeEngineDetailMetadataEntityVocabulary()
        {
            VocabularyName = "TMSTransportationTransitTimeEngineDetailMetadataEntity";
            KeyPrefix = "commonDataModel.tmstransportationtransittimeenginedetailmetadataentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTransitTimeEngineDetailMetadataEntity";

            AddGroup("TMSTransportationTransitTimeEngineDetailMetadataEntity Details", group =>
            {
                FieldLookupType = group.Add(new VocabularyKey(nameof(FieldLookupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMandatoryField = group.Add(new VocabularyKey(nameof(IsMandatoryField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldSequenceNumber = group.Add(new VocabularyKey(nameof(FieldSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTransitTimeEngineId = group.Add(new VocabularyKey(nameof(TransportationTransitTimeEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FieldLookupType { get; private set; }
        public VocabularyKey IsMandatoryField { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey FieldSequenceNumber { get; private set; }
        public VocabularyKey TransportationTransitTimeEngineId { get; private set; }


    }
}