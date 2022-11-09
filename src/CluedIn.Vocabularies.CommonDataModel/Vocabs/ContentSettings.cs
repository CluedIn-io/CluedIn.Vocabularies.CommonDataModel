using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ContentSettingsVocabulary : SimpleVocabulary
    {
        public ContentSettingsVocabulary()
        {
            VocabularyName = "Common Data Model ContentSettings";
            KeyPrefix = "commonDataModel.contentsettings";
            KeySeparator = ".";
            Grouping = "/ContentSettings";

            AddGroup("Common Data Model ContentSettings Details", group =>
            {
                addressLine2 = group.Add(new VocabularyKey(nameof(addressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressMain = group.Add(new VocabularyKey(nameof(addressMain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contentSettingsId = group.Add(new VocabularyKey(nameof(contentSettingsId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
@default = group.Add(new VocabularyKey(nameof(@default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
isbusinessunitdefault = group.Add(new VocabularyKey(nameof(isbusinessunitdefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
facebookURL = group.Add(new VocabularyKey(nameof(facebookURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
forwardToAFriend = group.Add(new VocabularyKey(nameof(forwardToAFriend), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
linkedInURL = group.Add(new VocabularyKey(nameof(linkedInURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
subscriptionCenter = group.Add(new VocabularyKey(nameof(subscriptionCenter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
twitterURL = group.Add(new VocabularyKey(nameof(twitterURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
instagramURL = group.Add(new VocabularyKey(nameof(instagramURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mediumURL = group.Add(new VocabularyKey(nameof(mediumURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
skypeURL = group.Add(new VocabularyKey(nameof(skypeURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
googlePlusURL = group.Add(new VocabularyKey(nameof(googlePlusURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
youTubeURL = group.Add(new VocabularyKey(nameof(youTubeURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey addressLine2 { get; private set; }
public VocabularyKey addressMain { get; private set; }
public VocabularyKey contentSettingsId { get; private set; }
public VocabularyKey @default { get; private set; }
public VocabularyKey isbusinessunitdefault { get; private set; }
public VocabularyKey facebookURL { get; private set; }
public VocabularyKey forwardToAFriend { get; private set; }
public VocabularyKey linkedInURL { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey subscriptionCenter { get; private set; }
public VocabularyKey twitterURL { get; private set; }
public VocabularyKey instagramURL { get; private set; }
public VocabularyKey mediumURL { get; private set; }
public VocabularyKey skypeURL { get; private set; }
public VocabularyKey googlePlusURL { get; private set; }
public VocabularyKey youTubeURL { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}