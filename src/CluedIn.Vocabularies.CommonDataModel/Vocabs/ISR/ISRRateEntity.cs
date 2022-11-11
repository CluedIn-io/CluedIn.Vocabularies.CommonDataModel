using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ISRRateEntityVocabulary : SimpleVocabulary
    {
        public ISRRateEntityVocabulary()
        {
            VocabularyName = "ISRRateEntity";
            KeyPrefix = "commonDataModel.isrrateentity";
            KeySeparator = ".";
            Grouping = "/ISRRateEntity";

            AddGroup("ISRRateEntity Details", group =>
            {
                FixedAmount = group.Add(new VocabularyKey(nameof(FixedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Month = group.Add(new VocabularyKey(nameof(Month), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rate = group.Add(new VocabularyKey(nameof(Rate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAmount = group.Add(new VocabularyKey(nameof(MaximumAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Year = group.Add(new VocabularyKey(nameof(Year), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FixedAmount { get; private set; }
        public VocabularyKey Month { get; private set; }
        public VocabularyKey Rate { get; private set; }
        public VocabularyKey MaximumAmount { get; private set; }
        public VocabularyKey Year { get; private set; }


    }
}