using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReturnDispositionCodeEntityVocabulary : SimpleVocabulary
    {
        public ReturnDispositionCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReturnDispositionCodeEntity";
            KeyPrefix = "commonDataModel.returndispositioncodeentity";
            KeySeparator = ".";
            Grouping = "/ReturnDispositionCodeEntity";

            AddGroup("Common Data Model ReturnDispositionCodeEntity Details", group =>
            {
                DispositionDescription = group.Add(new VocabularyKey(nameof(DispositionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DispositionAction = group.Add(new VocabularyKey(nameof(DispositionAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DispositionCode = group.Add(new VocabularyKey(nameof(DispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DispositionDescription { get; private set; }
        public VocabularyKey DispositionAction { get; private set; }
        public VocabularyKey DispositionCode { get; private set; }


    }
}