using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcessSessionVocabulary : SimpleVocabulary
    {
        public ProcessSessionVocabulary()
        {
            VocabularyName = "Common Data Model ProcessSession";
            KeyPrefix = "commonDataModel.processsession";
            KeySeparator = ".";
            Grouping = "/ProcessSession";

            AddGroup("Common Data Model ProcessSession Details", group =>
            {
                             
            });
        }

       

    }
}