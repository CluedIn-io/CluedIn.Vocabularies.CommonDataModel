using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementTemplateDetailEntityVocabulary : SimpleVocabulary
    {
        public DataManagementTemplateDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model DataManagementTemplateDetailEntity";
            KeyPrefix = "commonDataModel.datamanagementtemplatedetailentity";
            KeySeparator = ".";
            Grouping = "/DataManagementTemplateDetailEntity";

            AddGroup("Common Data Model DataManagementTemplateDetailEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntityName = group.Add(new VocabularyKey(nameof(EntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidationStatus = group.Add(new VocabularyKey(nameof(ValidationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExecutionUnit = group.Add(new VocabularyKey(nameof(ExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LevelInExecutionUnit = group.Add(new VocabularyKey(nameof(LevelInExecutionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceInLevel = group.Add(new VocabularyKey(nameof(SequenceInLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FailLevelOnError = group.Add(new VocabularyKey(nameof(FailLevelOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FailExecutionUnitOnError = group.Add(new VocabularyKey(nameof(FailExecutionUnitOnError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TemplateId { get; private set; }
public VocabularyKey EntityName { get; private set; }
public VocabularyKey ValidationStatus { get; private set; }
public VocabularyKey ExecutionUnit { get; private set; }
public VocabularyKey LevelInExecutionUnit { get; private set; }
public VocabularyKey SequenceInLevel { get; private set; }
public VocabularyKey FailLevelOnError { get; private set; }
public VocabularyKey FailExecutionUnitOnError { get; private set; }


    }
}