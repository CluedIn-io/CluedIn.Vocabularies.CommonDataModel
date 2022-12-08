using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitVolunteers
{
    public class ScheduleVocabulary : SimpleVocabulary
    {
        public ScheduleVocabulary()
        {
            VocabularyName = "Schedule";
            KeyPrefix = "commonDataModel.schedule.nonprofitvolunteers";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Schedule;

            AddGroup("Schedule Details for NonProfitVolunteers", group =>
            {
			    EffectiveFrom = group.Add(new VocabularyKey(nameof(EffectiveFrom), "Effective From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveTo = group.Add(new VocabularyKey(nameof(EffectiveTo), "Effective To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndPeriod = group.Add(new VocabularyKey(nameof(EndPeriod), "End Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HoursPerDay = group.Add(new VocabularyKey(nameof(HoursPerDay), "Hours per Day", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduleId = group.Add(new VocabularyKey(nameof(ScheduleId), "Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartPeriod = group.Add(new VocabularyKey(nameof(StartPeriod), "Start Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalHours = group.Add(new VocabularyKey(nameof(TotalHours), "Total Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    WorkingDays = group.Add(new VocabularyKey(nameof(WorkingDays), "Working Days", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="OmtSchedDefaultHardCreditToCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReceiptOnAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OmtSchedDefaultHardCreditToCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="BookableResourceId"/> to Vocab '/core/applicationCommon/foundationCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ProjectTeamId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'ProjectTeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey EffectiveFrom { get; private set; }
        public VocabularyKey EffectiveTo { get; private set; }
        public VocabularyKey EndPeriod { get; private set; }
        public VocabularyKey HoursPerDay { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduleId { get; private set; }
        public VocabularyKey StartPeriod { get; private set; }
        public VocabularyKey TotalHours { get; private set; }
        public VocabularyKey WorkingDays { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}