using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class PolicyMarkerVocabulary : SimpleVocabulary
    {
        public PolicyMarkerVocabulary()
        {
            VocabularyName = "Policy Marker";
            KeyPrefix = "commonDataModel.policymarker.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/PolicyMarker";

            AddGroup("PolicyMarker Details for NonProfitIati", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PolicyMarkerId = group.Add(new VocabularyKey(nameof(PolicyMarkerId), "Policy Marker", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PolicyMarkerId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}