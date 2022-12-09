using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class BlogPostVocabulary : SimpleVocabulary
    {
        public BlogPostVocabulary()
        {
            VocabularyName = "Blog Post";
            KeyPrefix = "commonDataModel.blogpost";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BlogPost;

            AddGroup("BlogPost Details for Portals", group =>
            {
			    BlogPostId = group.Add(new VocabularyKey(nameof(BlogPostId), "Blog Post", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommentPolicy = group.Add(new VocabularyKey(nameof(CommentPolicy), "Comment Policy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copy = group.Add(new VocabularyKey(nameof(Copy), "Copy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By (IP Address)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By (Username)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EnableRatings = group.Add(new VocabularyKey(nameof(EnableRatings), "Enable Ratings", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By (IP Address)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By (Username)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PartialURL = group.Add(new VocabularyKey(nameof(PartialURL), "Partial URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Published = group.Add(new VocabularyKey(nameof(Published), "Published", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Summary = group.Add(new VocabularyKey(nameof(Summary), "Summary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="BlogId"/> to Vocab 'Blog.cdm.json/Blog' with Property 'BlogId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="AuthorId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BlogPostId"/> from Vocab 'InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="BlogPostId"/> from Vocab 'WebFile.cdm.json/WebFile' with Property 'BlogPostId'
            #endregion
        }

        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey BlogPostId { get; private set; }
        public VocabularyKey CommentPolicy { get; private set; }
        public VocabularyKey Copy { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey EnableRatings { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartialURL { get; private set; }
        public VocabularyKey Published { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Summary { get; private set; }
    }
}