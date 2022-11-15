using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25StdRateTableEntityVocabulary : SimpleVocabulary
    {
        public RTax25StdRateTableEntityVocabulary()
        {
            VocabularyName = "R Tax 25 Std Rate Table Entity";
            KeyPrefix = "commonDataModel.rtax25stdratetableentity";
            KeySeparator = ".";
            Grouping = "/RTax25StdRateTableEntity";

            AddGroup("RTax25StdRateTableEntity Details", group =>
            {
                CalculationMethod = group.Add(new VocabularyKey(nameof(CalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateCode = group.Add(new VocabularyKey(nameof(RateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CalculationMethod { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RateCode { get; private set; }
    }
}