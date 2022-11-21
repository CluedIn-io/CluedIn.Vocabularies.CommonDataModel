using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationShipmentLoadBuildingTemplateSequenceEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationShipmentLoadBuildingTemplateSequenceEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Shipment Load Building Template Sequence Entity";
            KeyPrefix = "commonDataModel.tmstransportationshipmentloadbuildingtemplatesequenceentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationShipmentLoadBuildingTemplateSequenceEntity";

            AddGroup("TMSTransportationShipmentLoadBuildingTemplateSequenceEntity Details", group =>
            {
                LoadTemplateId = group.Add(new VocabularyKey(nameof(LoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationShipmentLoadBuildingTemplateName = group.Add(new VocabularyKey(nameof(TransportationShipmentLoadBuildingTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LoadTemplateId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey TransportationShipmentLoadBuildingTemplateName { get; private set; }
    }
}