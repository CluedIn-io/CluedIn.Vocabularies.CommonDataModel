using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Service
{
    public class KnowledgeArticleIncidentVocabulary : SimpleVocabulary
    {
        public KnowledgeArticleIncidentVocabulary()
        {
            VocabularyName = "Knowledge Article Incident";
            KeyPrefix = "commonDataModel.knowledgearticleincident.service";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.KnowledgeArticleIncident;

            AddGroup("KnowledgeArticleIncident Details for Service", group =>
            {
			    KnowledgeArticleIncidentId = group.Add(new VocabularyKey(nameof(KnowledgeArticleIncidentId), "KnowledgeArticle Incident", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KnowledgeUsage = group.Add(new VocabularyKey(nameof(KnowledgeUsage), "Knowledge Usage ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsSentToCustomer = group.Add(new VocabularyKey(nameof(IsSentToCustomer), "Sent To Customer", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="IncidentId"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="KnowledgearticleId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey KnowledgeArticleIncidentId { get; private set; }
        public VocabularyKey KnowledgeUsage { get; private set; }
        public VocabularyKey IsSentToCustomer { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}