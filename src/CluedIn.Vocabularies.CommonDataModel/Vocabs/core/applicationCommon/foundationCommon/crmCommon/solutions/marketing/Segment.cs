using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class SegmentVocabulary : SimpleVocabulary
    {
        public SegmentVocabulary()
        {
            VocabularyName = "Segment";
            KeyPrefix = "commonDataModel.segment.marketing";
            KeySeparator = ".";
            Grouping = "/Segment";

            AddGroup("Segment Details for Marketing", group =>
            {
			    SegmentId = group.Add(new VocabularyKey(nameof(SegmentId), "Segment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Segmentname = group.Add(new VocabularyKey(nameof(Segmentname), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivationStatus = group.Add(new VocabularyKey(nameof(ActivationStatus), "Activation status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FilterQuery = group.Add(new VocabularyKey(nameof(FilterQuery), "Filter query", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MemberIDs = group.Add(new VocabularyKey(nameof(MemberIDs), "Member IDs", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProvisioningState = group.Add(new VocabularyKey(nameof(ProvisioningState), "Provisioning state", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QueryDefinition = group.Add(new VocabularyKey(nameof(QueryDefinition), "Query definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SegmentType = group.Add(new VocabularyKey(nameof(SegmentType), "Segment type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SegmentId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Segmentname { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ActivationStatus { get; private set; }
        public VocabularyKey FilterQuery { get; private set; }
        public VocabularyKey MemberIDs { get; private set; }
        public VocabularyKey ProvisioningState { get; private set; }
        public VocabularyKey QueryDefinition { get; private set; }
        public VocabularyKey SegmentType { get; private set; }
    }
}