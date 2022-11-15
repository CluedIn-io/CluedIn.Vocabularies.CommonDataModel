using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailWorkerClientBookEntityVocabulary : SimpleVocabulary
    {
        public RetailWorkerClientBookEntityVocabulary()
        {
            VocabularyName = "Retail Worker Client Book Entity";
            KeyPrefix = "commonDataModel.retailworkerclientbookentity";
            KeySeparator = ".";
            Grouping = "/RetailWorkerClientBookEntity";

            AddGroup("RetailWorkerClientBookEntity Details", group =>
            {
                ClientBookWorker = group.Add(new VocabularyKey(nameof(ClientBookWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientBookId = group.Add(new VocabularyKey(nameof(ClientBookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ClientBookWorker { get; private set; }
        public VocabularyKey ClientBookId { get; private set; }
    }
}