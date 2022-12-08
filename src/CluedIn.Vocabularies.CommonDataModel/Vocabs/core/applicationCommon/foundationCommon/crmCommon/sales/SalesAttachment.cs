using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Sales
{
    public class SalesAttachmentVocabulary : SimpleVocabulary
    {
        public SalesAttachmentVocabulary()
        {
            VocabularyName = "Sales Attachment";
            KeyPrefix = "commonDataModel.salesattachment.sales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SalesAttachment;

            AddGroup("SalesAttachment Details for Sales", group =>
            {
			    SalesLiteratureItemId = group.Add(new VocabularyKey(nameof(SalesLiteratureItemId), "Sales Literature Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Abstract = group.Add(new VocabularyKey(nameof(Abstract), "Abstract", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AttachedDocumentUrl = group.Add(new VocabularyKey(nameof(AttachedDocumentUrl), "Attached Document URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    AuthorName = group.Add(new VocabularyKey(nameof(AuthorName), "Author Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentBody = group.Add(new VocabularyKey(nameof(DocumentBody), "Shows the encoded contents of the sales literature document attachment.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FileName = group.Add(new VocabularyKey(nameof(FileName), "File Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FileSize = group.Add(new VocabularyKey(nameof(FileSize), "File Size (Bytes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    FileTypeCode = group.Add(new VocabularyKey(nameof(FileTypeCode), "File Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsCustomerViewable = group.Add(new VocabularyKey(nameof(IsCustomerViewable), "Customer Viewable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    KeyWords = group.Add(new VocabularyKey(nameof(KeyWords), "Key Words", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MimeType = group.Add(new VocabularyKey(nameof(MimeType), "Mime Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization ", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Mode = group.Add(new VocabularyKey(nameof(Mode), "Mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="SalesLiteratureId"/> to Vocab 'SalesLiterature.cdm.json/SalesLiterature' with Property 'SalesLiteratureId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey SalesLiteratureItemId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Abstract { get; private set; }
        public VocabularyKey AttachedDocumentUrl { get; private set; }
        public VocabularyKey AuthorName { get; private set; }
        public VocabularyKey DocumentBody { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey FileSize { get; private set; }
        public VocabularyKey FileTypeCode { get; private set; }
        public VocabularyKey IsCustomerViewable { get; private set; }
        public VocabularyKey KeyWords { get; private set; }
        public VocabularyKey MimeType { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey Mode { get; private set; }
    }
}