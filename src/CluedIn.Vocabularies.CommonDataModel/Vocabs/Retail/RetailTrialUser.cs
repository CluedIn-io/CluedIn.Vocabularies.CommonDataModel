using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTrialUserVocabulary : SimpleVocabulary
    {
        public RetailTrialUserVocabulary()
        {
            VocabularyName = "RetailTrialUser";
            KeyPrefix = "commonDataModel.retailtrialuser";
            KeySeparator = ".";
            Grouping = "/RetailTrialUser";

            AddGroup("RetailTrialUser Details", group =>
            {
                UserID = group.Add(new VocabularyKey(nameof(UserID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Alias = group.Add(new VocabularyKey(nameof(Alias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserName = group.Add(new VocabularyKey(nameof(UserName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetworkDomain = group.Add(new VocabularyKey(nameof(NetworkDomain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserInfo_language = group.Add(new VocabularyKey(nameof(UserInfo_language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Enabled = group.Add(new VocabularyKey(nameof(Enabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartitionKey = group.Add(new VocabularyKey(nameof(PartitionKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Helplanguage = group.Add(new VocabularyKey(nameof(Helplanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonName = group.Add(new VocabularyKey(nameof(PersonName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPartition = group.Add(new VocabularyKey(nameof(DefaultPartition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey UserID { get; private set; }
        public VocabularyKey Alias { get; private set; }
        public VocabularyKey UserName { get; private set; }
        public VocabularyKey NetworkDomain { get; private set; }
        public VocabularyKey UserInfo_language { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey Enabled { get; private set; }
        public VocabularyKey PartitionKey { get; private set; }
        public VocabularyKey Helplanguage { get; private set; }
        public VocabularyKey PersonName { get; private set; }
        public VocabularyKey DefaultPartition { get; private set; }


    }
}