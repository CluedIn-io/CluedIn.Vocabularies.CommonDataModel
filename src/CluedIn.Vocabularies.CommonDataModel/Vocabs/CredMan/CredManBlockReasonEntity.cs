using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManBlockReasonEntityVocabulary : SimpleVocabulary
    {
        public CredManBlockReasonEntityVocabulary()
        {
            VocabularyName = "CredManBlockReasonEntity";
            KeyPrefix = "commonDataModel.credmanblockreasonentity";
            KeySeparator = ".";
            Grouping = "/CredManBlockReasonEntity";

            AddGroup("CredManBlockReasonEntity Details", group =>
            {
                Active = group.Add(new VocabularyKey(nameof(Active), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reason = group.Add(new VocabularyKey(nameof(Reason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CredManId = group.Add(new VocabularyKey(nameof(CredManId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Active { get; private set; }
        public VocabularyKey Reason { get; private set; }
        public VocabularyKey RefRecId { get; private set; }
        public VocabularyKey CredManId { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}