using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class FleetVocabulary : SimpleVocabulary
    {
        public FleetVocabulary()
        {
            VocabularyName = "Fleet";
            KeyPrefix = "commonDataModel.fleet.automotive";
            KeySeparator = ".";
            Grouping = "/Fleet";

            AddGroup("Fleet Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FleetId = group.Add(new VocabularyKey(nameof(FleetId), "Fleet", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FleetType = group.Add(new VocabularyKey(nameof(FleetType), "Fleet Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey FleetId { get; private set; }
        public VocabularyKey FleetType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}