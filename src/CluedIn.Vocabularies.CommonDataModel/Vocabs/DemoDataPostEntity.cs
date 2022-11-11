using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DemoDataPostEntityVocabulary : SimpleVocabulary
    {
        public DemoDataPostEntityVocabulary()
        {
            VocabularyName = "Common Data Model DemoDataPostEntity";
            KeyPrefix = "commonDataModel.demodatapostentity";
            KeySeparator = ".";
            Grouping = "/DemoDataPostEntity";

            AddGroup("Common Data Model DemoDataPostEntity Details", group =>
            {
                DemoDataJob = group.Add(new VocabularyKey(nameof(DemoDataJob), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Document = group.Add(new VocabularyKey(nameof(Document), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentTarget = group.Add(new VocabularyKey(nameof(DocumentTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDocument = group.Add(new VocabularyKey(nameof(FromDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDocument = group.Add(new VocabularyKey(nameof(ToDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessOnImport = group.Add(new VocabularyKey(nameof(ProcessOnImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemoDataJobStatus = group.Add(new VocabularyKey(nameof(DemoDataJobStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataProjectId = group.Add(new VocabularyKey(nameof(DataProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DemoDataJob { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey Document { get; private set; }
        public VocabularyKey DocumentTarget { get; private set; }
        public VocabularyKey FromDocument { get; private set; }
        public VocabularyKey ToDocument { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ProcessOnImport { get; private set; }
        public VocabularyKey DemoDataJobStatus { get; private set; }
        public VocabularyKey DataProjectId { get; private set; }


    }
}