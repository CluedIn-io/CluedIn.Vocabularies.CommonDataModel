using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailVocabulary : SimpleVocabulary
    {
        public MarketingEmailVocabulary()
        {
            VocabularyName = "Common Data Model MarketingEmail";
            KeyPrefix = "commonDataModel.marketingemail";
            KeySeparator = ".";
            Grouping = "/MarketingEmail";

            AddGroup("Common Data Model MarketingEmail Details", group =>
            {
                formToSave = group.Add(new VocabularyKey(nameof(formToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                automaticallygeneratetextpart = group.Add(new VocabularyKey(nameof(automaticallygeneratetextpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                clickMap = group.Add(new VocabularyKey(nameof(clickMap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                designerHTML = group.Add(new VocabularyKey(nameof(designerHTML), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailBody = group.Add(new VocabularyKey(nameof(emailBody), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fromEmail = group.Add(new VocabularyKey(nameof(fromEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fromName = group.Add(new VocabularyKey(nameof(fromName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                insightsPlaceholder = group.Add(new VocabularyKey(nameof(insightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isTemplateGalleryNeeded = group.Add(new VocabularyKey(nameof(isTemplateGalleryNeeded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingEmailId = group.Add(new VocabularyKey(nameof(marketingEmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                messagedesignation = group.Add(new VocabularyKey(nameof(messagedesignation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailContenttype = group.Add(new VocabularyKey(nameof(emailContenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailContentlanguage = group.Add(new VocabularyKey(nameof(emailContentlanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                previewText = group.Add(new VocabularyKey(nameof(previewText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                replyToEmail = group.Add(new VocabularyKey(nameof(replyToEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                subject = group.Add(new VocabularyKey(nameof(subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                contentsettingscompanyaddress = group.Add(new VocabularyKey(nameof(contentsettingscompanyaddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                testConfiguration = group.Add(new VocabularyKey(nameof(testConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                textpart = group.Add(new VocabularyKey(nameof(textpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                to = group.Add(new VocabularyKey(nameof(to), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UICEntityID = group.Add(new VocabularyKey(nameof(UICEntityID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey formToSave { get; private set; }
        public VocabularyKey automaticallygeneratetextpart { get; private set; }
        public VocabularyKey clickMap { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey designerHTML { get; private set; }
        public VocabularyKey emailBody { get; private set; }
        public VocabularyKey fromEmail { get; private set; }
        public VocabularyKey fromName { get; private set; }
        public VocabularyKey insightsPlaceholder { get; private set; }
        public VocabularyKey isTemplateGalleryNeeded { get; private set; }
        public VocabularyKey marketingEmailId { get; private set; }
        public VocabularyKey messagedesignation { get; private set; }
        public VocabularyKey emailContenttype { get; private set; }
        public VocabularyKey emailContentlanguage { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey previewText { get; private set; }
        public VocabularyKey replyToEmail { get; private set; }
        public VocabularyKey subject { get; private set; }
        public VocabularyKey contentsettingscompanyaddress { get; private set; }
        public VocabularyKey testConfiguration { get; private set; }
        public VocabularyKey textpart { get; private set; }
        public VocabularyKey to { get; private set; }
        public VocabularyKey UICEntityID { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey entityImage { get; private set; }


    }
}