using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class BusinessVocabulary : SimpleVocabulary
    {
        public BusinessVocabulary()
        {
            VocabularyName = "Business";
            KeyPrefix = "commonDataModel.business.automotive";
            KeySeparator = ".";
            Grouping = "/Business";

            AddGroup("Business Details for Automotive", group =>
            {
			    BusinessId = group.Add(new VocabularyKey(nameof(BusinessId), "Business", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Identifier = group.Add(new VocabularyKey(nameof(Identifier), "Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BusinessId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}