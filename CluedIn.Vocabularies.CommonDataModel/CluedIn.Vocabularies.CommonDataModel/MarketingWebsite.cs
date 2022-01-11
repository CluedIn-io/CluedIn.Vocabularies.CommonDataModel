using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingWebsiteVocabulary : SimpleVocabulary
    {
        public MarketingWebsiteVocabulary()
        {
            VocabularyName = "Common Data Model MarketingWebsite";
            KeyPrefix = "commonDataModel.marketingwebsite";
            KeySeparator = ".";
            Grouping = "/MarketingWebsite";

            AddGroup("Common Data Model MarketingWebsite Details", group =>
            {
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
insightsPlaceholder = group.Add(new VocabularyKey(nameof(insightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
javascriptcodeCompound = group.Add(new VocabularyKey(nameof(javascriptcodeCompound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
externalFormHostingCodeTemplate = group.Add(new VocabularyKey(nameof(externalFormHostingCodeTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
externalFormHostingIframeTemplate = group.Add(new VocabularyKey(nameof(externalFormHostingIframeTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
javaScriptCode = group.Add(new VocabularyKey(nameof(javaScriptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
capturingCode = group.Add(new VocabularyKey(nameof(capturingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
remoteWebsiteID = group.Add(new VocabularyKey(nameof(remoteWebsiteID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
shouldBeRemoved = group.Add(new VocabularyKey(nameof(shouldBeRemoved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeout = group.Add(new VocabularyKey(nameof(timeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websiteId = group.Add(new VocabularyKey(nameof(websiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
purpose = group.Add(new VocabularyKey(nameof(purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey description { get; private set; }
public VocabularyKey insightsPlaceholder { get; private set; }
public VocabularyKey javascriptcodeCompound { get; private set; }
public VocabularyKey externalFormHostingCodeTemplate { get; private set; }
public VocabularyKey externalFormHostingIframeTemplate { get; private set; }
public VocabularyKey javaScriptCode { get; private set; }
public VocabularyKey capturingCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey remoteWebsiteID { get; private set; }
public VocabularyKey shouldBeRemoved { get; private set; }
public VocabularyKey timeout { get; private set; }
public VocabularyKey URL { get; private set; }
public VocabularyKey websiteId { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey purpose { get; private set; }


    }
}