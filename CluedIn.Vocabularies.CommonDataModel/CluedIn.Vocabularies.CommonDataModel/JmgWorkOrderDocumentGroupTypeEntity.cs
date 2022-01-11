using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgWorkOrderDocumentGroupTypeEntityVocabulary : SimpleVocabulary
    {
        public JmgWorkOrderDocumentGroupTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgWorkOrderDocumentGroupTypeEntity";
            KeyPrefix = "commonDataModel.jmgworkorderdocumentgrouptypeentity";
            KeySeparator = ".";
            Grouping = "/JmgWorkOrderDocumentGroupTypeEntity";

            AddGroup("Common Data Model JmgWorkOrderDocumentGroupTypeEntity Details", group =>
            {
                WorkOrderDocumentGroupRecId = group.Add(new VocabularyKey(nameof(WorkOrderDocumentGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkOrderDocumentGroupId = group.Add(new VocabularyKey(nameof(WorkOrderDocumentGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDocumentReadingRequiredOnce = group.Add(new VocabularyKey(nameof(IsDocumentReadingRequiredOnce), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDocumentReadingRequired = group.Add(new VocabularyKey(nameof(IsDocumentReadingRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WorkOrderDocumentGroupRecId { get; private set; }
public VocabularyKey WorkOrderDocumentGroupId { get; private set; }
public VocabularyKey DocumentAttachmentTypeCode { get; private set; }
public VocabularyKey IsDocumentReadingRequiredOnce { get; private set; }
public VocabularyKey IsDocumentReadingRequired { get; private set; }


    }
}