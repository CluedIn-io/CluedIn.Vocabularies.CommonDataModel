using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PowerBIConfigurationEntityVocabulary : SimpleVocabulary
    {
        public PowerBIConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PowerBIConfigurationEntity";
            KeyPrefix = "commonDataModel.powerbiconfigurationentity";
            KeySeparator = ".";
            Grouping = "/PowerBIConfigurationEntity";

            AddGroup("Common Data Model PowerBIConfigurationEntity Details", group =>
            {
                IsEnabled = group.Add(new VocabularyKey(nameof(IsEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AzureADAuthorityUri = group.Add(new VocabularyKey(nameof(AzureADAuthorityUri), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AzureADPowerBIApiResourceUri = group.Add(new VocabularyKey(nameof(AzureADPowerBIApiResourceUri), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenantID = group.Add(new VocabularyKey(nameof(TenantID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientID = group.Add(new VocabularyKey(nameof(ClientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicationKey = group.Add(new VocabularyKey(nameof(ApplicationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectUrl = group.Add(new VocabularyKey(nameof(RedirectUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PowerBIAPIAddress = group.Add(new VocabularyKey(nameof(PowerBIAPIAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplyTileFilter = group.Add(new VocabularyKey(nameof(ApplyTileFilter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TileFilterTableName = group.Add(new VocabularyKey(nameof(TileFilterTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TileFilterColumnName = group.Add(new VocabularyKey(nameof(TileFilterColumnName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsEnabled { get; private set; }
        public VocabularyKey AzureADAuthorityUri { get; private set; }
        public VocabularyKey AzureADPowerBIApiResourceUri { get; private set; }
        public VocabularyKey TenantID { get; private set; }
        public VocabularyKey ClientID { get; private set; }
        public VocabularyKey ApplicationKey { get; private set; }
        public VocabularyKey RedirectUrl { get; private set; }
        public VocabularyKey PowerBIAPIAddress { get; private set; }
        public VocabularyKey ApplyTileFilter { get; private set; }
        public VocabularyKey TileFilterTableName { get; private set; }
        public VocabularyKey TileFilterColumnName { get; private set; }


    }
}