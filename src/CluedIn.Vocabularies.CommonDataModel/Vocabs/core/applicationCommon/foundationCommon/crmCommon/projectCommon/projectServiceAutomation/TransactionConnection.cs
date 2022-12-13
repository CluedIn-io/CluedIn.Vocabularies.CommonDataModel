using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class TransactionConnectionVocabulary : SimpleVocabulary
    {
        public TransactionConnectionVocabulary()
        {
            VocabularyName = "Transaction Connection";
            KeyPrefix = "commonDataModel.transactionconnection";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.TransactionConnection;

            AddGroup("TransactionConnection Details for ProjectServiceAutomation", group =>
            {
                TransactionConnectionId = group.Add(new VocabularyKey(nameof(TransactionConnectionId), "Transaction Connection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction1 = group.Add(new VocabularyKey(nameof(Transaction1), "Transaction 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction1Role = group.Add(new VocabularyKey(nameof(Transaction1Role), "Transaction 1 Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction1Type = group.Add(new VocabularyKey(nameof(Transaction1Type), "Transaction 1 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction2 = group.Add(new VocabularyKey(nameof(Transaction2), "Transaction 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction2Role = group.Add(new VocabularyKey(nameof(Transaction2Role), "Transaction 2 Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction2Type = group.Add(new VocabularyKey(nameof(Transaction2Type), "Transaction 2 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Transaction1 { get; private set; }
        public VocabularyKey Transaction1Role { get; private set; }
        public VocabularyKey Transaction1Type { get; private set; }
        public VocabularyKey Transaction2 { get; private set; }
        public VocabularyKey Transaction2Role { get; private set; }
        public VocabularyKey Transaction2Type { get; private set; }
        public VocabularyKey TransactionConnectionId { get; private set; }
    }
}