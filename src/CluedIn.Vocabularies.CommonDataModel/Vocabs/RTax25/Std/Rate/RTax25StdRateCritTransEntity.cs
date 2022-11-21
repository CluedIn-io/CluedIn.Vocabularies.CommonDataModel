using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25StdRateCritTransEntityVocabulary : SimpleVocabulary
    {
        public RTax25StdRateCritTransEntityVocabulary()
        {
            VocabularyName = "R Tax 25 Std Rate Crit Trans Entity";
            KeyPrefix = "commonDataModel.rtax25stdratecrittransentity";
            KeySeparator = ".";
            Grouping = "/RTax25StdRateCritTransEntity";

            AddGroup("RTax25StdRateCritTransEntity Details", group =>
            {
                ForAmount = group.Add(new VocabularyKey(nameof(ForAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateTransLineId = group.Add(new VocabularyKey(nameof(RateTransLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ForAmount { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey RateTransLineId { get; private set; }
    }
}