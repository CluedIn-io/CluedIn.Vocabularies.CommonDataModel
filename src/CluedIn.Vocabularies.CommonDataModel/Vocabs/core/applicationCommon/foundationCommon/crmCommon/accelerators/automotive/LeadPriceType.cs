using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class LeadPriceTypeVocabulary : SimpleVocabulary
    {
        public LeadPriceTypeVocabulary()
        {
            VocabularyName = "Lead Price Type";
            KeyPrefix = "commonDataModel.leadpricetype.automotive";
            KeySeparator = ".";
            Grouping = "/LeadPriceType";

            AddGroup("LeadPriceType Details for Automotive", group =>
            {
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Delta = group.Add(new VocabularyKey(nameof(Delta), "Delta", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadPriceTypeId = group.Add(new VocabularyKey(nameof(LeadPriceTypeId), "Lead Price Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelativeTo = group.Add(new VocabularyKey(nameof(RelativeTo), "Relative To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey Delta { get; private set; }
        public VocabularyKey LeadPriceTypeId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RelativeTo { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}