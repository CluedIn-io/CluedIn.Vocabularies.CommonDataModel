using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WaitlistItemVocabulary : SimpleVocabulary
    {
        public WaitlistItemVocabulary()
        {
            VocabularyName = "Common Data Model WaitlistItem";
            KeyPrefix = "commonDataModel.waitlistitem";
            KeySeparator = ".";
            Grouping = "/WaitlistItem";

            AddGroup("Common Data Model WaitlistItem Details", group =>
            {
                autoregister = group.Add(new VocabularyKey(nameof(autoregister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
invited = group.Add(new VocabularyKey(nameof(invited), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
reserved = group.Add(new VocabularyKey(nameof(reserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
waitlistItemId = group.Add(new VocabularyKey(nameof(waitlistItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey autoregister { get; private set; }
public VocabularyKey invited { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey reserved { get; private set; }
public VocabularyKey waitlistItemId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}