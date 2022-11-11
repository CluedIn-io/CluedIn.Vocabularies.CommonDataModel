using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmOpportunityMaintenancePolicyEntityVocabulary : SimpleVocabulary
    {
        public smmOpportunityMaintenancePolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmOpportunityMaintenancePolicyEntity";
            KeyPrefix = "commonDataModel.smmopportunitymaintenancepolicyentity";
            KeySeparator = ".";
            Grouping = "/smmOpportunityMaintenancePolicyEntity";

            AddGroup("Common Data Model smmOpportunityMaintenancePolicyEntity Details", group =>
            {
                SalesQuotationOpportunityCreationRule = group.Add(new VocabularyKey(nameof(SalesQuotationOpportunityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesQuotationOpportunityModificationRule = group.Add(new VocabularyKey(nameof(SalesQuotationOpportunityModificationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectQuotationOpportunityCreationRule = group.Add(new VocabularyKey(nameof(ProjectQuotationOpportunityCreationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectQuotationOpportunityModificationRule = group.Add(new VocabularyKey(nameof(ProjectQuotationOpportunityModificationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesQuotationOpportunityCreationRule { get; private set; }
        public VocabularyKey SalesQuotationOpportunityModificationRule { get; private set; }
        public VocabularyKey ProjectQuotationOpportunityCreationRule { get; private set; }
        public VocabularyKey ProjectQuotationOpportunityModificationRule { get; private set; }


    }
}