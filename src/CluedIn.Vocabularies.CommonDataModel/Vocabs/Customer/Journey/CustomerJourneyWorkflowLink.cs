using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyWorkflowLinkVocabulary : SimpleVocabulary
    {
        public CustomerJourneyWorkflowLinkVocabulary()
        {
            VocabularyName = "Customer Journey Workflow Link";
            KeyPrefix = "commonDataModel.customerjourneyworkflowlink";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyWorkflowLink";

            AddGroup("CustomerJourneyWorkflowLink Details", group =>
            {
                CustomerJourneyID = group.Add(new VocabularyKey(nameof(CustomerJourneyID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerJourneyWorkflowLinkId = group.Add(new VocabularyKey(nameof(CustomerJourneyWorkflowLinkId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Workflowid = group.Add(new VocabularyKey(nameof(Workflowid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerJourneyID { get; private set; }
        public VocabularyKey CustomerJourneyWorkflowLinkId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Workflowid { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}