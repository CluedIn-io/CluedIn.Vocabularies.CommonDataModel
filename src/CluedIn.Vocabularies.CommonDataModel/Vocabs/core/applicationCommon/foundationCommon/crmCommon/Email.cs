using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class EmailVocabulary : SimpleVocabulary
    {
        public EmailVocabulary()
        {
            VocabularyName = "Email";
            KeyPrefix = "commonDataModel.email.crmcommon";
            KeySeparator = ".";
            Grouping = "/Email";

            AddGroup("Email Details for CrmCommon", group =>
            {
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BCC = group.Add(new VocabularyKey(nameof(BCC), "Bcc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CC = group.Add(new VocabularyKey(nameof(CC), "Cc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey To { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey CC { get; private set; }
    }
}