using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CustomerInsights
{
    public class SegmentVocabulary : SimpleVocabulary
    {
        public SegmentVocabulary()
        {
            VocabularyName = "Segment";
            KeyPrefix = "commonDataModel.segment.customerinsights";
            KeySeparator = ".";
            Grouping = "/Segment";

            AddGroup("Segment Details for CustomerInsights", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastEvaluationDate = group.Add(new VocabularyKey(nameof(LastEvaluationDate), "Last Evaluation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MemberCount = group.Add(new VocabularyKey(nameof(MemberCount), "Member Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QueryDefinition = group.Add(new VocabularyKey(nameof(QueryDefinition), "Query Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SegmentId = group.Add(new VocabularyKey(nameof(SegmentId), "Segment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SegmentType = group.Add(new VocabularyKey(nameof(SegmentType), "Segment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LastEvaluationDate { get; private set; }
        public VocabularyKey MemberCount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey QueryDefinition { get; private set; }
        public VocabularyKey SegmentId { get; private set; }
        public VocabularyKey SegmentType { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}