using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceIntervalEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceIntervalEntityVocabulary()
        {
            VocabularyName = "Common Data Model SMAServiceIntervalEntity";
            KeyPrefix = "commonDataModel.smaserviceintervalentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceIntervalEntity";

            AddGroup("Common Data Model SMAServiceIntervalEntity Details", group =>
            {
                IntervalDescription = group.Add(new VocabularyKey(nameof(IntervalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntervalUnitFactor = group.Add(new VocabularyKey(nameof(IntervalUnitFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntervalId = group.Add(new VocabularyKey(nameof(IntervalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntervalUnit = group.Add(new VocabularyKey(nameof(IntervalUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IntervalDescription { get; private set; }
        public VocabularyKey IntervalUnitFactor { get; private set; }
        public VocabularyKey IntervalId { get; private set; }
        public VocabularyKey IntervalUnit { get; private set; }


    }
}