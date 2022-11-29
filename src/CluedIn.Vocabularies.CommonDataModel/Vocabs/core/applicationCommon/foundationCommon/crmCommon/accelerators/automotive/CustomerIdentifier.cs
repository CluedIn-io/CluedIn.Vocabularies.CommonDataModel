using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class CustomerIdentifierVocabulary : SimpleVocabulary
    {
        public CustomerIdentifierVocabulary()
        {
            VocabularyName = "Customer Identifier";
            KeyPrefix = "commonDataModel.customeridentifier.automotive";
            KeySeparator = ".";
            Grouping = "/CustomerIdentifier";

            AddGroup("CustomerIdentifier Details for Automotive", group =>
            {
			    CustomerIdentifierId = group.Add(new VocabularyKey(nameof(CustomerIdentifierId), "Customer Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Identifier = group.Add(new VocabularyKey(nameof(Identifier), "Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CustomerIdentifierId { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}