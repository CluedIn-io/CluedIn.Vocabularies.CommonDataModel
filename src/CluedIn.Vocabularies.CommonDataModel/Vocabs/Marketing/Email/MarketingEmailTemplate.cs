using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTemplateVocabulary : SimpleVocabulary
    {
        public MarketingEmailTemplateVocabulary()
        {
            VocabularyName = "Marketing Email Template";
            KeyPrefix = "commonDataModel.marketingemailtemplate";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTemplate";

            AddGroup("MarketingEmailTemplate Details", group =>
            {
                FormToSave = group.Add(new VocabularyKey(nameof(FormToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceEmailID = group.Add(new VocabularyKey(nameof(SourceEmailID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DesignerHTML = group.Add(new VocabularyKey(nameof(DesignerHTML), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailTemplateMarketTypeOptionset = group.Add(new VocabularyKey(nameof(EmailTemplateMarketTypeOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailTemplateOptimizedforOptionset = group.Add(new VocabularyKey(nameof(EmailTemplateOptimizedforOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailTemplatePurposeOptionset = group.Add(new VocabularyKey(nameof(EmailTemplatePurposeOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailTemplateVisualStyleOptionset = group.Add(new VocabularyKey(nameof(EmailTemplateVisualStyleOptionset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailBody = group.Add(new VocabularyKey(nameof(EmailBody), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingEmailTemplateId = group.Add(new VocabularyKey(nameof(MarketingEmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingProvided = group.Add(new VocabularyKey(nameof(MarketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailContenttype = group.Add(new VocabularyKey(nameof(EmailContenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Messagedesignation = group.Add(new VocabularyKey(nameof(Messagedesignation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Subject = group.Add(new VocabularyKey(nameof(Subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Textpart = group.Add(new VocabularyKey(nameof(Textpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticallyGenerateTextPart = group.Add(new VocabularyKey(nameof(AutomaticallyGenerateTextPart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tag = group.Add(new VocabularyKey(nameof(Tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Label = group.Add(new VocabularyKey(nameof(Label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromEmail = group.Add(new VocabularyKey(nameof(FromEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromName = group.Add(new VocabularyKey(nameof(FromName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                To = group.Add(new VocabularyKey(nameof(To), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyToEmail = group.Add(new VocabularyKey(nameof(ReplyToEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormToSave { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey SourceEmailID { get; private set; }
        public VocabularyKey DesignerHTML { get; private set; }
        public VocabularyKey EmailTemplateMarketTypeOptionset { get; private set; }
        public VocabularyKey EmailTemplateOptimizedforOptionset { get; private set; }
        public VocabularyKey EmailTemplatePurposeOptionset { get; private set; }
        public VocabularyKey EmailTemplateVisualStyleOptionset { get; private set; }
        public VocabularyKey EmailBody { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey MarketingEmailTemplateId { get; private set; }
        public VocabularyKey MarketingProvided { get; private set; }
        public VocabularyKey EmailContenttype { get; private set; }
        public VocabularyKey Messagedesignation { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey Textpart { get; private set; }
        public VocabularyKey AutomaticallyGenerateTextPart { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Tag { get; private set; }
        public VocabularyKey Label { get; private set; }
        public VocabularyKey FromEmail { get; private set; }
        public VocabularyKey FromName { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey ReplyToEmail { get; private set; }
    }
}