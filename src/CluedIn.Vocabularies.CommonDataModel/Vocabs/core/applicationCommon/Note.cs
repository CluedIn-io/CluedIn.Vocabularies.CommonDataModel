using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class NoteVocabulary : SimpleVocabulary
    {
        public NoteVocabulary()
        {
            VocabularyName = "Note";
            KeyPrefix = "commonDataModel.note";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Note;

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
            
            #region Incoming Relationships
            ///Property <see cref="ObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ObjectId"/> to Vocab 'Appointment.cdm.json/Appointment' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'Article.cdm.json/Article' with Property 'KbArticleId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="ObjectId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ObjectId"/> to Vocab 'Email.cdm.json/Email' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'Fax.cdm.json/Fax' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'Goal.cdm.json/Goal' with Property 'GoalId'
            ///Property <see cref="ObjectId"/> to Vocab 'KnowledgeArticle.cdm.json/KnowledgeArticle' with Property 'KnowledgearticleId'
            ///Property <see cref="ObjectId"/> to Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'KnowledgeBaseRecordId'
            ///Property <see cref="ObjectId"/> to Vocab 'Letter.cdm.json/Letter' with Property 'ActivityId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ObjectId"/> to Vocab 'Task.cdm.json/Task' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="ObjectId"/> to Vocab 'PhoneCall.cdm.json/PhoneCall' with Property 'ActivityId'
            ///Property <see cref="ObjectId"/> to Vocab 'RecurringAppointment.cdm.json/RecurringAppointment' with Property 'ActivityId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AnnotationId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey DocumentBody { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey FileSize { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IsDocument { get; private set; }
        public VocabularyKey LangId { get; private set; }
        public VocabularyKey MimeType { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey NoteText { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StepId { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}