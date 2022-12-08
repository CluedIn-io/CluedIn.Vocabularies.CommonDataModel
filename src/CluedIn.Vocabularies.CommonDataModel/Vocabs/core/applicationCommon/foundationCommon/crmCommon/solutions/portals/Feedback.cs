using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Portals
{
    public class FeedbackVocabulary : SimpleVocabulary
    {
        public FeedbackVocabulary()
        {
            VocabularyName = "Feedback";
            KeyPrefix = "commonDataModel.feedback.portals";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Feedback;

            AddGroup("Feedback Details for Portals", group =>
            {
			    PublishedToWeb = group.Add(new VocabularyKey(nameof(PublishedToWeb), "Published To Web", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AuthorURL = group.Add(new VocabularyKey(nameof(AuthorURL), "Author URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    AdxContactEmail = group.Add(new VocabularyKey(nameof(AdxContactEmail), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    AdxContactUsername = group.Add(new VocabularyKey(nameof(AdxContactUsername), "Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByContact = group.Add(new VocabularyKey(nameof(AdxCreatedByContact), "Created By Name (Contact)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedByContact"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedOnBehalfByContact"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedByContact"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedOnBehalfByContact"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Feedback.cdm.json/Feedback' with Property 'FeedbackId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="ClosedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Feedback.cdm.json/Feedback' with Property 'FeedbackId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="FeedbackId"/> from Vocab 'Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            ///Property <see cref="FeedbackId"/> from Vocab '/core/applicationCommon/Feedback.cdm.json/Feedback' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey PublishedToWeb { get; private set; }
        public VocabularyKey AuthorURL { get; private set; }
        public VocabularyKey AdxContactEmail { get; private set; }
        public VocabularyKey AdxContactUsername { get; private set; }
        public VocabularyKey AdxCreatedByContact { get; private set; }
    }
}