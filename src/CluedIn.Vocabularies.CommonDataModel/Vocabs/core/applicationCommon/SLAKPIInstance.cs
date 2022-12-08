using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class SLAKPIInstanceVocabulary : SimpleVocabulary
    {
        public SLAKPIInstanceVocabulary()
        {
            VocabularyName = "SLAKPI Instance";
            KeyPrefix = "commonDataModel.slakpiinstance.applicationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SLAKPIInstance;

            AddGroup("SLAKPIInstance Details for ApplicationCommon", group =>
            {
			    SLAKPIInstanceId = group.Add(new VocabularyKey(nameof(SLAKPIInstanceId), "SLA KPI InstanceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComputedFailureTime = group.Add(new VocabularyKey(nameof(ComputedFailureTime), "Computed Failure Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComputedWarningTime = group.Add(new VocabularyKey(nameof(ComputedWarningTime), "Computed Warning Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FailureTime = group.Add(new VocabularyKey(nameof(FailureTime), "Failure Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), "Owning Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SucceededOn = group.Add(new VocabularyKey(nameof(SucceededOn), "Succeeded On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WarningTime = group.Add(new VocabularyKey(nameof(WarningTime), "Warning Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WarningTimeReached = group.Add(new VocabularyKey(nameof(WarningTimeReached), "Warning Time Reached", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="Regarding"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="Regarding"/> to Vocab 'Activity.cdm.json/Activity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="Regarding"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="Regarding"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Regarding"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Regarding"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="Regarding"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey SLAKPIInstanceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ComputedFailureTime { get; private set; }
        public VocabularyKey ComputedWarningTime { get; private set; }
        public VocabularyKey FailureTime { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SucceededOn { get; private set; }
        public VocabularyKey WarningTime { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey WarningTimeReached { get; private set; }
    }
}