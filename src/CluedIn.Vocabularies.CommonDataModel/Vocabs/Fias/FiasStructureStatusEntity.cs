using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasStructureStatusEntityVocabulary : SimpleVocabulary
    {
        public FiasStructureStatusEntityVocabulary()
        {
            VocabularyName = "FiasStructureStatusEntity";
            KeyPrefix = "commonDataModel.fiasstructurestatusentity";
            KeySeparator = ".";
            Grouping = "/FiasStructureStatusEntity";

            AddGroup("FiasStructureStatusEntity Details", group =>
            {
                StrStatId = group.Add(new VocabularyKey(nameof(StrStatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShortName = group.Add(new VocabularyKey(nameof(ShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey StrStatId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ShortName { get; private set; }


    }
}