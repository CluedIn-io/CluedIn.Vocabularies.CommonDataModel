using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class ArticleVocabulary : SimpleVocabulary
    {
        public ArticleVocabulary()
        {
            VocabularyName = "Article";
            KeyPrefix = "commonDataModel.article.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Article";

            AddGroup("Article Details for ApplicationCommon", group =>
            {
			    KbArticleId = group.Add(new VocabularyKey(nameof(KbArticleId), "Article", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ArticleXml = group.Add(new VocabularyKey(nameof(ArticleXml), "Article XML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Number = group.Add(new VocabularyKey(nameof(Number), "Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Content = group.Add(new VocabularyKey(nameof(Content), "Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KeyWords = group.Add(new VocabularyKey(nameof(KeyWords), "Key Words", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey KbArticleId { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey ArticleXml { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey Content { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey KeyWords { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey LanguageCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
    }
}