using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class IatiFileGenerationVocabulary : SimpleVocabulary
    {
        public IatiFileGenerationVocabulary()
        {
            VocabularyName = "Iati File Generation";
            KeyPrefix = "commonDataModel.iatifilegeneration.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/IatiFileGeneration";

            AddGroup("IatiFileGeneration Details for NonProfitIati", group =>
            {
			    IatiFileGenerationId = group.Add(new VocabularyKey(nameof(IatiFileGenerationId), "IATI File Generation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IatiFileGenerationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}