using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationZoneDetailMetadataEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationZoneDetailMetadataEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationZoneDetailMetadataEntity";
            KeyPrefix = "commonDataModel.tmstransportationzonedetailmetadataentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationZoneDetailMetadataEntity";

            AddGroup("Common Data Model TMSTransportationZoneDetailMetadataEntity Details", group =>
            {
                IsMandatoryField = group.Add(new VocabularyKey(nameof(IsMandatoryField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldSequenceNumber = group.Add(new VocabularyKey(nameof(FieldSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationZoneMasterCode = group.Add(new VocabularyKey(nameof(TransportationZoneMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldLookupType = group.Add(new VocabularyKey(nameof(FieldLookupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsMandatoryField { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey FieldSequenceNumber { get; private set; }
        public VocabularyKey TransportationZoneMasterCode { get; private set; }
        public VocabularyKey FieldLookupType { get; private set; }


    }
}