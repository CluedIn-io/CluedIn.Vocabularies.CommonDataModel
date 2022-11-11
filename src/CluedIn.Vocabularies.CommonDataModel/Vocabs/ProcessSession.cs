using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcessSessionVocabulary : SimpleVocabulary
    {
        public ProcessSessionVocabulary()
        {
            VocabularyName = "ProcessSession";
            KeyPrefix = "commonDataModel.processsession";
            KeySeparator = ".";
            Grouping = "/ProcessSession";

            AddGroup("ProcessSession Details", group =>
            {

            });
        }



    }
}