using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTestSendVocabulary : SimpleVocabulary
    {
        public MarketingEmailTestSendVocabulary()
        {
            VocabularyName = "Marketing Email Test Send";
            KeyPrefix = "commonDataModel.marketingemailtestsend";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTestSend";

            AddGroup("MarketingEmailTestSend Details", group =>
            {
                EmailBody = group.Add(new VocabularyKey(nameof(EmailBody), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailID = group.Add(new VocabularyKey(nameof(EmailID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                From = group.Add(new VocabularyKey(nameof(From), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromExpression = group.Add(new VocabularyKey(nameof(FromExpression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Messagedesignation = group.Add(new VocabularyKey(nameof(Messagedesignation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailContenttype = group.Add(new VocabularyKey(nameof(EmailContenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HTMLPart = group.Add(new VocabularyKey(nameof(HTMLPart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Keywords = group.Add(new VocabularyKey(nameof(Keywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingEmailTestSendId = group.Add(new VocabularyKey(nameof(MarketingEmailTestSendId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingListID = group.Add(new VocabularyKey(nameof(MarketingListID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageType = group.Add(new VocabularyKey(nameof(MessageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplyToExpression = group.Add(new VocabularyKey(nameof(ReplyToExpression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Subject = group.Add(new VocabularyKey(nameof(Subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TestSendEmailAddress = group.Add(new VocabularyKey(nameof(TestSendEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Textpart = group.Add(new VocabularyKey(nameof(Textpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToExpression = group.Add(new VocabularyKey(nameof(ToExpression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABTestID = group.Add(new VocabularyKey(nameof(ABTestID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABTestVariantID = group.Add(new VocabularyKey(nameof(ABTestVariantID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EmailBody { get; private set; }
        public VocabularyKey EmailID { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey FromExpression { get; private set; }
        public VocabularyKey Messagedesignation { get; private set; }
        public VocabularyKey EmailContenttype { get; private set; }
        public VocabularyKey HTMLPart { get; private set; }
        public VocabularyKey Keywords { get; private set; }
        public VocabularyKey MarketingEmailTestSendId { get; private set; }
        public VocabularyKey MarketingListID { get; private set; }
        public VocabularyKey MessageType { get; private set; }
        public VocabularyKey ReplyToExpression { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey TestSendEmailAddress { get; private set; }
        public VocabularyKey Textpart { get; private set; }
        public VocabularyKey ToExpression { get; private set; }
        public VocabularyKey ABTestID { get; private set; }
        public VocabularyKey ABTestVariantID { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}