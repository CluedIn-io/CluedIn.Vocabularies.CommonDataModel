using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class PollPlacementVocabulary : SimpleVocabulary
    {
        public PollPlacementVocabulary()
        {
            VocabularyName = "Poll Placement";
            KeyPrefix = "commonDataModel.pollplacement.portals";
            KeySeparator = ".";
            Grouping = "/PollPlacement";

            AddGroup("PollPlacement Details for Portals", group =>
            {
			    PollPlacementId = group.Add(new VocabularyKey(nameof(PollPlacementId), "Poll Placement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PollPlacementId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}