using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EmploymentHistoryVocabulary : SimpleVocabulary
    {
        public EmploymentHistoryVocabulary()
        {
            VocabularyName = "Employment History";
            KeyPrefix = "commonDataModel.employmenthistory";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.EmploymentHistory;

            AddGroup("EmploymentHistory Details for NonProfitCore", group =>
            {
			    CurrentEmployment = group.Add(new VocabularyKey(nameof(CurrentEmployment), "Current Employment", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmployerName = group.Add(new VocabularyKey(nameof(EmployerName), "Employer Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), "Employment End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmploymentHistoryId = group.Add(new VocabularyKey(nameof(EmploymentHistoryId), "Employment History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), "Employment Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Occupation = group.Add(new VocabularyKey(nameof(Occupation), "Occupation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="EmployerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CurrentEmployment { get; private set; }
        public VocabularyKey EmployerName { get; private set; }
        public VocabularyKey EmploymentEndDate { get; private set; }
        public VocabularyKey EmploymentHistoryId { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Occupation { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Title { get; private set; }
    }
}