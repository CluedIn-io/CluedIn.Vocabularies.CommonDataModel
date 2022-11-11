using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DMFDefinitionGroupTemplateLineEntityVocabulary : SimpleVocabulary
    {
        public DMFDefinitionGroupTemplateLineEntityVocabulary()
        {
            VocabularyName = "DMFDefinitionGroupTemplateLineEntity";
            KeyPrefix = "commonDataModel.dmfdefinitiongrouptemplatelineentity";
            KeySeparator = ".";
            Grouping = "/DMFDefinitionGroupTemplateLineEntity";

            AddGroup("DMFDefinitionGroupTemplateLineEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entity = group.Add(new VocabularyKey(nameof(Entity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidationStatus = group.Add(new VocabularyKey(nameof(ValidationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionUnit = group.Add(new VocabularyKey(nameof(ExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LevelInExecutionUnit = group.Add(new VocabularyKey(nameof(LevelInExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailLevelOnError = group.Add(new VocabularyKey(nameof(FailLevelOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FailExecutionUnitOnError = group.Add(new VocabularyKey(nameof(FailExecutionUnitOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SysModule = group.Add(new VocabularyKey(nameof(SysModule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tags = group.Add(new VocabularyKey(nameof(Tags), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityCategory = group.Add(new VocabularyKey(nameof(EntityCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey Entity { get; private set; }
        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey ValidationStatus { get; private set; }
        public VocabularyKey ExecutionUnit { get; private set; }
        public VocabularyKey LevelInExecutionUnit { get; private set; }
        public VocabularyKey FailLevelOnError { get; private set; }
        public VocabularyKey FailExecutionUnitOnError { get; private set; }
        public VocabularyKey SysModule { get; private set; }
        public VocabularyKey Tags { get; private set; }
        public VocabularyKey EntityCategory { get; private set; }


    }
}