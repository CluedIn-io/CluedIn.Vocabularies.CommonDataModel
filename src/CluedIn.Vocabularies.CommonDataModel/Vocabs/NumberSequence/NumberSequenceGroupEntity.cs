using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NumberSequenceGroupEntityVocabulary : SimpleVocabulary
    {
        public NumberSequenceGroupEntityVocabulary()
        {
            VocabularyName = "Number Sequence Group Entity";
            KeyPrefix = "commonDataModel.numbersequencegroupentity";
            KeySeparator = ".";
            Grouping = "/NumberSequenceGroupEntity";

            AddGroup("NumberSequenceGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey NumberSequenceGroup { get; private set; }
    }
}