using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class FaxVocabulary : SimpleVocabulary
    {
        public FaxVocabulary()
        {
            VocabularyName = "Fax";
            KeyPrefix = "commonDataModel.fax.crmcommon";
            KeySeparator = ".";
            Grouping = "/Fax";

            AddGroup("Fax Details for CrmCommon", group =>
            {
			    To = group.Add(new VocabularyKey(nameof(To), "To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey To { get; private set; }
        public VocabularyKey From { get; private set; }
    }
}