using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class AdPlacementVocabulary : SimpleVocabulary
    {
        public AdPlacementVocabulary()
        {
            VocabularyName = "Ad Placement";
            KeyPrefix = "commonDataModel.adplacement.portals";
            KeySeparator = ".";
            Grouping = "/AdPlacement";

            AddGroup("AdPlacement Details for Portals", group =>
            {
			    AdPlacementId = group.Add(new VocabularyKey(nameof(AdPlacementId), "Ad Placement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AdPlacementId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}