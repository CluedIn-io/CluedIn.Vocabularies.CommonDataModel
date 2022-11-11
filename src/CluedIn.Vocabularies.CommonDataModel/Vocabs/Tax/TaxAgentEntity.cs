using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxAgentEntityVocabulary : SimpleVocabulary
    {
        public TaxAgentEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxAgentEntity";
            KeyPrefix = "commonDataModel.taxagententity";
            KeySeparator = ".";
            Grouping = "/TaxAgentEntity";

            AddGroup("Common Data Model TaxAgentEntity Details", group =>
            {
                AgentId = group.Add(new VocabularyKey(nameof(AgentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Party = group.Add(new VocabularyKey(nameof(Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegNum = group.Add(new VocabularyKey(nameof(TaxRegNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AgentId { get; private set; }
        public VocabularyKey Party { get; private set; }
        public VocabularyKey TaxRegNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }


    }
}