using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTransferLoadBuildingTemplateSequenceEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTransferLoadBuildingTemplateSequenceEntityVocabulary()
        {
            VocabularyName = "TMSTransportationTransferLoadBuildingTemplateSequenceEntity";
            KeyPrefix = "commonDataModel.tmstransportationtransferloadbuildingtemplatesequenceentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTransferLoadBuildingTemplateSequenceEntity";

            AddGroup("TMSTransportationTransferLoadBuildingTemplateSequenceEntity Details", group =>
            {
                LoadTemplateId = group.Add(new VocabularyKey(nameof(LoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationTransferLoadBuildingTemplateName = group.Add(new VocabularyKey(nameof(TransportationTransferLoadBuildingTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LoadTemplateId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey TransportationTransferLoadBuildingTemplateName { get; private set; }


    }
}