using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DocuTypeEntityVocabulary : SimpleVocabulary
    {
        public DocuTypeEntityVocabulary()
        {
            VocabularyName = "DocuTypeEntity";
            KeyPrefix = "commonDataModel.docutypeentity";
            KeySeparator = ".";
            Grouping = "/DocuTypeEntity";

            AddGroup("DocuTypeEntity Details", group =>
            {
                ActionClassName = group.Add(new VocabularyKey(nameof(ActionClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocuStructureType = group.Add(new VocabularyKey(nameof(DocuStructureType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FilePlace = group.Add(new VocabularyKey(nameof(FilePlace), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileRemovalConfirmation = group.Add(new VocabularyKey(nameof(FileRemovalConfirmation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Parameters = group.Add(new VocabularyKey(nameof(Parameters), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemoveOption = group.Add(new VocabularyKey(nameof(RemoveOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeGroup = group.Add(new VocabularyKey(nameof(TypeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Host = group.Add(new VocabularyKey(nameof(Host), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Site = group.Add(new VocabularyKey(nameof(Site), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionClassId = group.Add(new VocabularyKey(nameof(ActionClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FolderPath = group.Add(new VocabularyKey(nameof(FolderPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActionClassName { get; private set; }
        public VocabularyKey DocuStructureType { get; private set; }
        public VocabularyKey FilePlace { get; private set; }
        public VocabularyKey FileRemovalConfirmation { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Parameters { get; private set; }
        public VocabularyKey RemoveOption { get; private set; }
        public VocabularyKey TypeGroup { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey Host { get; private set; }
        public VocabularyKey Site { get; private set; }
        public VocabularyKey ActionClassId { get; private set; }
        public VocabularyKey FolderPath { get; private set; }


    }
}