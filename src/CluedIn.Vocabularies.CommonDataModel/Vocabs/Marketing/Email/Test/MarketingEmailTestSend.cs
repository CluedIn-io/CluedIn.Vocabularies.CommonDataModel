using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTestSendVocabulary : SimpleVocabulary
    {
        public MarketingEmailTestSendVocabulary()
        {
            VocabularyName = "MarketingEmailTestSend";
            KeyPrefix = "commonDataModel.marketingemailtestsend";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTestSend";

            AddGroup("MarketingEmailTestSend Details", group =>
            {
                emailBody = group.Add(new VocabularyKey(nameof(emailBody), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailID = group.Add(new VocabularyKey(nameof(emailID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                from = group.Add(new VocabularyKey(nameof(from), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fromExpression = group.Add(new VocabularyKey(nameof(fromExpression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                messagedesignation = group.Add(new VocabularyKey(nameof(messagedesignation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emailContenttype = group.Add(new VocabularyKey(nameof(emailContenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HTMLPart = group.Add(new VocabularyKey(nameof(HTMLPart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                keywords = group.Add(new VocabularyKey(nameof(keywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingEmailTestSendId = group.Add(new VocabularyKey(nameof(marketingEmailTestSendId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingListID = group.Add(new VocabularyKey(nameof(marketingListID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                messageType = group.Add(new VocabularyKey(nameof(messageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                replyToExpression = group.Add(new VocabularyKey(nameof(replyToExpression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                subject = group.Add(new VocabularyKey(nameof(subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                testSendEmailAddress = group.Add(new VocabularyKey(nameof(testSendEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                textpart = group.Add(new VocabularyKey(nameof(textpart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                toExpression = group.Add(new VocabularyKey(nameof(toExpression), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABTestID = group.Add(new VocabularyKey(nameof(ABTestID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ABTestVariantID = group.Add(new VocabularyKey(nameof(ABTestVariantID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey emailBody { get; private set; }
        public VocabularyKey emailID { get; private set; }
        public VocabularyKey from { get; private set; }
        public VocabularyKey fromExpression { get; private set; }
        public VocabularyKey messagedesignation { get; private set; }
        public VocabularyKey emailContenttype { get; private set; }
        public VocabularyKey HTMLPart { get; private set; }
        public VocabularyKey keywords { get; private set; }
        public VocabularyKey marketingEmailTestSendId { get; private set; }
        public VocabularyKey marketingListID { get; private set; }
        public VocabularyKey messageType { get; private set; }
        public VocabularyKey replyToExpression { get; private set; }
        public VocabularyKey subject { get; private set; }
        public VocabularyKey testSendEmailAddress { get; private set; }
        public VocabularyKey textpart { get; private set; }
        public VocabularyKey toExpression { get; private set; }
        public VocabularyKey ABTestID { get; private set; }
        public VocabularyKey ABTestVariantID { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}