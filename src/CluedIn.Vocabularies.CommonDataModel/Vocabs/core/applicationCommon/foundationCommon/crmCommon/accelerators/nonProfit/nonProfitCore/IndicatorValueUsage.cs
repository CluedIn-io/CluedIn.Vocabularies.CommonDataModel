using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class IndicatorValueUsageVocabulary : SimpleVocabulary
    {
        public IndicatorValueUsageVocabulary()
        {
            VocabularyName = "Indicator Value Usage";
            KeyPrefix = "commonDataModel.indicatorvalueusage";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.IndicatorValueUsage;

            AddGroup("IndicatorValueUsage Details for NonProfitCore", group =>
            {
                IndicatorValueUsageId = group.Add(new VocabularyKey(nameof(IndicatorValueUsageId), "Indicator Value Usage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Usage Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsageType = group.Add(new VocabularyKey(nameof(UsageType), "Usage Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="IndicatorValueId"/> to Vocab 'IndicatorValue.cdm.json/IndicatorValue' with Property 'IndicatorValueId'
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
            ///Property <see cref="NeedId"/> to Vocab 'Need.cdm.json/Need' with Property 'NeedId'
            ///Property <see cref="WorkItemActionId"/> to Vocab 'WorkItemAction.cdm.json/WorkItemAction' with Property 'WorkItemActionId'
            ///Property <see cref="WorkItemId"/> to Vocab 'WorkItem.cdm.json/WorkItem' with Property 'WorkItemId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey IndicatorValueUsageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey UsageType { get; private set; }
    }
}