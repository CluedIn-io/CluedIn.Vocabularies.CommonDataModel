using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostOperationalSiteFinancialDimensionLinkPolicyEntityVocabulary : SimpleVocabulary
    {
        public CostOperationalSiteFinancialDimensionLinkPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model CostOperationalSiteFinancialDimensionLinkPolicyEntity";
            KeyPrefix = "commonDataModel.costoperationalsitefinancialdimensionlinkpolicyentity";
            KeySeparator = ".";
            Grouping = "/CostOperationalSiteFinancialDimensionLinkPolicyEntity";

            AddGroup("Common Data Model CostOperationalSiteFinancialDimensionLinkPolicyEntity Details", group =>
            {
                LinkedFinancialDimensionRecId = group.Add(new VocabularyKey(nameof(LinkedFinancialDimensionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LinkedFinancialDimensionName = group.Add(new VocabularyKey(nameof(LinkedFinancialDimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LinkState = group.Add(new VocabularyKey(nameof(LinkState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LinkedFinancialDimensionRecId { get; private set; }
public VocabularyKey LinkedFinancialDimensionName { get; private set; }
public VocabularyKey LinkState { get; private set; }


    }
}