using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementExecutionJobDetailEntityVocabulary : SimpleVocabulary
    {
        public DataManagementExecutionJobDetailEntityVocabulary()
        {
            VocabularyName = "DataManagementExecutionJobDetailEntity";
            KeyPrefix = "commonDataModel.datamanagementexecutionjobdetailentity";
            KeySeparator = ".";
            Grouping = "/DataManagementExecutionJobDetailEntity";

            AddGroup("DataManagementExecutionJobDetailEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobId = group.Add(new VocabularyKey(nameof(JobId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StagingEndDateTime = group.Add(new VocabularyKey(nameof(StagingEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcelSheetName = group.Add(new VocabularyKey(nameof(ExcelSheetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecuteTargetStep = group.Add(new VocabularyKey(nameof(ExecuteTargetStep), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstRowIsHeader = group.Add(new VocabularyKey(nameof(FirstRowIsHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FilePath = group.Add(new VocabularyKey(nameof(FilePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IgnoreError = group.Add(new VocabularyKey(nameof(IgnoreError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StagingRecordsToBeProcessedCount = group.Add(new VocabularyKey(nameof(StagingRecordsToBeProcessedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParallelTaskCount = group.Add(new VocabularyKey(nameof(ParallelTaskCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StagingRecordsCreatedCount = group.Add(new VocabularyKey(nameof(StagingRecordsCreatedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetRecordsCreatedCount = group.Add(new VocabularyKey(nameof(TargetRecordsCreatedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetRecordsUpdatedCount = group.Add(new VocabularyKey(nameof(TargetRecordsUpdatedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateErrorFile = group.Add(new VocabularyKey(nameof(CreateErrorFile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunBusinessLogic = group.Add(new VocabularyKey(nameof(RunBusinessLogic), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunBusinessValidation = group.Add(new VocabularyKey(nameof(RunBusinessValidation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfRowsToSkip = group.Add(new VocabularyKey(nameof(NumberOfRowsToSkip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceFormat = group.Add(new VocabularyKey(nameof(SourceFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StagingStatus = group.Add(new VocabularyKey(nameof(StagingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StagingStartDateTime = group.Add(new VocabularyKey(nameof(StagingStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetStatus = group.Add(new VocabularyKey(nameof(TargetStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetEndDateTime = group.Add(new VocabularyKey(nameof(TargetEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetStartDateTime = group.Add(new VocabularyKey(nameof(TargetStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionUnit = group.Add(new VocabularyKey(nameof(ExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LevelInExecutionUnit = group.Add(new VocabularyKey(nameof(LevelInExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceInLevel = group.Add(new VocabularyKey(nameof(SequenceInLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailExecutionUnitOnError = group.Add(new VocabularyKey(nameof(FailExecutionUnitOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailLevelOnError = group.Add(new VocabularyKey(nameof(FailLevelOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey JobId { get; private set; }
        public VocabularyKey StagingEndDateTime { get; private set; }
        public VocabularyKey ExcelSheetName { get; private set; }
        public VocabularyKey ExecuteTargetStep { get; private set; }
        public VocabularyKey FirstRowIsHeader { get; private set; }
        public VocabularyKey FilePath { get; private set; }
        public VocabularyKey IgnoreError { get; private set; }
        public VocabularyKey StagingRecordsToBeProcessedCount { get; private set; }
        public VocabularyKey ParallelTaskCount { get; private set; }
        public VocabularyKey StagingRecordsCreatedCount { get; private set; }
        public VocabularyKey TargetRecordsCreatedCount { get; private set; }
        public VocabularyKey TargetRecordsUpdatedCount { get; private set; }
        public VocabularyKey CreateErrorFile { get; private set; }
        public VocabularyKey RunBusinessLogic { get; private set; }
        public VocabularyKey RunBusinessValidation { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey NumberOfRowsToSkip { get; private set; }
        public VocabularyKey SourceFormat { get; private set; }
        public VocabularyKey StagingStatus { get; private set; }
        public VocabularyKey StagingStartDateTime { get; private set; }
        public VocabularyKey TargetStatus { get; private set; }
        public VocabularyKey TargetEndDateTime { get; private set; }
        public VocabularyKey TargetStartDateTime { get; private set; }
        public VocabularyKey ExecutionUnit { get; private set; }
        public VocabularyKey LevelInExecutionUnit { get; private set; }
        public VocabularyKey SequenceInLevel { get; private set; }
        public VocabularyKey FailExecutionUnitOnError { get; private set; }
        public VocabularyKey FailLevelOnError { get; private set; }


    }
}