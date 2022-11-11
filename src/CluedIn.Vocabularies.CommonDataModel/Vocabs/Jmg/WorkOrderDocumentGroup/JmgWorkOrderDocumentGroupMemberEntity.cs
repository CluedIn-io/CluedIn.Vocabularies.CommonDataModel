using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgWorkOrderDocumentGroupMemberEntityVocabulary : SimpleVocabulary
    {
        public JmgWorkOrderDocumentGroupMemberEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgWorkOrderDocumentGroupMemberEntity";
            KeyPrefix = "commonDataModel.jmgworkorderdocumentgroupmemberentity";
            KeySeparator = ".";
            Grouping = "/JmgWorkOrderDocumentGroupMemberEntity";

            AddGroup("Common Data Model JmgWorkOrderDocumentGroupMemberEntity Details", group =>
            {
                WorkOrderDocumentGroupRecId = group.Add(new VocabularyKey(nameof(WorkOrderDocumentGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkOrderDocumentGroupId = group.Add(new VocabularyKey(nameof(WorkOrderDocumentGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotifiedWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(NotifiedWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WorkOrderDocumentGroupRecId { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey WorkOrderDocumentGroupId { get; private set; }
        public VocabularyKey NotifiedWorkerPersonnelNumber { get; private set; }


    }
}