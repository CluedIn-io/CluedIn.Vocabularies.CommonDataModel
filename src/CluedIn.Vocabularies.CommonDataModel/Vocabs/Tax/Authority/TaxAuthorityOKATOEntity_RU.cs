using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxAuthorityOKATOEntity_RUVocabulary : SimpleVocabulary
    {
        public TaxAuthorityOKATOEntity_RUVocabulary()
        {
            VocabularyName = "Tax Authority OKATO Entity _RU";
            KeyPrefix = "commonDataModel.taxauthorityokatoentity_ru";
            KeySeparator = ".";
            Grouping = "/TaxAuthorityOKATOEntity_RU";

            AddGroup("TaxAuthorityOKATOEntity_RU Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OKATO = group.Add(new VocabularyKey(nameof(OKATO), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAuthority = group.Add(new VocabularyKey(nameof(TaxAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OKATO { get; private set; }
        public VocabularyKey TaxAuthority { get; private set; }
    }
}