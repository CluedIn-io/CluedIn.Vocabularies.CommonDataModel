using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NGPCodeEntityVocabulary : SimpleVocabulary
    {
        public NGPCodeEntityVocabulary()
        {
            VocabularyName = "NGP Code Entity";
            KeyPrefix = "commonDataModel.ngpcodeentity";
            KeySeparator = ".";
            Grouping = "/NGPCodeEntity";

            AddGroup("NGPCodeEntity Details", group =>
            {
                NGP = group.Add(new VocabularyKey(nameof(NGP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey NGP { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}