using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocReturnCodeEntityVocabulary : SimpleVocabulary
    {
        public EFDocReturnCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EFDocReturnCodeEntity";
            KeyPrefix = "commonDataModel.efdocreturncodeentity";
            KeySeparator = ".";
            Grouping = "/EFDocReturnCodeEntity";

            AddGroup("Common Data Model EFDocReturnCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MessageType = group.Add(new VocabularyKey(nameof(MessageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnCode = group.Add(new VocabularyKey(nameof(ReturnCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey MessageType { get; private set; }
public VocabularyKey ReturnCode { get; private set; }
public VocabularyKey FiscalDocumentStatus { get; private set; }


    }
}