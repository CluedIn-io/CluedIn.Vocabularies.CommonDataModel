using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmLeadProcessingPolicyEntityVocabulary : SimpleVocabulary
    {
        public smmLeadProcessingPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmLeadProcessingPolicyEntity";
            KeyPrefix = "commonDataModel.smmleadprocessingpolicyentity";
            KeySeparator = ".";
            Grouping = "/smmLeadProcessingPolicyEntity";

            AddGroup("Common Data Model smmLeadProcessingPolicyEntity Details", group =>
            {
                WillLeadQualificationCreateOpportunity = group.Add(new VocabularyKey(nameof(WillLeadQualificationCreateOpportunity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillLeadQualificationCreateCustomer = group.Add(new VocabularyKey(nameof(WillLeadQualificationCreateCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WillLeadQualificationCreateOpportunity { get; private set; }
public VocabularyKey WillLeadQualificationCreateCustomer { get; private set; }


    }
}