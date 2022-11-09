using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationShipmentLoadBuildingTemplateSequenceEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationShipmentLoadBuildingTemplateSequenceEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationShipmentLoadBuildingTemplateSequenceEntity";
            KeyPrefix = "commonDataModel.tmstransportationshipmentloadbuildingtemplatesequenceentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationShipmentLoadBuildingTemplateSequenceEntity";

            AddGroup("Common Data Model TMSTransportationShipmentLoadBuildingTemplateSequenceEntity Details", group =>
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