using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.LinkedInLeads
{
    public class LinkedInAccountVocabulary : SimpleVocabulary
    {
        public LinkedInAccountVocabulary()
        {
            VocabularyName = "Linked In Account";
            KeyPrefix = "commonDataModel.linkedinaccount.linkedinleads";
            KeySeparator = ".";
            Grouping = "/LinkedInAccount";

            AddGroup("LinkedInAccount Details for LinkedInLeads", group =>
            {
			    LinkedInAccountID = group.Add(new VocabularyKey(nameof(LinkedInAccountID), "LinkedIn Account", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CampaignSyncStatus = group.Add(new VocabularyKey(nameof(CampaignSyncStatus), "Campaign sync status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SyncEnabled = group.Add(new VocabularyKey(nameof(SyncEnabled), "Sync enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastCampaignSyncDate = group.Add(new VocabularyKey(nameof(LastCampaignSyncDate), "Last Campaign Sync Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastFormSyncDate = group.Add(new VocabularyKey(nameof(LastFormSyncDate), "Last Form Sync Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInAccountTextID = group.Add(new VocabularyKey(nameof(LinkedInAccountTextID), "LinkedIn Account Text ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusDetails = group.Add(new VocabularyKey(nameof(StatusDetails), "Status Details", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FormSyncStatus = group.Add(new VocabularyKey(nameof(FormSyncStatus), "Form sync status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastSync = group.Add(new VocabularyKey(nameof(LastSync), "Last sync", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastsynctimestamprollupDate = group.Add(new VocabularyKey(nameof(LastsynctimestamprollupDate), "Last sync (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastsynctimestamprollupState = group.Add(new VocabularyKey(nameof(LastsynctimestamprollupState), "Last sync (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LinkedInAccountID { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CampaignSyncStatus { get; private set; }
        public VocabularyKey SyncEnabled { get; private set; }
        public VocabularyKey LastCampaignSyncDate { get; private set; }
        public VocabularyKey LastFormSyncDate { get; private set; }
        public VocabularyKey LinkedInAccountTextID { get; private set; }
        public VocabularyKey StatusDetails { get; private set; }
        public VocabularyKey FormSyncStatus { get; private set; }
        public VocabularyKey LastSync { get; private set; }
        public VocabularyKey LastsynctimestamprollupDate { get; private set; }
        public VocabularyKey LastsynctimestamprollupState { get; private set; }
    }
}