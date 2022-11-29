using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Sales
{
    public class OpportunityRelationshipVocabulary : SimpleVocabulary
    {
        public OpportunityRelationshipVocabulary()
        {
            VocabularyName = "Opportunity Relationship";
            KeyPrefix = "commonDataModel.opportunityrelationship.sales";
            KeySeparator = ".";
            Grouping = "/OpportunityRelationship";

            AddGroup("OpportunityRelationship Details for Sales", group =>
            {
			    CustomerOpportunityRoleId = group.Add(new VocabularyKey(nameof(CustomerOpportunityRoleId), "Opportunity Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpportunityRoleId = group.Add(new VocabularyKey(nameof(OpportunityRoleId), "Customer Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpportunityStateCode = group.Add(new VocabularyKey(nameof(OpportunityStateCode), "Opportunity Status", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpportunityStatusCode = group.Add(new VocabularyKey(nameof(OpportunityStatusCode), "Opportunity Status Reason", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CustomerOpportunityRoleId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OpportunityRoleId { get; private set; }
        public VocabularyKey OpportunityStateCode { get; private set; }
        public VocabularyKey OpportunityStatusCode { get; private set; }
    }
}