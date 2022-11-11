using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25StdSeqEntityVocabulary : SimpleVocabulary
    {
        public RTax25StdSeqEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTax25StdSeqEntity";
            KeyPrefix = "commonDataModel.rtax25stdseqentity";
            KeySeparator = ".";
            Grouping = "/RTax25StdSeqEntity";

            AddGroup("Common Data Model RTax25StdSeqEntity Details", group =>
            {
                ChannelReference = group.Add(new VocabularyKey(nameof(ChannelReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppliedModule = group.Add(new VocabularyKey(nameof(AppliedModule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChannelReference { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AppliedModule { get; private set; }
        public VocabularyKey Sequence { get; private set; }


    }
}