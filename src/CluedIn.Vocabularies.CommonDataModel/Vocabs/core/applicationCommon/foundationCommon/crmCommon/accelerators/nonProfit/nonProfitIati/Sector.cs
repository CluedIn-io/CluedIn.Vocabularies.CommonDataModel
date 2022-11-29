using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class SectorVocabulary : SimpleVocabulary
    {
        public SectorVocabulary()
        {
            VocabularyName = "Sector";
            KeyPrefix = "commonDataModel.sector.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Sector";

            AddGroup("Sector Details for NonProfitIati", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Percentage = group.Add(new VocabularyKey(nameof(Percentage), "Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RelatedTo = group.Add(new VocabularyKey(nameof(RelatedTo), "Related To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SectorId = group.Add(new VocabularyKey(nameof(SectorId), "Sector", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey RelatedTo { get; private set; }
        public VocabularyKey SectorId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}