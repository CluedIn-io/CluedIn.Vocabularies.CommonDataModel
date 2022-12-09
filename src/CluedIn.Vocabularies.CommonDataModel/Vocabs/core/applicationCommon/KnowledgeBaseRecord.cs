using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class KnowledgeBaseRecordVocabulary : SimpleVocabulary
    {
        public KnowledgeBaseRecordVocabulary()
        {
            VocabularyName = "Knowledge Base Record";
            KeyPrefix = "commonDataModel.knowledgebaserecord";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.KnowledgeBaseRecord;

            AddGroup("KnowledgeBaseRecord Details for ApplicationCommon", group =>
            {
			    KnowledgeBaseRecordId = group.Add(new VocabularyKey(nameof(KnowledgeBaseRecordId), "ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "KB Record Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrivateUrl = group.Add(new VocabularyKey(nameof(PrivateUrl), "Private URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    PublicUrl = group.Add(new VocabularyKey(nameof(PublicUrl), "Public URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    UniqueId = group.Add(new VocabularyKey(nameof(UniqueId), "Unique ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="KnowledgeBaseRecordId"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Note.cdm.json/Note' with Property 'ObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/CampaignResponse.cdm.json/CampaignResponse' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/RecurringAppointment.cdm.json/RecurringAppointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/AppointmentEMR.cdm.json/AppointmentEMR' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/sales/OpportunityClose.cdm.json/OpportunityClose' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/sales/OrderClose.cdm.json/OrderClose' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/service/CaseResolution.cdm.json/CaseResolution' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/service/IncidentKnowledgeBaseRecord.cdm.json/IncidentKnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/service/ServiceActivity.cdm.json/ServiceActivity' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/service/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Appointment.cdm.json/Appointment' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/PhoneCall.cdm.json/PhoneCall' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Task.cdm.json/Task' with Property 'RegardingObjectId'
            ///Property <see cref="KnowledgeBaseRecordId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey KnowledgeBaseRecordId { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey PrivateUrl { get; private set; }
        public VocabularyKey PublicUrl { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey UniqueId { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}