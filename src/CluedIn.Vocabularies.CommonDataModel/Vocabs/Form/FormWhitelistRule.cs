using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormWhitelistRuleVocabulary : SimpleVocabulary
    {
        public FormWhitelistRuleVocabulary()
        {
            VocabularyName = "FormWhitelistRule";
            KeyPrefix = "commonDataModel.formwhitelistrule";
            KeySeparator = ".";
            Grouping = "/FormWhitelistRule";

            AddGroup("FormWhitelistRule Details", group =>
            {
                marketingformwhitelistruleId = group.Add(new VocabularyKey(nameof(marketingformwhitelistruleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey marketingformwhitelistruleId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}