using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxExciseTariffCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxExciseTariffCodeEntityVocabulary()
        {
            VocabularyName = "Tax Excise Tariff Code Entity";
            KeyPrefix = "commonDataModel.taxexcisetariffcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxExciseTariffCodeEntity";

            AddGroup("TaxExciseTariffCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TariffCode = group.Add(new VocabularyKey(nameof(TariffCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TariffCode { get; private set; }
    }
}