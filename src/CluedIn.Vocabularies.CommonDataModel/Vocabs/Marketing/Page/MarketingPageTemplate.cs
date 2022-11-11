using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingPageTemplateVocabulary : SimpleVocabulary
    {
        public MarketingPageTemplateVocabulary()
        {
            VocabularyName = "Common Data Model MarketingPageTemplate";
            KeyPrefix = "commonDataModel.marketingpagetemplate";
            KeySeparator = ".";
            Grouping = "/MarketingPageTemplate";

            AddGroup("Common Data Model MarketingPageTemplate Details", group =>
            {
                formToSave = group.Add(new VocabularyKey(nameof(formToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                content = group.Add(new VocabularyKey(nameof(content), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                contentType = group.Add(new VocabularyKey(nameof(contentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formPageMapping = group.Add(new VocabularyKey(nameof(formPageMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                language = group.Add(new VocabularyKey(nameof(language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingPageTemplateId = group.Add(new VocabularyKey(nameof(marketingPageTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingProvided = group.Add(new VocabularyKey(nameof(marketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketType = group.Add(new VocabularyKey(nameof(marketType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                optimizedFor = group.Add(new VocabularyKey(nameof(optimizedFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                purpose = group.Add(new VocabularyKey(nameof(purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                visualStyle = group.Add(new VocabularyKey(nameof(visualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tag = group.Add(new VocabularyKey(nameof(tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                label = group.Add(new VocabularyKey(nameof(label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey formToSave { get; private set; }
        public VocabularyKey entityImage { get; private set; }
        public VocabularyKey content { get; private set; }
        public VocabularyKey contentType { get; private set; }
        public VocabularyKey formPageMapping { get; private set; }
        public VocabularyKey language { get; private set; }
        public VocabularyKey marketingPageTemplateId { get; private set; }
        public VocabularyKey marketingProvided { get; private set; }
        public VocabularyKey marketType { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey optimizedFor { get; private set; }
        public VocabularyKey purpose { get; private set; }
        public VocabularyKey type { get; private set; }
        public VocabularyKey visualStyle { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey tag { get; private set; }
        public VocabularyKey label { get; private set; }


    }
}