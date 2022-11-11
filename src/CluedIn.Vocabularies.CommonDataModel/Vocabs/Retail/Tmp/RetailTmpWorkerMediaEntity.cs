using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTmpWorkerMediaEntityVocabulary : SimpleVocabulary
    {
        public RetailTmpWorkerMediaEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTmpWorkerMediaEntity";
            KeyPrefix = "commonDataModel.retailtmpworkermediaentity";
            KeySeparator = ".";
            Grouping = "/RetailTmpWorkerMediaEntity";

            AddGroup("Common Data Model RetailTmpWorkerMediaEntity Details", group =>
            {
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerName = group.Add(new VocabularyKey(nameof(WorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey(nameof(Url), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationStatus = group.Add(new VocabularyKey(nameof(AssociationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Worker { get; private set; }
        public VocabularyKey WorkerName { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AssociationStatus { get; private set; }


    }
}