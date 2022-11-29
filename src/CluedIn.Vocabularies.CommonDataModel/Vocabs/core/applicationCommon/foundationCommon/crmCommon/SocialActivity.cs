using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class SocialActivityVocabulary : SimpleVocabulary
    {
        public SocialActivityVocabulary()
        {
            VocabularyName = "Social Activity";
            KeyPrefix = "commonDataModel.socialactivity.crmcommon";
            KeySeparator = ".";
            Grouping = "/SocialActivity";

            AddGroup("SocialActivity Details for CrmCommon", group =>
            {
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Resources = group.Add(new VocabularyKey(nameof(Resources), "Resources", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey From { get; private set; }
        public VocabularyKey Resources { get; private set; }
        public VocabularyKey To { get; private set; }
    }
}