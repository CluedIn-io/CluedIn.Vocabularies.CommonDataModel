using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ArticleTemplateVocabulary : SimpleVocabulary
    {
        public ArticleTemplateVocabulary()
        {
            VocabularyName = "Article Template";
            KeyPrefix = "commonDataModel.articletemplate";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ArticleTemplate;

            AddGroup("ArticleTemplate Details for ApplicationCommon", group =>
            {
			    KbArticleTemplateId = group.Add(new VocabularyKey(nameof(KbArticleTemplateId), "Article Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StructureXml = group.Add(new VocabularyKey(nameof(StructureXml), "Structure XML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FormatXml = group.Add(new VocabularyKey(nameof(FormatXml), "Format XML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsActive = group.Add(new VocabularyKey(nameof(IsActive), "Status", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    KbArticleTemplateIdUnique = group.Add(new VocabularyKey(nameof(KbArticleTemplateIdUnique), "For internal use only.", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ComponentState = group.Add(new VocabularyKey(nameof(ComponentState), "Component State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolutionId = group.Add(new VocabularyKey(nameof(SolutionId), "Solution", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    OverwriteTime = group.Add(new VocabularyKey(nameof(OverwriteTime), "Record Overwrite Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsManaged = group.Add(new VocabularyKey(nameof(IsManaged), VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsCustomizable = group.Add(new VocabularyKey(nameof(IsCustomizable), "Customizable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IntroducedVersion = group.Add(new VocabularyKey(nameof(IntroducedVersion), "Introduced Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="KbArticleTemplateId"/> from Vocab 'Article.cdm.json/Article' with Property 'KbArticleTemplateId'
            ///Property <see cref="KbArticleTemplateId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Article.cdm.json/Article' with Property 'KbArticleTemplateId'
            #endregion
        }

        public VocabularyKey ComponentState { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FormatXml { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IntroducedVersion { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey IsCustomizable { get; private set; }
        public VocabularyKey IsManaged { get; private set; }
        public VocabularyKey KbArticleTemplateId { get; private set; }
        public VocabularyKey KbArticleTemplateIdUnique { get; private set; }
        public VocabularyKey LanguageCode { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey OverwriteTime { get; private set; }
        public VocabularyKey SolutionId { get; private set; }
        public VocabularyKey StructureXml { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}