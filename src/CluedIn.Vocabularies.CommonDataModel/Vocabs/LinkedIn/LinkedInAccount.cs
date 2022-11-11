using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInAccountVocabulary : SimpleVocabulary
    {
        public LinkedInAccountVocabulary()
        {
            VocabularyName = "LinkedInAccount";
            KeyPrefix = "commonDataModel.linkedinaccount";
            KeySeparator = ".";
            Grouping = "/LinkedInAccount";

            AddGroup("LinkedInAccount Details", group =>
            {
                campaignSyncStatus = group.Add(new VocabularyKey(nameof(campaignSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                enabledforsync = group.Add(new VocabularyKey(nameof(enabledforsync), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastcampaignsyncdate = group.Add(new VocabularyKey(nameof(lastcampaignsyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastsyncdate = group.Add(new VocabularyKey(nameof(lastsyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastsynctimestamprollup = group.Add(new VocabularyKey(nameof(lastsynctimestamprollup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInAccountId = group.Add(new VocabularyKey(nameof(linkedInAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInAccountTextId = group.Add(new VocabularyKey(nameof(linkedInAccountTextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusDetails = group.Add(new VocabularyKey(nameof(statusDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                syncstatus = group.Add(new VocabularyKey(nameof(syncstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey campaignSyncStatus { get; private set; }
        public VocabularyKey enabledforsync { get; private set; }
        public VocabularyKey lastcampaignsyncdate { get; private set; }
        public VocabularyKey lastsyncdate { get; private set; }
        public VocabularyKey lastsynctimestamprollup { get; private set; }
        public VocabularyKey linkedInAccountId { get; private set; }
        public VocabularyKey linkedInAccountTextId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey statusDetails { get; private set; }
        public VocabularyKey syncstatus { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}