using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgWorkOrderDocumentGroupEntityVocabulary : SimpleVocabulary
    {
        public JmgWorkOrderDocumentGroupEntityVocabulary()
        {
            VocabularyName = "JmgWorkOrderDocumentGroupEntity";
            KeyPrefix = "commonDataModel.jmgworkorderdocumentgroupentity";
            KeySeparator = ".";
            Grouping = "/JmgWorkOrderDocumentGroupEntity";

            AddGroup("JmgWorkOrderDocumentGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}