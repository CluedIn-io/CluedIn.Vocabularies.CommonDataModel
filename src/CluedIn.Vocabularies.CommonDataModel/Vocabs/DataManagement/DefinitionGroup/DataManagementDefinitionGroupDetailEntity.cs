using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementDefinitionGroupDetailEntityVocabulary : SimpleVocabulary
    {
        public DataManagementDefinitionGroupDetailEntityVocabulary()
        {
            VocabularyName = "DataManagementDefinitionGroupDetailEntity";
            KeyPrefix = "commonDataModel.datamanagementdefinitiongroupdetailentity";
            KeySeparator = ".";
            Grouping = "/DataManagementDefinitionGroupDetailEntity";

            AddGroup("DataManagementDefinitionGroupDetailEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcelSheetName = group.Add(new VocabularyKey(nameof(ExcelSheetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunBusinessLogic = group.Add(new VocabularyKey(nameof(RunBusinessLogic), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunBusinessValidation = group.Add(new VocabularyKey(nameof(RunBusinessValidation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SampleFilePath = group.Add(new VocabularyKey(nameof(SampleFilePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputFilePath = group.Add(new VocabularyKey(nameof(InputFilePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceFormat = group.Add(new VocabularyKey(nameof(SourceFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationStatus = group.Add(new VocabularyKey(nameof(ValidationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionUnit = group.Add(new VocabularyKey(nameof(ExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LevelInExecutionUnit = group.Add(new VocabularyKey(nameof(LevelInExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceInLevel = group.Add(new VocabularyKey(nameof(SequenceInLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailLevelOnError = group.Add(new VocabularyKey(nameof(FailLevelOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailExecutionUnitOnError = group.Add(new VocabularyKey(nameof(FailExecutionUnitOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Disable = group.Add(new VocabularyKey(nameof(Disable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryData = group.Add(new VocabularyKey(nameof(QueryData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SysModule = group.Add(new VocabularyKey(nameof(SysModule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tags = group.Add(new VocabularyKey(nameof(Tags), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityCategory = group.Add(new VocabularyKey(nameof(EntityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentEntityName = group.Add(new VocabularyKey(nameof(ParentEntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoGenerateMapping = group.Add(new VocabularyKey(nameof(AutoGenerateMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryForODBC = group.Add(new VocabularyKey(nameof(QueryForODBC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunValidateField = group.Add(new VocabularyKey(nameof(RunValidateField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityXMLName = group.Add(new VocabularyKey(nameof(EntityXMLName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransformed = group.Add(new VocabularyKey(nameof(IsTransformed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SampleFilePathOriginal = group.Add(new VocabularyKey(nameof(SampleFilePathOriginal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipStaging = group.Add(new VocabularyKey(nameof(SkipStaging), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackageFilePath = group.Add(new VocabularyKey(nameof(PackageFilePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRefreshType = group.Add(new VocabularyKey(nameof(DefaultRefreshType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefinitionGroupId { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey ExcelSheetName { get; private set; }
        public VocabularyKey RunBusinessLogic { get; private set; }
        public VocabularyKey RunBusinessValidation { get; private set; }
        public VocabularyKey SampleFilePath { get; private set; }
        public VocabularyKey InputFilePath { get; private set; }
        public VocabularyKey SourceFormat { get; private set; }
        public VocabularyKey ValidationStatus { get; private set; }
        public VocabularyKey ExecutionUnit { get; private set; }
        public VocabularyKey LevelInExecutionUnit { get; private set; }
        public VocabularyKey SequenceInLevel { get; private set; }
        public VocabularyKey FailLevelOnError { get; private set; }
        public VocabularyKey FailExecutionUnitOnError { get; private set; }
        public VocabularyKey Disable { get; private set; }
        public VocabularyKey QueryData { get; private set; }
        public VocabularyKey SysModule { get; private set; }
        public VocabularyKey Tags { get; private set; }
        public VocabularyKey EntityCategory { get; private set; }
        public VocabularyKey ParentEntityName { get; private set; }
        public VocabularyKey AutoGenerateMapping { get; private set; }
        public VocabularyKey QueryForODBC { get; private set; }
        public VocabularyKey RunValidateField { get; private set; }
        public VocabularyKey EntityXMLName { get; private set; }
        public VocabularyKey IsTransformed { get; private set; }
        public VocabularyKey SampleFilePathOriginal { get; private set; }
        public VocabularyKey SkipStaging { get; private set; }
        public VocabularyKey PackageFilePath { get; private set; }
        public VocabularyKey DefaultRefreshType { get; private set; }


    }
}