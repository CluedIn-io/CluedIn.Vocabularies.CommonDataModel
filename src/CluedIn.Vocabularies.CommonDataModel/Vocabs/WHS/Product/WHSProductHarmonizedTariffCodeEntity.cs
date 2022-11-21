using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSProductHarmonizedTariffCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSProductHarmonizedTariffCodeEntityVocabulary()
        {
            VocabularyName = "WHS Product Harmonized Tariff Code Entity";
            KeyPrefix = "commonDataModel.whsproductharmonizedtariffcodeentity";
            KeySeparator = ".";
            Grouping = "/WHSProductHarmonizedTariffCodeEntity";

            AddGroup("WHSProductHarmonizedTariffCodeEntity Details", group =>
            {
                TariffCode = group.Add(new VocabularyKey(nameof(TariffCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TariffName = group.Add(new VocabularyKey(nameof(TariffName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TariffCode { get; private set; }
        public VocabularyKey TariffName { get; private set; }
    }
}