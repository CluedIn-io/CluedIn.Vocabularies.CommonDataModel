using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class KnowledgeArticleIncidentVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleIncidentVocabulary()
        {
            VocabularyName = "Knowledge Article Incident";
            KeyPrefix = "commonDataModel.knowledgearticleincident.service";
            KeySeparator = ".";
            Grouping = "/KnowledgeArticleIncident";

            AddGroup("KnowledgeArticleIncident Details for Service", group =>
            {
			    KnowledgeArticleIncidentId = group.Add(new VocabularyKey(nameof(KnowledgeArticleIncidentId), "KnowledgeArticle Incident", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KnowledgeUsage = group.Add(new VocabularyKey(nameof(KnowledgeUsage), "Knowledge Usage ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsSentToCustomer = group.Add(new VocabularyKey(nameof(IsSentToCustomer), "Sent To Customer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey KnowledgeArticleIncidentId { get; private set; }
        public VocabularyKey KnowledgeUsage { get; private set; }
        public VocabularyKey IsSentToCustomer { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}