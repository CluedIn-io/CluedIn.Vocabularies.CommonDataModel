using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationSalesLoadBuildingTemplateSequenceEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationSalesLoadBuildingTemplateSequenceEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Sales Load Building Template Sequence Entity";
            KeyPrefix = "commonDataModel.tmstransportationsalesloadbuildingtemplatesequenceentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationSalesLoadBuildingTemplateSequenceEntity";

            AddGroup("TMSTransportationSalesLoadBuildingTemplateSequenceEntity Details", group =>
            {
                LoadTemplateId = group.Add(new VocabularyKey(nameof(LoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationSalesLoadBuildingTemplateName = group.Add(new VocabularyKey(nameof(TransportationSalesLoadBuildingTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LoadTemplateId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey TransportationSalesLoadBuildingTemplateName { get; private set; }
    }
}