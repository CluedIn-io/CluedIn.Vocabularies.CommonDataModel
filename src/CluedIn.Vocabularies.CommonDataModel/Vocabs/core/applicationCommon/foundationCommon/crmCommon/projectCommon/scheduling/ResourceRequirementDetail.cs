using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class ResourceRequirementDetailVocabulary : SimpleVocabulary
    {
        public ResourceRequirementDetailVocabulary()
        {
            VocabularyName = "Resource Requirement Detail";
            KeyPrefix = "commonDataModel.resourcerequirementdetail.scheduling";
            KeySeparator = ".";
            Grouping = "/ResourceRequirementDetail";

            AddGroup("ResourceRequirementDetail Details for Scheduling", group =>
            {
			    ResourceRequirementDetailId = group.Add(new VocabularyKey(nameof(ResourceRequirementDetailId), "Resource Requirement Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Hours = group.Add(new VocabularyKey(nameof(Hours), "Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ResourceRequirementDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey From { get; private set; }
        public VocabularyKey To { get; private set; }
        public VocabularyKey Hours { get; private set; }
    }
}