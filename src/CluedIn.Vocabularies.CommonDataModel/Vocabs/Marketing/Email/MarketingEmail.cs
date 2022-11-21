using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailVocabulary : SimpleVocabulary
    {
        public MarketingEmailVocabulary()
        {
            VocabularyName = "Marketing Email";
            KeyPrefix = "commonDataModel.marketingemail";
            KeySeparator = ".";
            Grouping = "/MarketingEmail";

            AddGroup("MarketingEmail Details", group =>
            {
                FormToSave = group.Add(new VocabularyKey(nameof(FormToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Automaticallygeneratetextpart = group.Add(new VocabularyKey(nameof(Automaticallygeneratetextpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClickMap = group.Add(new VocabularyKey(nameof(ClickMap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DesignerHTML = group.Add(new VocabularyKey(nameof(DesignerHTML), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailBody = group.Add(new VocabularyKey(nameof(EmailBody), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromEmail = group.Add(new VocabularyKey(nameof(FromEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromName = group.Add(new VocabularyKey(nameof(FromName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTemplateGalleryNeeded = group.Add(new VocabularyKey(nameof(IsTemplateGalleryNeeded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingEmailId = group.Add(new VocabularyKey(nameof(MarketingEmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Messagedesignation = group.Add(new VocabularyKey(nameof(Messagedesignation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailContenttype = group.Add(new VocabularyKey(nameof(EmailContenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailContentlanguage = group.Add(new VocabularyKey(nameof(EmailContentlanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreviewText = group.Add(new VocabularyKey(nameof(PreviewText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyToEmail = group.Add(new VocabularyKey(nameof(ReplyToEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Subject = group.Add(new VocabularyKey(nameof(Subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Contentsettingscompanyaddress = group.Add(new VocabularyKey(nameof(Contentsettingscompanyaddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestConfiguration = group.Add(new VocabularyKey(nameof(TestConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Textpart = group.Add(new VocabularyKey(nameof(Textpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                To = group.Add(new VocabularyKey(nameof(To), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UICEntityID = group.Add(new VocabularyKey(nameof(UICEntityID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormToSave { get; private set; }
        public VocabularyKey Automaticallygeneratetextpart { get; private set; }
        public VocabularyKey ClickMap { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DesignerHTML { get; private set; }
        public VocabularyKey EmailBody { get; private set; }
        public VocabularyKey FromEmail { get; private set; }
        public VocabularyKey FromName { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey IsTemplateGalleryNeeded { get; private set; }
        public VocabularyKey MarketingEmailId { get; private set; }
        public VocabularyKey Messagedesignation { get; private set; }
        public VocabularyKey EmailContenttype { get; private set; }
        public VocabularyKey EmailContentlanguage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PreviewText { get; private set; }
        public VocabularyKey ReplyToEmail { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey Contentsettingscompanyaddress { get; private set; }
        public VocabularyKey TestConfiguration { get; private set; }
        public VocabularyKey Textpart { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey UICEntityID { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
    }
}