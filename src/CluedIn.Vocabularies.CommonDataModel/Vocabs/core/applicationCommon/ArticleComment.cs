using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ArticleCommentVocabulary : SimpleVocabulary
    {
        public ArticleCommentVocabulary()
        {
            VocabularyName = "Article Comment";
            KeyPrefix = "commonDataModel.articlecomment";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ArticleComment;

            AddGroup("ArticleComment Details for ApplicationCommon", group =>
            {
			    KbArticleCommentId = group.Add(new VocabularyKey(nameof(KbArticleCommentId), "Article Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommentText = group.Add(new VocabularyKey(nameof(CommentText), "Comment Text", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization ", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="KbArticleId"/> to Vocab 'Article.cdm.json/Article' with Property 'KbArticleId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CommentText { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey KbArticleCommentId { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}