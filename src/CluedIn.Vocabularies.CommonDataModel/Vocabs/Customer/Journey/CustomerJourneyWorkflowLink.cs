using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyWorkflowLinkVocabulary : SimpleVocabulary
    {
        public CustomerJourneyWorkflowLinkVocabulary()
        {
            VocabularyName = "CustomerJourneyWorkflowLink";
            KeyPrefix = "commonDataModel.customerjourneyworkflowlink";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyWorkflowLink";

            AddGroup("CustomerJourneyWorkflowLink Details", group =>
            {
                customerJourneyID = group.Add(new VocabularyKey(nameof(customerJourneyID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                customerJourneyWorkflowLinkId = group.Add(new VocabularyKey(nameof(customerJourneyWorkflowLinkId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                workflowid = group.Add(new VocabularyKey(nameof(workflowid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey customerJourneyID { get; private set; }
        public VocabularyKey customerJourneyWorkflowLinkId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey workflowid { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}