using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxExciseTariffCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxExciseTariffCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxExciseTariffCodeEntity";
            KeyPrefix = "commonDataModel.taxexcisetariffcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxExciseTariffCodeEntity";

            AddGroup("Common Data Model TaxExciseTariffCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TariffCode = group.Add(new VocabularyKey(nameof(TariffCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey TariffCode { get; private set; }


    }
}