using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ApplicationCommon
{
    public class EmailSignatureVocabulary : SimpleVocabulary
    {
        public EmailSignatureVocabulary()
        {
            VocabularyName = "Email Signature";
            KeyPrefix = "commonDataModel.emailsignature.applicationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.EmailSignature;

            AddGroup("EmailSignature Details for ApplicationCommon", group =>
            {
			    EmailSignatureId = group.Add(new VocabularyKey(nameof(EmailSignatureId), "Email Signature", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPersonal = group.Add(new VocabularyKey(nameof(IsPersonal), "Viewable By", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    MimeType = group.Add(new VocabularyKey(nameof(MimeType), "Mime Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Body = group.Add(new VocabularyKey(nameof(Body), "Body", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PresentationXml = group.Add(new VocabularyKey(nameof(PresentationXml), "Presentation XML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GenerationTypeCode = group.Add(new VocabularyKey(nameof(GenerationTypeCode), "Generation Type Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverwriteTime = group.Add(new VocabularyKey(nameof(OverwriteTime), "Record Overwrite Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComponentState = group.Add(new VocabularyKey(nameof(ComponentState), "Component State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), "Owning Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCustomizable = group.Add(new VocabularyKey(nameof(IsCustomizable), "Customizable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey EmailSignatureId { get; private set; }
        public VocabularyKey IsPersonal { get; private set; }
        public VocabularyKey MimeType { get; private set; }
        public VocabularyKey Body { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey PresentationXml { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey GenerationTypeCode { get; private set; }
        public VocabularyKey LanguageCode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverwriteTime { get; private set; }
        public VocabularyKey ComponentState { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey IsCustomizable { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
    }
}