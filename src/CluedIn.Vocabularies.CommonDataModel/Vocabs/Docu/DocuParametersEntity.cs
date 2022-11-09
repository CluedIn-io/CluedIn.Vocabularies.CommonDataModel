using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocuParametersEntityVocabulary : SimpleVocabulary
    {
        public DocuParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model DocuParametersEntity";
            KeyPrefix = "commonDataModel.docuparametersentity";
            KeySeparator = ".";
            Grouping = "/DocuParametersEntity";

            AddGroup("Common Data Model DocuParametersEntity Details", group =>
            {
                ActiveTable = group.Add(new VocabularyKey(nameof(ActiveTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaxFileSizeInFileSystem = group.Add(new VocabularyKey(nameof(MaxFileSizeInFileSystem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubmitToWorkflow = group.Add(new VocabularyKey(nameof(SubmitToWorkflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WebAppsServerURL = group.Add(new VocabularyKey(nameof(WebAppsServerURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSharePointServer = group.Add(new VocabularyKey(nameof(DefaultSharePointServer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ActiveTable { get; private set; }
public VocabularyKey Key { get; private set; }
public VocabularyKey MaxFileSizeInFileSystem { get; private set; }
public VocabularyKey SubmitToWorkflow { get; private set; }
public VocabularyKey WebAppsServerURL { get; private set; }
public VocabularyKey DefaultSharePointServer { get; private set; }


    }
}