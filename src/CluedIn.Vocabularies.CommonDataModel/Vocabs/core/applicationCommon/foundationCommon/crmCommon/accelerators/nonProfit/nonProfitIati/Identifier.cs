using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class IdentifierVocabulary : SimpleVocabulary
    {
        public IdentifierVocabulary()
        {
            VocabularyName = "Identifier";
            KeyPrefix = "commonDataModel.identifier.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Identifier";

            AddGroup("Identifier Details for NonProfitIati", group =>
            {
			    IdentifierId = group.Add(new VocabularyKey(nameof(IdentifierId), "Other Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reference = group.Add(new VocabularyKey(nameof(Reference), "Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IdentifierId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}