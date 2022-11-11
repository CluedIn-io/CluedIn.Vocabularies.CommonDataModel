using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InflationAdjInpcRateEntityVocabulary : SimpleVocabulary
    {
        public InflationAdjInpcRateEntityVocabulary()
        {
            VocabularyName = "Common Data Model InflationAdjInpcRateEntity";
            KeyPrefix = "commonDataModel.inflationadjinpcrateentity";
            KeySeparator = ".";
            Grouping = "/InflationAdjInpcRateEntity";

            AddGroup("Common Data Model InflationAdjInpcRateEntity Details", group =>
            {
                InflationRate = group.Add(new VocabularyKey(nameof(InflationRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Month = group.Add(new VocabularyKey(nameof(Month), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Year = group.Add(new VocabularyKey(nameof(Year), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InflationRate { get; private set; }
        public VocabularyKey Month { get; private set; }
        public VocabularyKey Year { get; private set; }


    }
}