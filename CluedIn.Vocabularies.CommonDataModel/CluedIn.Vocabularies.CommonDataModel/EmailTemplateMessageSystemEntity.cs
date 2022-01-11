using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmailTemplateMessageSystemEntityVocabulary : SimpleVocabulary
    {
        public EmailTemplateMessageSystemEntityVocabulary()
        {
            VocabularyName = "Common Data Model EmailTemplateMessageSystemEntity";
            KeyPrefix = "commonDataModel.emailtemplatemessagesystementity";
            KeySeparator = ".";
            Grouping = "/EmailTemplateMessageSystemEntity";

            AddGroup("Common Data Model EmailTemplateMessageSystemEntity Details", group =>
            {
                EmailId = group.Add(new VocabularyKey(nameof(EmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Layout = group.Add(new VocabularyKey(nameof(Layout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Subject = group.Add(new VocabularyKey(nameof(Subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
XSLTTransform = group.Add(new VocabularyKey(nameof(XSLTTransform), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmailTemplateString = group.Add(new VocabularyKey(nameof(EmailTemplateString), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EmailId { get; private set; }
public VocabularyKey Language { get; private set; }
public VocabularyKey Layout { get; private set; }
public VocabularyKey Email { get; private set; }
public VocabularyKey Subject { get; private set; }
public VocabularyKey XSLTTransform { get; private set; }
public VocabularyKey EmailTemplateString { get; private set; }


    }
}