using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SegmentVocabulary : SimpleVocabulary
    {
        public SegmentVocabulary()
        {
            VocabularyName = "Segment";
            KeyPrefix = "commonDataModel.segment";
            KeySeparator = ".";
            Grouping = "/Segment";

            AddGroup("Segment Details", group =>
            {
                Islive = group.Add(new VocabularyKey(nameof(Islive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scope = group.Add(new VocabularyKey(nameof(Scope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentactivationstatus = group.Add(new VocabularyKey(nameof(Segmentactivationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentfilterquery = group.Add(new VocabularyKey(nameof(Segmentfilterquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentId = group.Add(new VocabularyKey(nameof(SegmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentmemberids = group.Add(new VocabularyKey(nameof(Segmentmemberids), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentName = group.Add(new VocabularyKey(nameof(SegmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentqueryName = group.Add(new VocabularyKey(nameof(SegmentqueryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentNameview = group.Add(new VocabularyKey(nameof(SegmentNameview), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentprovisioningstate = group.Add(new VocabularyKey(nameof(Segmentprovisioningstate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentquery = group.Add(new VocabularyKey(nameof(Segmentquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmentType = group.Add(new VocabularyKey(nameof(SegmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalSource = group.Add(new VocabularyKey(nameof(ExternalSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalSegmentURL = group.Add(new VocabularyKey(nameof(ExternalSegmentURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentsize = group.Add(new VocabularyKey(nameof(Segmentsize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryType = group.Add(new VocabularyKey(nameof(QueryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmenttimezone = group.Add(new VocabularyKey(nameof(Segmenttimezone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SegmenttargetprofiletypeName = group.Add(new VocabularyKey(nameof(SegmenttargetprofiletypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentevaluationstate = group.Add(new VocabularyKey(nameof(Segmentevaluationstate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentevaluationtype = group.Add(new VocabularyKey(nameof(Segmentevaluationtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastEvaluationTime = group.Add(new VocabularyKey(nameof(LastEvaluationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nextevaluation = group.Add(new VocabularyKey(nameof(Nextevaluation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastUpdatedTime = group.Add(new VocabularyKey(nameof(LastUpdatedTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentevaluationdurationinminutes = group.Add(new VocabularyKey(nameof(Segmentevaluationdurationinminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Segmentrefreshrateintervalminutes = group.Add(new VocabularyKey(nameof(Segmentrefreshrateintervalminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Islive { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Scope { get; private set; }
        public VocabularyKey Segmentactivationstatus { get; private set; }
        public VocabularyKey Segmentfilterquery { get; private set; }
        public VocabularyKey SegmentId { get; private set; }
        public VocabularyKey Segmentmemberids { get; private set; }
        public VocabularyKey SegmentName { get; private set; }
        public VocabularyKey SegmentqueryName { get; private set; }
        public VocabularyKey SegmentNameview { get; private set; }
        public VocabularyKey Segmentprovisioningstate { get; private set; }
        public VocabularyKey Segmentquery { get; private set; }
        public VocabularyKey SegmentType { get; private set; }
        public VocabularyKey ExternalSource { get; private set; }
        public VocabularyKey ExternalSegmentURL { get; private set; }
        public VocabularyKey Segmentsize { get; private set; }
        public VocabularyKey QueryType { get; private set; }
        public VocabularyKey Segmenttimezone { get; private set; }
        public VocabularyKey SegmenttargetprofiletypeName { get; private set; }
        public VocabularyKey Segmentevaluationstate { get; private set; }
        public VocabularyKey Segmentevaluationtype { get; private set; }
        public VocabularyKey LastEvaluationTime { get; private set; }
        public VocabularyKey Nextevaluation { get; private set; }
        public VocabularyKey LastUpdatedTime { get; private set; }
        public VocabularyKey Segmentevaluationdurationinminutes { get; private set; }
        public VocabularyKey Segmentrefreshrateintervalminutes { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}