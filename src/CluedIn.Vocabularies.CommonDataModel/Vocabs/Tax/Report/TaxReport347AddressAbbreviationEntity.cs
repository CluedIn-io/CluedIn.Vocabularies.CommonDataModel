using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReport347AddressAbbreviationEntityVocabulary : SimpleVocabulary
    {
        public TaxReport347AddressAbbreviationEntityVocabulary()
        {
            VocabularyName = "Tax Report 347 Address Abbreviation Entity";
            KeyPrefix = "commonDataModel.taxreport347addressabbreviationentity";
            KeySeparator = ".";
            Grouping = "/TaxReport347AddressAbbreviationEntity";

            AddGroup("TaxReport347AddressAbbreviationEntity Details", group =>
            {
                AddressAbbreviation = group.Add(new VocabularyKey(nameof(AddressAbbreviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AddressAbbreviation { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}