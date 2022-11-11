using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DenominationEntityVocabulary : SimpleVocabulary
    {
        public DenominationEntityVocabulary()
        {
            VocabularyName = "Common Data Model DenominationEntity";
            KeyPrefix = "commonDataModel.denominationentity";
            KeySeparator = ".";
            Grouping = "/DenominationEntity";

            AddGroup("Common Data Model DenominationEntity Details", group =>
            {
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyName = group.Add(new VocabularyKey(nameof(CurrencyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Currency { get; private set; }
        public VocabularyKey CurrencyName { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}