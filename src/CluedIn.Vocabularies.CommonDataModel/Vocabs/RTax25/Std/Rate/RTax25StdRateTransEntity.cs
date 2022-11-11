using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25StdRateTransEntityVocabulary : SimpleVocabulary
    {
        public RTax25StdRateTransEntityVocabulary()
        {
            VocabularyName = "RTax25StdRateTransEntity";
            KeyPrefix = "commonDataModel.rtax25stdratetransentity";
            KeySeparator = ".";
            Grouping = "/RTax25StdRateTransEntity";

            AddGroup("RTax25StdRateTransEntity Details", group =>
            {
                CriterionType = group.Add(new VocabularyKey(nameof(CriterionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateCode = group.Add(new VocabularyKey(nameof(RateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CriterionType { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey RateCode { get; private set; }
        public VocabularyKey LineId { get; private set; }


    }
}