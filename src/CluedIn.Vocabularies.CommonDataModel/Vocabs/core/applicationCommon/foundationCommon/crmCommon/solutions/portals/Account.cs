using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.portals";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for Portals", group =>
            {
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By (IP Address)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By (User Name)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By (IP Address)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By (User Name)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
    }
}