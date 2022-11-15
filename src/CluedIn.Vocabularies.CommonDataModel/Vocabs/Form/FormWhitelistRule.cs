using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormWhitelistRuleVocabulary : SimpleVocabulary
    {
        public FormWhitelistRuleVocabulary()
        {
            VocabularyName = "Form Whitelist Rule";
            KeyPrefix = "commonDataModel.formwhitelistrule";
            KeySeparator = ".";
            Grouping = "/FormWhitelistRule";

            AddGroup("FormWhitelistRule Details", group =>
            {
                MarketingformwhitelistruleId = group.Add(new VocabularyKey(nameof(MarketingformwhitelistruleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MarketingformwhitelistruleId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}