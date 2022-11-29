using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class LeadDispositionVocabulary : SimpleVocabulary
    {
        public LeadDispositionVocabulary()
        {
            VocabularyName = "Lead Disposition";
            KeyPrefix = "commonDataModel.leaddisposition.automotive";
            KeySeparator = ".";
            Grouping = "/LeadDisposition";

            AddGroup("LeadDisposition Details for Automotive", group =>
            {
			    LeadDispositionId = group.Add(new VocabularyKey(nameof(LeadDispositionId), "Lead Disposition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LeadDispositionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}