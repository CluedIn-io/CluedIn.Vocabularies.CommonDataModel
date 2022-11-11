using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasEstateStatusEntityVocabulary : SimpleVocabulary
    {
        public FiasEstateStatusEntityVocabulary()
        {
            VocabularyName = "FiasEstateStatusEntity";
            KeyPrefix = "commonDataModel.fiasestatestatusentity";
            KeySeparator = ".";
            Grouping = "/FiasEstateStatusEntity";

            AddGroup("FiasEstateStatusEntity Details", group =>
            {
                EstStatId = group.Add(new VocabularyKey(nameof(EstStatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EstStatId { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}