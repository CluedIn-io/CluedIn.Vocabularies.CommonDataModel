using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSeasonEntityVocabulary : SimpleVocabulary
    {
        public RetailSeasonEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailSeasonEntity";
            KeyPrefix = "commonDataModel.retailseasonentity";
            KeySeparator = ".";
            Grouping = "/RetailSeasonEntity";

            AddGroup("Common Data Model RetailSeasonEntity Details", group =>
            {
                SeasonCode = group.Add(new VocabularyKey(nameof(SeasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SeasonCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey StartDate { get; private set; }


    }
}