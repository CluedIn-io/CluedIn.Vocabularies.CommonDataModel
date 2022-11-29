using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class LeadProspectVocabulary : SimpleVocabulary
    {
        public LeadProspectVocabulary()
        {
            VocabularyName = "Lead Prospect";
            KeyPrefix = "commonDataModel.leadprospect.automotive";
            KeySeparator = ".";
            Grouping = "/LeadProspect";

            AddGroup("LeadProspect Details for Automotive", group =>
            {
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Intention = group.Add(new VocabularyKey(nameof(Intention), "Intention", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IntentionDateEarliest = group.Add(new VocabularyKey(nameof(IntentionDateEarliest), "Intention Date Earliest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IntentionDateLatest = group.Add(new VocabularyKey(nameof(IntentionDateLatest), "Intention Date Latest", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadProspectId = group.Add(new VocabularyKey(nameof(LeadProspectId), "Lead Prospect", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey Intention { get; private set; }
        public VocabularyKey IntentionDateEarliest { get; private set; }
        public VocabularyKey IntentionDateLatest { get; private set; }
        public VocabularyKey LeadProspectId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}