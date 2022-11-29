using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class NonEmbeddedCodelistVocabularyVocabulary : SimpleVocabulary
    {
        public NonEmbeddedCodelistVocabularyVocabulary()
        {
            VocabularyName = "Non Embedded Codelist Vocabulary";
            KeyPrefix = "commonDataModel.nonembeddedcodelistvocabulary.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/NonEmbeddedCodelistVocabulary";

            AddGroup("NonEmbeddedCodelistVocabulary Details for NonProfitIati", group =>
            {
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodelistType = group.Add(new VocabularyKey(nameof(CodelistType), "Codelist Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NonEmbeddedCodelistVocabularyId = group.Add(new VocabularyKey(nameof(NonEmbeddedCodelistVocabularyId), "Non Embedded Codelist Vocabulary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Uri = group.Add(new VocabularyKey(nameof(Uri), "URI", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey CodelistType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NonEmbeddedCodelistVocabularyId { get; private set; }
        public VocabularyKey Uri { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}