using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class NarrativeTranslationVocabulary : SimpleVocabulary
    {
        public NarrativeTranslationVocabulary()
        {
            VocabularyName = "Narrative Translation";
            KeyPrefix = "commonDataModel.narrativetranslation.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/NarrativeTranslation";

            AddGroup("NarrativeTranslation Details for NonProfitIati", group =>
            {
			    Attribute = group.Add(new VocabularyKey(nameof(Attribute), "Attribute", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityName = group.Add(new VocabularyKey(nameof(EntityName), "Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NarrativeTranslationId = group.Add(new VocabularyKey(nameof(NarrativeTranslationId), "Narrative Translation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Translation = group.Add(new VocabularyKey(nameof(Translation), "Translation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Attribute { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NarrativeTranslationId { get; private set; }
        public VocabularyKey Translation { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}