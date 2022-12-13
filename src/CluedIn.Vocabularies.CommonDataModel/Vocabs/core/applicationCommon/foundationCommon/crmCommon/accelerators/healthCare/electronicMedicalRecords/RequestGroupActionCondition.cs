using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class RequestGroupActionConditionVocabulary : SimpleVocabulary
    {
        public RequestGroupActionConditionVocabulary()
        {
            VocabularyName = "Request Group Action Condition";
            KeyPrefix = "commonDataModel.requestgroupactioncondition";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RequestGroupActionCondition;

            AddGroup("RequestGroupActionCondition Details for ElectronicMedicalRecords", group =>
            {
                ActionConditionDescription = group.Add(new VocabularyKey(nameof(ActionConditionDescription), "Action Condition Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionConditionExpression = group.Add(new VocabularyKey(nameof(ActionConditionExpression), "Action Condition Expression", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionConditionKind = group.Add(new VocabularyKey(nameof(ActionConditionKind), "Action Condition Kind", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionConditionLanguage = group.Add(new VocabularyKey(nameof(ActionConditionLanguage), "Action Condition Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestGroupActionConditionId = group.Add(new VocabularyKey(nameof(RequestGroupActionConditionId), "Request Group Action Condition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="RequestGroupActionId"/> to Vocab 'RequestGroupAction.cdm.json/RequestGroupAction' with Property 'RequestGroupActionId'
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

        public VocabularyKey ActionConditionDescription { get; private set; }
        public VocabularyKey ActionConditionExpression { get; private set; }
        public VocabularyKey ActionConditionKind { get; private set; }
        public VocabularyKey ActionConditionLanguage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionConditionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}