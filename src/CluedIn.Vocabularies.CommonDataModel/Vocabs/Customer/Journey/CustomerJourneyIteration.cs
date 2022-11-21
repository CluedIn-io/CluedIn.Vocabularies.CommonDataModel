using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyIterationVocabulary : SimpleVocabulary
    {
        public CustomerJourneyIterationVocabulary()
        {
            VocabularyName = "Customer Journey Iteration";
            KeyPrefix = "commonDataModel.customerjourneyiteration";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyIteration";

            AddGroup("CustomerJourneyIteration Details", group =>
            {
                CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerJourneyIterationId = group.Add(new VocabularyKey(nameof(CustomerJourneyIterationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DesignerState = group.Add(new VocabularyKey(nameof(DesignerState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IterationNumber = group.Add(new VocabularyKey(nameof(IterationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowDefinition = group.Add(new VocabularyKey(nameof(WorkflowDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey CustomerJourneyIterationId { get; private set; }
        public VocabularyKey DesignerState { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey IterationNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey WorkflowDefinition { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}