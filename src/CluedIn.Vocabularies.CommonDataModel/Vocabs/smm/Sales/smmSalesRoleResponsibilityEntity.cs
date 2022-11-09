using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalesRoleResponsibilityEntityVocabulary : SimpleVocabulary
    {
        public smmSalesRoleResponsibilityEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmSalesRoleResponsibilityEntity";
            KeyPrefix = "commonDataModel.smmsalesroleresponsibilityentity";
            KeySeparator = ".";
            Grouping = "/smmSalesRoleResponsibilityEntity";

            AddGroup("Common Data Model smmSalesRoleResponsibilityEntity Details", group =>
            {
                ResponsibilityDescription = group.Add(new VocabularyKey(nameof(ResponsibilityDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasProspectResponsibility = group.Add(new VocabularyKey(nameof(HasProspectResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasCallListResponsibility = group.Add(new VocabularyKey(nameof(HasCallListResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasCampaignResponsibility = group.Add(new VocabularyKey(nameof(HasCampaignResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasCaseResponsibility = group.Add(new VocabularyKey(nameof(HasCaseResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasCustomerResponsibility = group.Add(new VocabularyKey(nameof(HasCustomerResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasLeadResponsibility = group.Add(new VocabularyKey(nameof(HasLeadResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasOpportunityResponsibility = group.Add(new VocabularyKey(nameof(HasOpportunityResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasSalesUnitResponsibility = group.Add(new VocabularyKey(nameof(HasSalesUnitResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HasVendorResponsibility = group.Add(new VocabularyKey(nameof(HasVendorResponsibility), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResponsibilityCode = group.Add(new VocabularyKey(nameof(ResponsibilityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ResponsibilityDescription { get; private set; }
public VocabularyKey HasProspectResponsibility { get; private set; }
public VocabularyKey HasCallListResponsibility { get; private set; }
public VocabularyKey HasCampaignResponsibility { get; private set; }
public VocabularyKey HasCaseResponsibility { get; private set; }
public VocabularyKey HasCustomerResponsibility { get; private set; }
public VocabularyKey HasLeadResponsibility { get; private set; }
public VocabularyKey HasOpportunityResponsibility { get; private set; }
public VocabularyKey HasSalesUnitResponsibility { get; private set; }
public VocabularyKey HasVendorResponsibility { get; private set; }
public VocabularyKey ResponsibilityCode { get; private set; }


    }
}