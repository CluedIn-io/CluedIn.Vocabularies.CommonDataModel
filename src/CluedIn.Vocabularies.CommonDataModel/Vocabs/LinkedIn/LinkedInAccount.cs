using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInAccountVocabulary : SimpleVocabulary
    {
        public LinkedInAccountVocabulary()
        {
            VocabularyName = "Linked In Account";
            KeyPrefix = "commonDataModel.linkedinaccount";
            KeySeparator = ".";
            Grouping = "/LinkedInAccount";

            AddGroup("LinkedInAccount Details", group =>
            {
                CampaignSyncStatus = group.Add(new VocabularyKey(nameof(CampaignSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Enabledforsync = group.Add(new VocabularyKey(nameof(Enabledforsync), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastcampaignsyncdate = group.Add(new VocabularyKey(nameof(Lastcampaignsyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastsyncdate = group.Add(new VocabularyKey(nameof(Lastsyncdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastsynctimestamprollup = group.Add(new VocabularyKey(nameof(Lastsynctimestamprollup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInAccountId = group.Add(new VocabularyKey(nameof(LinkedInAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInAccountTextId = group.Add(new VocabularyKey(nameof(LinkedInAccountTextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusDetails = group.Add(new VocabularyKey(nameof(StatusDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Syncstatus = group.Add(new VocabularyKey(nameof(Syncstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CampaignSyncStatus { get; private set; }
        public VocabularyKey Enabledforsync { get; private set; }
        public VocabularyKey Lastcampaignsyncdate { get; private set; }
        public VocabularyKey Lastsyncdate { get; private set; }
        public VocabularyKey Lastsynctimestamprollup { get; private set; }
        public VocabularyKey LinkedInAccountId { get; private set; }
        public VocabularyKey LinkedInAccountTextId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StatusDetails { get; private set; }
        public VocabularyKey Syncstatus { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}