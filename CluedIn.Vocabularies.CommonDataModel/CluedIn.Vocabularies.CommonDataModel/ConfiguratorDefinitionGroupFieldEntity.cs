using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorDefinitionGroupFieldEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorDefinitionGroupFieldEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConfiguratorDefinitionGroupFieldEntity";
            KeyPrefix = "commonDataModel.configuratordefinitiongroupfieldentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorDefinitionGroupFieldEntity";

            AddGroup("Common Data Model ConfiguratorDefinitionGroupFieldEntity Details", group =>
            {
                DefinitionGroupId = group.Add(new VocabularyKey(nameof(DefinitionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DataSourceNumber = group.Add(new VocabularyKey(nameof(DataSourceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FieldGroup = group.Add(new VocabularyKey(nameof(FieldGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortOrder = group.Add(new VocabularyKey(nameof(SortOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DefinitionGroupId { get; private set; }
public VocabularyKey DataSourceNumber { get; private set; }
public VocabularyKey FieldGroup { get; private set; }
public VocabularyKey FieldName { get; private set; }
public VocabularyKey SortOrder { get; private set; }
public VocabularyKey TableName { get; private set; }


    }
}