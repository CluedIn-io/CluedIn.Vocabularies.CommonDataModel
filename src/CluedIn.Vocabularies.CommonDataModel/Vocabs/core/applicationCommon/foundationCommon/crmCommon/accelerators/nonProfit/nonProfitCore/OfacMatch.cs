using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class OfacMatchVocabulary : SimpleVocabulary
    {
        public OfacMatchVocabulary()
        {
            VocabularyName = "Ofac Match";
            KeyPrefix = "commonDataModel.ofacmatch.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/OfacMatch";

            AddGroup("OfacMatch Details for NonProfitCore", group =>
            {
			    MatchType = group.Add(new VocabularyKey(nameof(MatchType), "Match Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OfacMatchId = group.Add(new VocabularyKey(nameof(OfacMatchId), "OFAC Match", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReportDate = group.Add(new VocabularyKey(nameof(ReportDate), "Report Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SDNName = group.Add(new VocabularyKey(nameof(SDNName), "SDN Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SDNNumber = group.Add(new VocabularyKey(nameof(SDNNumber), "SDN Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MatchType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OfacMatchId { get; private set; }
        public VocabularyKey ReportDate { get; private set; }
        public VocabularyKey SDNName { get; private set; }
        public VocabularyKey SDNNumber { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}