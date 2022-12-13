using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DocumentLinkVocabulary : SimpleVocabulary
    {
        public DocumentLinkVocabulary()
        {
            VocabularyName = "Document Link";
            KeyPrefix = "commonDataModel.documentlink";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DocumentLink;

            AddGroup("DocumentLink Details for NonProfitIati", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentLinkId = group.Add(new VocabularyKey(nameof(DocumentLinkId), "Document Link", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PublicationDate = group.Add(new VocabularyKey(nameof(PublicationDate), "Publication Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey(nameof(Url), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="FileFormat"/> to Vocab 'NonEmbeddedCodelist.cdm.json/NonEmbeddedCodelist' with Property 'NonEmbeddedCodelistId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="DocumentLinkId"/> from Vocab 'DocumentCategory.cdm.json/DocumentCategory' with Property 'DocumentLink'
            ///Property <see cref="DocumentLinkId"/> from Vocab 'DocumentCountry.cdm.json/DocumentCountry' with Property 'DocumentLink'
            ///Property <see cref="DocumentLinkId"/> from Vocab 'DocumentLanguage.cdm.json/DocumentLanguage' with Property 'DocumentLink'
            ///Property <see cref="DocumentLinkId"/> from Vocab 'NarrativeTranslation.cdm.json/NarrativeTranslation' with Property 'DocumentLinkId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DocumentLinkId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PublicationDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Url { get; private set; }
    }
}