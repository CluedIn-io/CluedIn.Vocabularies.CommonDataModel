using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class LetterVocabulary : SimpleVocabulary
    {
        public LetterVocabulary()
        {
            VocabularyName = "Letter";
            KeyPrefix = "commonDataModel.letter.crmcommon";
            KeySeparator = ".";
            Grouping = "/Letter";

            AddGroup("Letter Details for CrmCommon", group =>
            {
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BCC = group.Add(new VocabularyKey(nameof(BCC), "Bcc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CC = group.Add(new VocabularyKey(nameof(CC), "Cc", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey From { get; private set; }
        public VocabularyKey BCC { get; private set; }
        public VocabularyKey CC { get; private set; }
        public VocabularyKey To { get; private set; }
    }
}