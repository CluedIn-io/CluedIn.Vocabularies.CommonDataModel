using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DMFEntityExecutionParametersEntityVocabulary : SimpleVocabulary
    {
        public DMFEntityExecutionParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model DMFEntityExecutionParametersEntity";
            KeyPrefix = "commonDataModel.dmfentityexecutionparametersentity";
            KeySeparator = ".";
            Grouping = "/DMFEntityExecutionParametersEntity";

            AddGroup("Common Data Model DMFEntityExecutionParametersEntity Details", group =>
            {
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ImportThresholdRecordCount = group.Add(new VocabularyKey(nameof(ImportThresholdRecordCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberOfImportTasks = group.Add(new VocabularyKey(nameof(NumberOfImportTasks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EntityName { get; private set; }
public VocabularyKey ImportThresholdRecordCount { get; private set; }
public VocabularyKey NumberOfImportTasks { get; private set; }


    }
}