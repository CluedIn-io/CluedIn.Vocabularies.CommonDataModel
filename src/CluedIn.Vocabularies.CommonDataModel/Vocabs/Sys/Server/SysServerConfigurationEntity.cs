using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysServerConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SysServerConfigurationEntityVocabulary()
        {
            VocabularyName = "Sys Server Configuration Entity";
            KeyPrefix = "commonDataModel.sysserverconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SysServerConfigurationEntity";

            AddGroup("SysServerConfigurationEntity Details", group =>
            {
                AOSInstanceName = group.Add(new VocabularyKey(nameof(AOSInstanceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AzureDeploymentId = group.Add(new VocabularyKey(nameof(AzureDeploymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceToAClusterName = group.Add(new VocabularyKey(nameof(ReferenceToAClusterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchServer = group.Add(new VocabularyKey(nameof(IsBatchServer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoleIdle = group.Add(new VocabularyKey(nameof(IsRoleIdle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadBalancer = group.Add(new VocabularyKey(nameof(LoadBalancer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxConcurrentSessions = group.Add(new VocabularyKey(nameof(MaxConcurrentSessions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServerGUID = group.Add(new VocabularyKey(nameof(ServerGUID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAlive = group.Add(new VocabularyKey(nameof(TimeAlive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClusterName = group.Add(new VocabularyKey(nameof(ClusterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AOSInstanceName { get; private set; }
        public VocabularyKey AzureDeploymentId { get; private set; }
        public VocabularyKey ReferenceToAClusterName { get; private set; }
        public VocabularyKey IsBatchServer { get; private set; }
        public VocabularyKey IsRoleIdle { get; private set; }
        public VocabularyKey LoadBalancer { get; private set; }
        public VocabularyKey MaxConcurrentSessions { get; private set; }
        public VocabularyKey ServerGUID { get; private set; }
        public VocabularyKey TimeAlive { get; private set; }
        public VocabularyKey ClusterName { get; private set; }
    }
}