using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjGrantMatchingEntityVocabulary : SimpleVocabulary
    {
        public ProjGrantMatchingEntityVocabulary()
        {
            VocabularyName = "Proj Grant Matching Entity";
            KeyPrefix = "commonDataModel.projgrantmatchingentity";
            KeySeparator = ".";
            Grouping = "/ProjGrantMatchingEntity";

            AddGroup("ProjGrantMatchingEntity Details", group =>
            {
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingPercentage = group.Add(new VocabularyKey(nameof(MatchingPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingType = group.Add(new VocabularyKey(nameof(MatchingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey MatchingPercentage { get; private set; }
        public VocabularyKey MatchingType { get; private set; }
    }
}