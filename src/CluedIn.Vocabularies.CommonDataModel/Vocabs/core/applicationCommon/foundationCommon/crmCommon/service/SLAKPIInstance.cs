using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Service
{
    public class SLAKPIInstanceVocabulary : SimpleVocabulary
    {
        public SLAKPIInstanceVocabulary()
        {
            VocabularyName = "SLAKPI Instance";
            KeyPrefix = "commonDataModel.slakpiinstance.service";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SLAKPIInstance;

            AddGroup("SLAKPIInstance Details for Service", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="Regarding"/> to Vocab 'Case.cdm.json/Case' with Property 'IncidentId'
            ///Property <see cref="Regarding"/> to Vocab 'ServiceActivity.cdm.json/ServiceActivity' with Property 'ActivityId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab '/core/applicationCommon/Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'BusinessUnitId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SLAKPIInstanceId"/> from Vocab 'Case.cdm.json/Case' with Property 'ResolveByKPIId'
            ///Property <see cref="SLAKPIInstanceId"/> from Vocab 'Case.cdm.json/Case' with Property 'FirstResponseByKPIId'
            ///Property <see cref="SLAKPIInstanceId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'ResolveByKPIId'
            ///Property <see cref="SLAKPIInstanceId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'FirstResponseByKPIId'
            #endregion
        }

        
    }
}