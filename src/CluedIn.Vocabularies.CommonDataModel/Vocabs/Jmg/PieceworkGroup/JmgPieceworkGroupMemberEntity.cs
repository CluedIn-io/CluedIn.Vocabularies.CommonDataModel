using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgPieceworkGroupMemberEntityVocabulary : SimpleVocabulary
    {
        public JmgPieceworkGroupMemberEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgPieceworkGroupMemberEntity";
            KeyPrefix = "commonDataModel.jmgpieceworkgroupmemberentity";
            KeySeparator = ".";
            Grouping = "/JmgPieceworkGroupMemberEntity";

            AddGroup("Common Data Model JmgPieceworkGroupMemberEntity Details", group =>
            {
                PieceworkGroupId = group.Add(new VocabularyKey(nameof(PieceworkGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PieceworkGroupWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(PieceworkGroupWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PieceworkGroupId { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PieceworkGroupWorkerPersonnelNumber { get; private set; }


    }
}