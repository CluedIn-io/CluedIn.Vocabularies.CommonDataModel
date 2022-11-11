using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SegmentVocabulary : SimpleVocabulary
    {
        public SegmentVocabulary()
        {
            VocabularyName = "Common Data Model Segment";
            KeyPrefix = "commonDataModel.segment";
            KeySeparator = ".";
            Grouping = "/Segment";

            AddGroup("Common Data Model Segment Details", group =>
            {
                islive = group.Add(new VocabularyKey(nameof(islive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                scope = group.Add(new VocabularyKey(nameof(scope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentactivationstatus = group.Add(new VocabularyKey(nameof(segmentactivationstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentfilterquery = group.Add(new VocabularyKey(nameof(segmentfilterquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentId = group.Add(new VocabularyKey(nameof(segmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentmemberids = group.Add(new VocabularyKey(nameof(segmentmemberids), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentName = group.Add(new VocabularyKey(nameof(segmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentqueryName = group.Add(new VocabularyKey(nameof(segmentqueryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentNameview = group.Add(new VocabularyKey(nameof(segmentNameview), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentprovisioningstate = group.Add(new VocabularyKey(nameof(segmentprovisioningstate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentquery = group.Add(new VocabularyKey(nameof(segmentquery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentType = group.Add(new VocabularyKey(nameof(segmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                externalSource = group.Add(new VocabularyKey(nameof(externalSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                externalSegmentURL = group.Add(new VocabularyKey(nameof(externalSegmentURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentsize = group.Add(new VocabularyKey(nameof(segmentsize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                queryType = group.Add(new VocabularyKey(nameof(queryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmenttimezone = group.Add(new VocabularyKey(nameof(segmenttimezone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmenttargetprofiletypeName = group.Add(new VocabularyKey(nameof(segmenttargetprofiletypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentevaluationstate = group.Add(new VocabularyKey(nameof(segmentevaluationstate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentevaluationtype = group.Add(new VocabularyKey(nameof(segmentevaluationtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastEvaluationTime = group.Add(new VocabularyKey(nameof(lastEvaluationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                nextevaluation = group.Add(new VocabularyKey(nameof(nextevaluation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastUpdatedTime = group.Add(new VocabularyKey(nameof(lastUpdatedTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentevaluationdurationinminutes = group.Add(new VocabularyKey(nameof(segmentevaluationdurationinminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                segmentrefreshrateintervalminutes = group.Add(new VocabularyKey(nameof(segmentrefreshrateintervalminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey islive { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey scope { get; private set; }
        public VocabularyKey segmentactivationstatus { get; private set; }
        public VocabularyKey segmentfilterquery { get; private set; }
        public VocabularyKey segmentId { get; private set; }
        public VocabularyKey segmentmemberids { get; private set; }
        public VocabularyKey segmentName { get; private set; }
        public VocabularyKey segmentqueryName { get; private set; }
        public VocabularyKey segmentNameview { get; private set; }
        public VocabularyKey segmentprovisioningstate { get; private set; }
        public VocabularyKey segmentquery { get; private set; }
        public VocabularyKey segmentType { get; private set; }
        public VocabularyKey externalSource { get; private set; }
        public VocabularyKey externalSegmentURL { get; private set; }
        public VocabularyKey segmentsize { get; private set; }
        public VocabularyKey queryType { get; private set; }
        public VocabularyKey segmenttimezone { get; private set; }
        public VocabularyKey segmenttargetprofiletypeName { get; private set; }
        public VocabularyKey segmentevaluationstate { get; private set; }
        public VocabularyKey segmentevaluationtype { get; private set; }
        public VocabularyKey lastEvaluationTime { get; private set; }
        public VocabularyKey nextevaluation { get; private set; }
        public VocabularyKey lastUpdatedTime { get; private set; }
        public VocabularyKey segmentevaluationdurationinminutes { get; private set; }
        public VocabularyKey segmentrefreshrateintervalminutes { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}