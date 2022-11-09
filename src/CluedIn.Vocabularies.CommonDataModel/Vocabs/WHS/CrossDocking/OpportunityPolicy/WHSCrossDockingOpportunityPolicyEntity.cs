using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCrossDockingOpportunityPolicyEntityVocabulary : SimpleVocabulary
    {
        public WHSCrossDockingOpportunityPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSCrossDockingOpportunityPolicyEntity";
            KeyPrefix = "commonDataModel.whscrossdockingopportunitypolicyentity";
            KeySeparator = ".";
            Grouping = "/WHSCrossDockingOpportunityPolicyEntity";

            AddGroup("Common Data Model WHSCrossDockingOpportunityPolicyEntity Details", group =>
            {
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyDescription = group.Add(new VocabularyKey(nameof(PolicyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PolicyName { get; private set; }
public VocabularyKey PolicyDescription { get; private set; }


    }
}