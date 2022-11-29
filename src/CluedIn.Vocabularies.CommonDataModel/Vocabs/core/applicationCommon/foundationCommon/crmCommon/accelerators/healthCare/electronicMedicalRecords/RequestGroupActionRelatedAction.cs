using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupActionRelatedActionVocabulary : SimpleVocabulary
    {
        public RequestGroupActionRelatedActionVocabulary()
        {
            VocabularyName = "Request Group Action Related Action";
            KeyPrefix = "commonDataModel.requestgroupactionrelatedaction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupActionRelatedAction";

            AddGroup("RequestGroupActionRelatedAction Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedActionNumber = group.Add(new VocabularyKey(nameof(RelatedActionNumber), "Related Action Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetDuration = group.Add(new VocabularyKey(nameof(RelatedActionOffsetDuration), "Offset Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetRangeHigh = group.Add(new VocabularyKey(nameof(RelatedActionOffsetRangeHigh), "Offset Duration High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetRangeLow = group.Add(new VocabularyKey(nameof(RelatedActionOffsetRangeLow), "Offset Duration Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RelatedActionOffsetType = group.Add(new VocabularyKey(nameof(RelatedActionOffsetType), "Offset Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedActionRelationship = group.Add(new VocabularyKey(nameof(RelatedActionRelationship), "Related Action Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionRelatedActionId = group.Add(new VocabularyKey(nameof(RequestGroupActionRelatedActionId), "Request Group Action Related Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey RelatedActionNumber { get; private set; }
        public VocabularyKey RelatedActionOffsetDuration { get; private set; }
        public VocabularyKey RelatedActionOffsetRangeHigh { get; private set; }
        public VocabularyKey RelatedActionOffsetRangeLow { get; private set; }
        public VocabularyKey RelatedActionOffsetType { get; private set; }
        public VocabularyKey RelatedActionRelationship { get; private set; }
        public VocabularyKey RequestGroupActionRelatedActionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}