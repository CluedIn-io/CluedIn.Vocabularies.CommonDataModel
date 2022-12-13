using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class WorkItemActionVocabulary : SimpleVocabulary
    {
        public WorkItemActionVocabulary()
        {
            VocabularyName = "Work Item Action";
            KeyPrefix = "commonDataModel.workitemaction";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.WorkItemAction;

            AddGroup("WorkItemAction Details for NonProfitCore", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Work Item Action Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemActionDueDate = group.Add(new VocabularyKey(nameof(WorkItemActionDueDate), "Work Item Action Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemActionId = group.Add(new VocabularyKey(nameof(WorkItemActionId), "Work Item Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemActionType = group.Add(new VocabularyKey(nameof(WorkItemActionType), "Work Item Action Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReferralToId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="NeedId"/> to Vocab 'Need.cdm.json/Need' with Property 'NeedId'
            ///Property <see cref="WorkItemId"/> to Vocab 'WorkItem.cdm.json/WorkItem' with Property 'WorkItemId'
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
            ///Property <see cref="WorkItemActionId"/> from Vocab 'IndicatorValueUsage.cdm.json/IndicatorValueUsage' with Property 'WorkItemActionId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey WorkItemActionDueDate { get; private set; }
        public VocabularyKey WorkItemActionId { get; private set; }
        public VocabularyKey WorkItemActionType { get; private set; }
    }
}