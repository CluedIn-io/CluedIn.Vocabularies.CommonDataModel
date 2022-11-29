using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CustomerInsights
{
    public class SegmentMembershipVocabulary : SimpleVocabulary
    {
        public SegmentMembershipVocabulary()
        {
            VocabularyName = "Segment Membership";
            KeyPrefix = "commonDataModel.segmentmembership.customerinsights";
            KeySeparator = ".";
            Grouping = "/SegmentMembership";

            AddGroup("SegmentMembership Details for CustomerInsights", group =>
            {
			    LastEvaluationDate = group.Add(new VocabularyKey(nameof(LastEvaluationDate), "Last Evaluation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SegmentMembershipId = group.Add(new VocabularyKey(nameof(SegmentMembershipId), "Segment Membership", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LastEvaluationDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SegmentMembershipId { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}