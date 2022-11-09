using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LandingPagesVocabulary : SimpleVocabulary
    {
        public LandingPagesVocabulary()
        {
            VocabularyName = "Common Data Model LandingPages";
            KeyPrefix = "commonDataModel.landingpages";
            KeySeparator = ".";
            Grouping = "/LandingPages";

            AddGroup("Common Data Model LandingPages Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactcampaignattribute = group.Add(new VocabularyKey(nameof(contactcampaignattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactEmailAttribute = group.Add(new VocabularyKey(nameof(contactEmailAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactmarketingformattribute = group.Add(new VocabularyKey(nameof(contactmarketingformattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactmarketingpageattribute = group.Add(new VocabularyKey(nameof(contactmarketingpageattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
@default = group.Add(new VocabularyKey(nameof(@default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
keepsuccessfulsubmissions = group.Add(new VocabularyKey(nameof(keepsuccessfulsubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
entityupdatebehavioronsubmit = group.Add(new VocabularyKey(nameof(entityupdatebehavioronsubmit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
allowsubmissiononlyforms = group.Add(new VocabularyKey(nameof(allowsubmissiononlyforms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
insertPrivacyBanner = group.Add(new VocabularyKey(nameof(insertPrivacyBanner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadCampaignAttribute = group.Add(new VocabularyKey(nameof(leadCampaignAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadContactAttribute = group.Add(new VocabularyKey(nameof(leadContactAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadEmailAttribute = group.Add(new VocabularyKey(nameof(leadEmailAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadmarketingformattribute = group.Add(new VocabularyKey(nameof(leadmarketingformattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadmarketingpageattribute = group.Add(new VocabularyKey(nameof(leadmarketingpageattribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingpageconfigurationId = group.Add(new VocabularyKey(nameof(marketingpageconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
privacyBannerText = group.Add(new VocabularyKey(nameof(privacyBannerText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
privacyPolicyLinkText = group.Add(new VocabularyKey(nameof(privacyPolicyLinkText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
privacyPolicyLinkURL = group.Add(new VocabularyKey(nameof(privacyPolicyLinkURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websitefilterPlaceholder = group.Add(new VocabularyKey(nameof(websitefilterPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websiteid = group.Add(new VocabularyKey(nameof(websiteid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websitelanguageid = group.Add(new VocabularyKey(nameof(websitelanguageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
parentwebpageid = group.Add(new VocabularyKey(nameof(parentwebpageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
portalintegrationtype = group.Add(new VocabularyKey(nameof(portalintegrationtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
portalInstallationStatus = group.Add(new VocabularyKey(nameof(portalInstallationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
organizationtypeLastrefresh = group.Add(new VocabularyKey(nameof(organizationtypeLastrefresh), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
organizationType = group.Add(new VocabularyKey(nameof(organizationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey createdOn { get; private set; }
public VocabularyKey createdOnBehalfBy { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey modifiedOnBehalfBy { get; private set; }
public VocabularyKey contactcampaignattribute { get; private set; }
public VocabularyKey contactEmailAttribute { get; private set; }
public VocabularyKey contactmarketingformattribute { get; private set; }
public VocabularyKey contactmarketingpageattribute { get; private set; }
public VocabularyKey @default { get; private set; }
public VocabularyKey keepsuccessfulsubmissions { get; private set; }
public VocabularyKey entityupdatebehavioronsubmit { get; private set; }
public VocabularyKey allowsubmissiononlyforms { get; private set; }
public VocabularyKey insertPrivacyBanner { get; private set; }
public VocabularyKey leadCampaignAttribute { get; private set; }
public VocabularyKey leadContactAttribute { get; private set; }
public VocabularyKey leadEmailAttribute { get; private set; }
public VocabularyKey leadmarketingformattribute { get; private set; }
public VocabularyKey leadmarketingpageattribute { get; private set; }
public VocabularyKey marketingpageconfigurationId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey privacyBannerText { get; private set; }
public VocabularyKey privacyPolicyLinkText { get; private set; }
public VocabularyKey privacyPolicyLinkURL { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey websitefilterPlaceholder { get; private set; }
public VocabularyKey websiteid { get; private set; }
public VocabularyKey websitelanguageid { get; private set; }
public VocabularyKey parentwebpageid { get; private set; }
public VocabularyKey portalintegrationtype { get; private set; }
public VocabularyKey portalInstallationStatus { get; private set; }
public VocabularyKey organizationtypeLastrefresh { get; private set; }
public VocabularyKey organizationType { get; private set; }


    }
}