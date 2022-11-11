using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocuFileTypesEntityVocabulary : SimpleVocabulary
    {
        public DocuFileTypesEntityVocabulary()
        {
            VocabularyName = "Common Data Model DocuFileTypesEntity";
            KeyPrefix = "commonDataModel.docufiletypesentity";
            KeySeparator = ".";
            Grouping = "/DocuFileTypesEntity";

            AddGroup("Common Data Model DocuFileTypesEntity Details", group =>
            {
                FileType = group.Add(new VocabularyKey(nameof(FileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileTypeDescription = group.Add(new VocabularyKey(nameof(FileTypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NativelyWebRenderable = group.Add(new VocabularyKey(nameof(NativelyWebRenderable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FileType { get; private set; }
        public VocabularyKey FileTypeDescription { get; private set; }
        public VocabularyKey NativelyWebRenderable { get; private set; }


    }
}