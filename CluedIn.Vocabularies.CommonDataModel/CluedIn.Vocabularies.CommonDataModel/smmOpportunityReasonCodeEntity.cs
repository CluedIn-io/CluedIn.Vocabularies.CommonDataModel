using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmOpportunityReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public smmOpportunityReasonCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmOpportunityReasonCodeEntity";
            KeyPrefix = "commonDataModel.smmopportunityreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/smmOpportunityReasonCodeEntity";

            AddGroup("Common Data Model smmOpportunityReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReasonDescription { get; private set; }
public VocabularyKey ReasonCode { get; private set; }


    }
}