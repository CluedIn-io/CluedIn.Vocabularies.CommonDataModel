using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMFundUsageEntityVocabulary : SimpleVocabulary
    {
        public TAMFundUsageEntityVocabulary()
        {
            VocabularyName = "TAM Fund Usage Entity";
            KeyPrefix = "commonDataModel.tamfundusageentity";
            KeySeparator = ".";
            Grouping = "/TAMFundUsageEntity";

            AddGroup("TAMFundUsageEntity Details", group =>
            {
                UsageCode = group.Add(new VocabularyKey(nameof(UsageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsageDescription = group.Add(new VocabularyKey(nameof(UsageDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey UsageCode { get; private set; }
        public VocabularyKey UsageDescription { get; private set; }
    }
}