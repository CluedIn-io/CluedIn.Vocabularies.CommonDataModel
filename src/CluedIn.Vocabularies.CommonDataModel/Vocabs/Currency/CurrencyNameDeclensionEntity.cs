using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CurrencyNameDeclensionEntityVocabulary : SimpleVocabulary
    {
        public CurrencyNameDeclensionEntityVocabulary()
        {
            VocabularyName = "Currency Name Declension Entity";
            KeyPrefix = "commonDataModel.currencynamedeclensionentity";
            KeySeparator = ".";
            Grouping = "/CurrencyNameDeclensionEntity";

            AddGroup("CurrencyNameDeclensionEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyPluralNominative = group.Add(new VocabularyKey(nameof(CurrencyPluralNominative), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyPluralNominativePenny = group.Add(new VocabularyKey(nameof(CurrencyPluralNominativePenny), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsertAndBeforePenny = group.Add(new VocabularyKey(nameof(InsertAndBeforePenny), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameForFive = group.Add(new VocabularyKey(nameof(NameForFive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameForFivePenny = group.Add(new VocabularyKey(nameof(NameForFivePenny), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameForOne = group.Add(new VocabularyKey(nameof(NameForOne), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameForOnePenny = group.Add(new VocabularyKey(nameof(NameForOnePenny), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameForThree = group.Add(new VocabularyKey(nameof(NameForThree), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameForThreePenny = group.Add(new VocabularyKey(nameof(NameForThreePenny), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShortName = group.Add(new VocabularyKey(nameof(ShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShortNamePenny = group.Add(new VocabularyKey(nameof(ShortNamePenny), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gender = group.Add(new VocabularyKey(nameof(Gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CurrencyPluralNominative { get; private set; }
        public VocabularyKey CurrencyPluralNominativePenny { get; private set; }
        public VocabularyKey InsertAndBeforePenny { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey NameForFive { get; private set; }
        public VocabularyKey NameForFivePenny { get; private set; }
        public VocabularyKey NameForOne { get; private set; }
        public VocabularyKey NameForOnePenny { get; private set; }
        public VocabularyKey NameForThree { get; private set; }
        public VocabularyKey NameForThreePenny { get; private set; }
        public VocabularyKey ShortName { get; private set; }
        public VocabularyKey ShortNamePenny { get; private set; }
        public VocabularyKey Gender { get; private set; }
    }
}