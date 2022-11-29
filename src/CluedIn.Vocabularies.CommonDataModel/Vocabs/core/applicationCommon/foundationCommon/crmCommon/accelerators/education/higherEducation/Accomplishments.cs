using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class AccomplishmentsVocabulary : SimpleVocabulary
    {
        public AccomplishmentsVocabulary()
        {
            VocabularyName = "Accomplishments";
            KeyPrefix = "commonDataModel.accomplishments.highereducation";
            KeySeparator = ".";
            Grouping = "/Accomplishments";

            AddGroup("Accomplishments Details for HigherEducation", group =>
            {
			    AccomplishmentsId = group.Add(new VocabularyKey(nameof(AccomplishmentsId), "Accomplishments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccomplishmentType = group.Add(new VocabularyKey(nameof(AccomplishmentType), "Accomplishment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Accomplishment Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AccomplishmentsId { get; private set; }
        public VocabularyKey AccomplishmentType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}