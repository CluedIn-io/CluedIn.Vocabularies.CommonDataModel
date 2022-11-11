using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMFundUsageEntityVocabulary : SimpleVocabulary
    {
        public TAMFundUsageEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMFundUsageEntity";
            KeyPrefix = "commonDataModel.tamfundusageentity";
            KeySeparator = ".";
            Grouping = "/TAMFundUsageEntity";

            AddGroup("Common Data Model TAMFundUsageEntity Details", group =>
            {
                UsageCode = group.Add(new VocabularyKey(nameof(UsageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsageDescription = group.Add(new VocabularyKey(nameof(UsageDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey UsageCode { get; private set; }
        public VocabularyKey UsageDescription { get; private set; }


    }
}