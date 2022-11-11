using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationPurchaseLoadBuildingTemplateSequenceEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationPurchaseLoadBuildingTemplateSequenceEntityVocabulary()
        {
            VocabularyName = "TMSTransportationPurchaseLoadBuildingTemplateSequenceEntity";
            KeyPrefix = "commonDataModel.tmstransportationpurchaseloadbuildingtemplatesequenceentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationPurchaseLoadBuildingTemplateSequenceEntity";

            AddGroup("TMSTransportationPurchaseLoadBuildingTemplateSequenceEntity Details", group =>
            {
                LoadTemplateId = group.Add(new VocabularyKey(nameof(LoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationPurchaseLoadBuildingTemplateName = group.Add(new VocabularyKey(nameof(TransportationPurchaseLoadBuildingTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LoadTemplateId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey TransportationPurchaseLoadBuildingTemplateName { get; private set; }


    }
}