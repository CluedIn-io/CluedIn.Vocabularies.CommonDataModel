using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjGrantFrequencyEntityVocabulary : SimpleVocabulary
    {
        public ProjGrantFrequencyEntityVocabulary()
        {
            VocabularyName = "Proj Grant Frequency Entity";
            KeyPrefix = "commonDataModel.projgrantfrequencyentity";
            KeySeparator = ".";
            Grouping = "/ProjGrantFrequencyEntity";

            AddGroup("ProjGrantFrequencyEntity Details", group =>
            {
                Frequency = group.Add(new VocabularyKey(nameof(Frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FrequencyComments = group.Add(new VocabularyKey(nameof(FrequencyComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrant = group.Add(new VocabularyKey(nameof(ProjGrant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrant_GrantId = group.Add(new VocabularyKey(nameof(ProjGrant_GrantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Frequency { get; private set; }
        public VocabularyKey FrequencyComments { get; private set; }
        public VocabularyKey ProjGrant { get; private set; }
        public VocabularyKey ProjGrant_GrantId { get; private set; }
    }
}