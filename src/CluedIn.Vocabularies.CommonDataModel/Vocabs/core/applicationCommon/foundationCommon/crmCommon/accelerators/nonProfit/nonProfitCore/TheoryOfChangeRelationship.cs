using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class TheoryOfChangeRelationshipVocabulary : SimpleVocabulary
    {
        public TheoryOfChangeRelationshipVocabulary()
        {
            VocabularyName = "Theory Of Change Relationship";
            KeyPrefix = "commonDataModel.theoryofchangerelationship.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/TheoryOfChangeRelationship";

            AddGroup("TheoryOfChangeRelationship Details for NonProfitCore", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TheoryOfChangeRelationshipId = group.Add(new VocabularyKey(nameof(TheoryOfChangeRelationshipId), "Theory of Change Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey TheoryOfChangeRelationshipId { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}