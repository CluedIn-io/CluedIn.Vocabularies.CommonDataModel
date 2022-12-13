using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ActualDataExportVocabulary : SimpleVocabulary
    {
        public ActualDataExportVocabulary()
        {
            VocabularyName = "Actual Data Export";
            KeyPrefix = "commonDataModel.actualdataexport";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ActualDataExport;

            AddGroup("ActualDataExport Details for ProjectServiceAutomation", group =>
            {
                DataExportId = group.Add(new VocabularyKey(nameof(DataExportId), "Actual Data Export", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataToken = group.Add(new VocabularyKey(nameof(DataToken), "Data Token", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), "Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportedRecordCount = group.Add(new VocabularyKey(nameof(ExportedRecordCount), "Exported Record Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ExportStatus = group.Add(new VocabularyKey(nameof(ExportStatus), "Export Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedEntityData = group.Add(new VocabularyKey(nameof(LinkedEntityData), "Linked Entity Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PagingData = group.Add(new VocabularyKey(nameof(PagingData), "Paging Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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

        public VocabularyKey DataExportId { get; private set; }
        public VocabularyKey DataToken { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey ExportedRecordCount { get; private set; }
        public VocabularyKey ExportStatus { get; private set; }
        public VocabularyKey LinkedEntityData { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PagingData { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}