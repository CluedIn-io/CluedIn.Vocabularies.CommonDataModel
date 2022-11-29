using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class UserVocabulary : SimpleVocabulary
    {
        public UserVocabulary()
        {
            VocabularyName = "User";
            KeyPrefix = "commonDataModel.user.projectcommon";
            KeySeparator = ".";
            Grouping = "/User";

            AddGroup("User Details for ProjectCommon", group =>
            {
			    GDPROptOut = group.Add(new VocabularyKey(nameof(GDPROptOut), "GDPR Optout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey GDPROptOut { get; private set; }
    }
}