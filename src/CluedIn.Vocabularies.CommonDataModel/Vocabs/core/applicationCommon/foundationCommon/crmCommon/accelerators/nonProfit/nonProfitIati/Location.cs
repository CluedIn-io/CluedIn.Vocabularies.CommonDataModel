using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class LocationVocabulary : SimpleVocabulary
    {
        public LocationVocabulary()
        {
            VocabularyName = "Location";
            KeyPrefix = "commonDataModel.location.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Location";

            AddGroup("Location Details for NonProfitIati", group =>
            {
			    ActivityLocationDescription = group.Add(new VocabularyKey(nameof(ActivityLocationDescription), "Activity Location Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Level = group.Add(new VocabularyKey(nameof(Level), "Level", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LocationId = group.Add(new VocabularyKey(nameof(LocationId), "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Pos = group.Add(new VocabularyKey(nameof(Pos), "Position", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reference = group.Add(new VocabularyKey(nameof(Reference), "Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActivityLocationDescription { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Level { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Pos { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}