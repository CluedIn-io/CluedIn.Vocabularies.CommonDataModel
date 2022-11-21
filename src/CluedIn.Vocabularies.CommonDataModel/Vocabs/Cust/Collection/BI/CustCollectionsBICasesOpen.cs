using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBICasesOpenVocabulary : SimpleVocabulary
    {
        public CustCollectionsBICasesOpenVocabulary()
        {
            VocabularyName = "Cust Collections BI Cases Open";
            KeyPrefix = "commonDataModel.custcollectionsbicasesopen";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBICasesOpen";

            AddGroup("CustCollectionsBICasesOpen Details", group =>
            {
                CaseId = group.Add(new VocabularyKey(nameof(CaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponsibleWorker = group.Add(new VocabularyKey(nameof(ResponsibleWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CaseId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ResponsibleWorker { get; private set; }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}