using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingPageTemplateVocabulary : SimpleVocabulary
    {
        public MarketingPageTemplateVocabulary()
        {
            VocabularyName = "Marketing Page Template";
            KeyPrefix = "commonDataModel.marketingpagetemplate";
            KeySeparator = ".";
            Grouping = "/MarketingPageTemplate";

            AddGroup("MarketingPageTemplate Details", group =>
            {
                FormToSave = group.Add(new VocabularyKey(nameof(FormToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Content = group.Add(new VocabularyKey(nameof(Content), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContentType = group.Add(new VocabularyKey(nameof(ContentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormPageMapping = group.Add(new VocabularyKey(nameof(FormPageMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingPageTemplateId = group.Add(new VocabularyKey(nameof(MarketingPageTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingProvided = group.Add(new VocabularyKey(nameof(MarketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketType = group.Add(new VocabularyKey(nameof(MarketType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OptimizedFor = group.Add(new VocabularyKey(nameof(OptimizedFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisualStyle = group.Add(new VocabularyKey(nameof(VisualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tag = group.Add(new VocabularyKey(nameof(Tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Label = group.Add(new VocabularyKey(nameof(Label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormToSave { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey ContentType { get; private set; }
        public VocabularyKey FormPageMapping { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey MarketingPageTemplateId { get; private set; }
        public VocabularyKey MarketingProvided { get; private set; }
        public VocabularyKey MarketType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OptimizedFor { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Tag { get; private set; }
        public VocabularyKey Label { get; private set; }
    }
}