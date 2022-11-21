using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirNameSequenceEntityVocabulary : SimpleVocabulary
    {
        public DirNameSequenceEntityVocabulary()
        {
            VocabularyName = "Dir Name Sequence Entity";
            KeyPrefix = "commonDataModel.dirnamesequenceentity";
            KeySeparator = ".";
            Grouping = "/DirNameSequenceEntity";

            AddGroup("DirNameSequenceEntity Details", group =>
            {
                NameSequence = group.Add(new VocabularyKey(nameof(NameSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstPosition = group.Add(new VocabularyKey(nameof(FirstPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Separator1 = group.Add(new VocabularyKey(nameof(Separator1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Separator1Spaces = group.Add(new VocabularyKey(nameof(Separator1Spaces), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondPosition = group.Add(new VocabularyKey(nameof(SecondPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Separator2 = group.Add(new VocabularyKey(nameof(Separator2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Separator2Spaces = group.Add(new VocabularyKey(nameof(Separator2Spaces), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPosition = group.Add(new VocabularyKey(nameof(ThirdPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Separator3 = group.Add(new VocabularyKey(nameof(Separator3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Separator3Spaces = group.Add(new VocabularyKey(nameof(Separator3Spaces), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPosition = group.Add(new VocabularyKey(nameof(LastPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey NameSequence { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey FirstPosition { get; private set; }
        public VocabularyKey Separator1 { get; private set; }
        public VocabularyKey Separator1Spaces { get; private set; }
        public VocabularyKey SecondPosition { get; private set; }
        public VocabularyKey Separator2 { get; private set; }
        public VocabularyKey Separator2Spaces { get; private set; }
        public VocabularyKey ThirdPosition { get; private set; }
        public VocabularyKey Separator3 { get; private set; }
        public VocabularyKey Separator3Spaces { get; private set; }
        public VocabularyKey LastPosition { get; private set; }
    }
}