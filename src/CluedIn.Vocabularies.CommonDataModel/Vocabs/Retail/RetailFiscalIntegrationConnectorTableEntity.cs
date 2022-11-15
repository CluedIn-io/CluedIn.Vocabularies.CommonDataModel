using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailFiscalIntegrationConnectorTableEntityVocabulary : SimpleVocabulary
    {
        public RetailFiscalIntegrationConnectorTableEntityVocabulary()
        {
            VocabularyName = "Retail Fiscal Integration Connector Table Entity";
            KeyPrefix = "commonDataModel.retailfiscalintegrationconnectortableentity";
            KeySeparator = ".";
            Grouping = "/RetailFiscalIntegrationConnectorTableEntity";

            AddGroup("RetailFiscalIntegrationConnectorTableEntity Details", group =>
            {
                ConnectorName = group.Add(new VocabularyKey(nameof(ConnectorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Manifest = group.Add(new VocabularyKey(nameof(Manifest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConnectorName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Manifest { get; private set; }
    }
}