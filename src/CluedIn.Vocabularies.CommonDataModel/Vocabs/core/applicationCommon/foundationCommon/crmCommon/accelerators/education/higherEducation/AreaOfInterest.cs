using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class AreaOfInterestVocabulary : SimpleVocabulary
    {
        public AreaOfInterestVocabulary()
        {
            VocabularyName = "Area Of Interest";
            KeyPrefix = "commonDataModel.areaofinterest.highereducation";
            KeySeparator = ".";
            Grouping = "/AreaOfInterest";

            AddGroup("AreaOfInterest Details for HigherEducation", group =>
            {
			    AreaOfInterestId = group.Add(new VocabularyKey(nameof(AreaOfInterestId), "Area of Interest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Area of Interest Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AreaOfInterestId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
    }
}