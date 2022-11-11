using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBIActivitiesAverageCloseTimeVocabulary : SimpleVocabulary
    {
        public CustCollectionsBIActivitiesAverageCloseTimeVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBIActivitiesAverageCloseTime";
            KeyPrefix = "commonDataModel.custcollectionsbiactivitiesaverageclosetime";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBIActivitiesAverageCloseTime";

            AddGroup("Common Data Model CustCollectionsBIActivitiesAverageCloseTime Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageClosedTime = group.Add(new VocabularyKey(nameof(AverageClosedTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibleWorker = group.Add(new VocabularyKey(nameof(ResponsibleWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey AverageClosedTime { get; private set; }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey ResponsibleWorker { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}