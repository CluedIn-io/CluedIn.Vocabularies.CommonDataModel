using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLanguageTextEntityVocabulary : SimpleVocabulary
    {
        public RetailLanguageTextEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLanguageTextEntity";
            KeyPrefix = "commonDataModel.retaillanguagetextentity";
            KeySeparator = ".";
            Grouping = "/RetailLanguageTextEntity";

            AddGroup("Common Data Model RetailLanguageTextEntity Details", group =>
            {
                DateCreated = group.Add(new VocabularyKey(nameof(DateCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateUpdated = group.Add(new VocabularyKey(nameof(DateUpdated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorText = group.Add(new VocabularyKey(nameof(ErrorText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstInVersion = group.Add(new VocabularyKey(nameof(FirstInVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModuleId = group.Add(new VocabularyKey(nameof(ModuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextId = group.Add(new VocabularyKey(nameof(TextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DateCreated { get; private set; }
        public VocabularyKey DateUpdated { get; private set; }
        public VocabularyKey ErrorText { get; private set; }
        public VocabularyKey FirstInVersion { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ModuleId { get; private set; }
        public VocabularyKey Text { get; private set; }
        public VocabularyKey TextId { get; private set; }


    }
}