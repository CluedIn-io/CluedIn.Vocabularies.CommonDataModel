using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingPageVocabulary : SimpleVocabulary
    {
        public MarketingPageVocabulary()
        {
            VocabularyName = "Common Data Model MarketingPage";
            KeyPrefix = "commonDataModel.marketingpage";
            KeySeparator = ".";
            Grouping = "/MarketingPage";

            AddGroup("Common Data Model MarketingPage Details", group =>
            {
                formToSave = group.Add(new VocabularyKey(nameof(formToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
content = group.Add(new VocabularyKey(nameof(content), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contentType = group.Add(new VocabularyKey(nameof(contentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
formPageMapping = group.Add(new VocabularyKey(nameof(formPageMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
alloweddomains = group.Add(new VocabularyKey(nameof(alloweddomains), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
fullPageURL = group.Add(new VocabularyKey(nameof(fullPageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
fullPageUrls = group.Add(new VocabularyKey(nameof(fullPageUrls), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
insightsPlaceholder = group.Add(new VocabularyKey(nameof(insightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingPageId = group.Add(new VocabularyKey(nameof(marketingPageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketType = group.Add(new VocabularyKey(nameof(marketType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
optimizedFor = group.Add(new VocabularyKey(nameof(optimizedFor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
partialURL = group.Add(new VocabularyKey(nameof(partialURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
purpose = group.Add(new VocabularyKey(nameof(purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
remoteWebsiteID = group.Add(new VocabularyKey(nameof(remoteWebsiteID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
visualStyle = group.Add(new VocabularyKey(nameof(visualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastPublishedDate = group.Add(new VocabularyKey(nameof(lastPublishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastUnpublishedDate = group.Add(new VocabularyKey(nameof(lastUnpublishedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingProvided = group.Add(new VocabularyKey(nameof(marketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
forcePortalLess = group.Add(new VocabularyKey(nameof(forcePortalLess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websitefilterPlaceholder = group.Add(new VocabularyKey(nameof(websitefilterPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
pagetemplateid = group.Add(new VocabularyKey(nameof(pagetemplateid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
parentwebpageid = group.Add(new VocabularyKey(nameof(parentwebpageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webtemplateid = group.Add(new VocabularyKey(nameof(webtemplateid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websiteid = group.Add(new VocabularyKey(nameof(websiteid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websitelanguageid = group.Add(new VocabularyKey(nameof(websitelanguageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
webpageid = group.Add(new VocabularyKey(nameof(webpageid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
iamlive = group.Add(new VocabularyKey(nameof(iamlive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey formToSave { get; private set; }
public VocabularyKey content { get; private set; }
public VocabularyKey contentType { get; private set; }
public VocabularyKey formPageMapping { get; private set; }
public VocabularyKey alloweddomains { get; private set; }
public VocabularyKey fullPageURL { get; private set; }
public VocabularyKey fullPageUrls { get; private set; }
public VocabularyKey insightsPlaceholder { get; private set; }
public VocabularyKey marketingPageId { get; private set; }
public VocabularyKey marketType { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey optimizedFor { get; private set; }
public VocabularyKey partialURL { get; private set; }
public VocabularyKey purpose { get; private set; }
public VocabularyKey remoteWebsiteID { get; private set; }
public VocabularyKey type { get; private set; }
public VocabularyKey visualStyle { get; private set; }
public VocabularyKey lastPublishedDate { get; private set; }
public VocabularyKey lastUnpublishedDate { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey marketingProvided { get; private set; }
public VocabularyKey forcePortalLess { get; private set; }
public VocabularyKey websitefilterPlaceholder { get; private set; }
public VocabularyKey pagetemplateid { get; private set; }
public VocabularyKey parentwebpageid { get; private set; }
public VocabularyKey webtemplateid { get; private set; }
public VocabularyKey websiteid { get; private set; }
public VocabularyKey websitelanguageid { get; private set; }
public VocabularyKey webpageid { get; private set; }
public VocabularyKey iamlive { get; private set; }


    }
}