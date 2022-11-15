using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MainAccountTranslationEntityVocabulary : SimpleVocabulary
    {
        public MainAccountTranslationEntityVocabulary()
        {
            VocabularyName = "Main Account Translation Entity";
            KeyPrefix = "commonDataModel.mainaccounttranslationentity";
            KeySeparator = ".";
            Grouping = "/MainAccountTranslationEntity";

            AddGroup("MainAccountTranslationEntity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalText = group.Add(new VocabularyKey(nameof(OriginalText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedText = group.Add(new VocabularyKey(nameof(TranslatedText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountRecId = group.Add(new VocabularyKey(nameof(MainAccountRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(ChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey OriginalText { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey TranslatedText { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey MainAccountRecId { get; private set; }
        public VocabularyKey ChartOfAccountsRecId { get; private set; }
    }
}