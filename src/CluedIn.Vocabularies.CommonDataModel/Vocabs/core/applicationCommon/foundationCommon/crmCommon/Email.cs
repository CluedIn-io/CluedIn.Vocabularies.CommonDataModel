using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.CrmCommon
{
    public class EmailVocabulary : SimpleVocabulary
    {
        public EmailVocabulary()
        {
            VocabularyName = "Email";
            KeyPrefix = "commonDataModel.email.crmcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Email;

            AddGroup("Email Details for CrmCommon", group =>
            {
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BCC = group.Add(new VocabularyKey(nameof(BCC), "Bcc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CC = group.Add(new VocabularyKey(nameof(CC), "Cc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="EmailSender"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="EmailSender"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="EmailSender"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="EmailSender"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="RegardingObjectId"/> to Vocab '/core/applicationCommon/foundationCommon/KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ParentActivityId"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="EmailSender"/> to Vocab '/core/applicationCommon/Queue.cdm.json/Queue' with Property 'QueueId'
            ///Property <see cref="EmailSender"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="EmailSender"/> to Vocab 'service/FacilityEquipment.cdm.json/FacilityEquipment' with Property 'EquipmentId'
            ///Property <see cref="EmailSender"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="ServiceId"/> to Vocab 'service/Service.cdm.json/Service' with Property 'ServiceId'
            ///Property <see cref="ParentActivityId"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ActivityId"/> from Vocab 'CampaignResponse.cdm.json/CampaignResponse' with Property 'OriginatingActivityId'
            ///Property <see cref="ActivityId"/> from Vocab 'Email.cdm.json/Email' with Property 'ParentActivityId'
            ///Property <see cref="ActivityId"/> from Vocab '/core/applicationCommon/ActivityParty.cdm.json/ActivityParty' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="ActivityId"/> from Vocab '/core/applicationCommon/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="ActivityId"/> from Vocab '/core/applicationCommon/Email.cdm.json/Email' with Property 'ParentActivityId'
            ///Property <see cref="ActivityId"/> from Vocab '/core/applicationCommon/Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="ActivityId"/> from Vocab '/core/applicationCommon/QueueItem.cdm.json/QueueItem' with Property 'ObjectId'
            ///Property <see cref="ActivityId"/> from Vocab '/core/applicationCommon/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="ActivityId"/> from Vocab 'service/ActivityParty.cdm.json/ActivityParty' with Property 'ActivityId'
            ///Property <see cref="ActivityId"/> from Vocab 'service/SLAKPIInstance.cdm.json/SLAKPIInstance' with Property 'Regarding'
            ///Property <see cref="ActivityId"/> from Vocab 'solutions/marketing/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="ActivityId"/> from Vocab 'solutions/marketing/Connection.cdm.json/Connection' with Property 'Record1Id'
            #endregion
        }

        public VocabularyKey To { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey CC { get; private set; }
    }
}