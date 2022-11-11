using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBICaseAverageCloseTimeVocabulary : SimpleVocabulary
    {
        public CustCollectionsBICaseAverageCloseTimeVocabulary()
        {
            VocabularyName = "CustCollectionsBICaseAverageCloseTime";
            KeyPrefix = "commonDataModel.custcollectionsbicaseaverageclosetime";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBICaseAverageCloseTime";

            AddGroup("CustCollectionsBICaseAverageCloseTime Details", group =>
            {
                CaseId = group.Add(new VocabularyKey(nameof(CaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageClosedTime = group.Add(new VocabularyKey(nameof(AverageClosedTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibleWorker = group.Add(new VocabularyKey(nameof(ResponsibleWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CaseId { get; private set; }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey AverageClosedTime { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ResponsibleWorker { get; private set; }


    }
}