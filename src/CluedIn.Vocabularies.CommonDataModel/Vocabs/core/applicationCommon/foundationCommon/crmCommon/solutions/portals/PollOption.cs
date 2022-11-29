using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class PollOptionVocabulary : SimpleVocabulary
    {
        public PollOptionVocabulary()
        {
            VocabularyName = "Poll Option";
            KeyPrefix = "commonDataModel.polloption.portals";
            KeySeparator = ".";
            Grouping = "/PollOption";

            AddGroup("PollOption Details for Portals", group =>
            {
			    PollOptionId = group.Add(new VocabularyKey(nameof(PollOptionId), "Poll Option", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Answer = group.Add(new VocabularyKey(nameof(Answer), "Response", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), "Display Order", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Votes = group.Add(new VocabularyKey(nameof(Votes), "Votes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PollOptionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Answer { get; private set; }
        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey Votes { get; private set; }
    }
}