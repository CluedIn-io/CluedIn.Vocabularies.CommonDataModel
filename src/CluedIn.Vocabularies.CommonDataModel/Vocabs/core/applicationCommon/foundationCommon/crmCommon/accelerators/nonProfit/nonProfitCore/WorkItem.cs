using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class WorkItemVocabulary : SimpleVocabulary
    {
        public WorkItemVocabulary()
        {
            VocabularyName = "Work Item";
            KeyPrefix = "commonDataModel.workitem";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.WorkItem;

            AddGroup("WorkItem Details for NonProfitCore", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), "Work Item Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemId = group.Add(new VocabularyKey(nameof(WorkItemId), "Work Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemPriorityType = group.Add(new VocabularyKey(nameof(WorkItemPriorityType), "Work Item Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkItemType = group.Add(new VocabularyKey(nameof(WorkItemType), "Work Item Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReferralToId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="BeneficiaryId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RelatedDeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="NeedId"/> to Vocab 'Need.cdm.json/Need' with Property 'NeedId'
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
            ///Property <see cref="ParentWorkItemId"/> to Vocab 'WorkItem.cdm.json/WorkItem' with Property 'WorkItemId'
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
            ///Property <see cref="WorkItemId"/> from Vocab 'IndicatorValueUsage.cdm.json/IndicatorValueUsage' with Property 'WorkItemId'
            ///Property <see cref="WorkItemId"/> from Vocab 'WorkItem.cdm.json/WorkItem' with Property 'ParentWorkItemId'
            ///Property <see cref="WorkItemId"/> from Vocab 'WorkItemAction.cdm.json/WorkItemAction' with Property 'WorkItemId'
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey WorkItemId { get; private set; }
        public VocabularyKey WorkItemPriorityType { get; private set; }
        public VocabularyKey WorkItemType { get; private set; }
    }
}