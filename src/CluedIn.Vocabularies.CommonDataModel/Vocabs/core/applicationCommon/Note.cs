using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class NoteVocabulary : SimpleVocabulary
    {
        public NoteVocabulary()
        {
            VocabularyName = "Note";
            KeyPrefix = "commonDataModel.note.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Note";

            AddGroup("Note Details for ApplicationCommon", group =>
            {
			    AnnotationId = group.Add(new VocabularyKey(nameof(AnnotationId), "Note", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), "Object Type ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDocument = group.Add(new VocabularyKey(nameof(IsDocument), "Is Document", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    NoteText = group.Add(new VocabularyKey(nameof(NoteText), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MimeType = group.Add(new VocabularyKey(nameof(MimeType), "Mime Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LangId = group.Add(new VocabularyKey(nameof(LangId), "Language ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentBody = group.Add(new VocabularyKey(nameof(DocumentBody), "Document", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FileSize = group.Add(new VocabularyKey(nameof(FileSize), "File Size (Bytes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    FileName = group.Add(new VocabularyKey(nameof(FileName), "File Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StepId = group.Add(new VocabularyKey(nameof(StepId), "Step Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AnnotationId { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey IsDocument { get; private set; }
        public VocabularyKey NoteText { get; private set; }
        public VocabularyKey MimeType { get; private set; }
        public VocabularyKey LangId { get; private set; }
        public VocabularyKey DocumentBody { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey FileSize { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey StepId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
    }
}