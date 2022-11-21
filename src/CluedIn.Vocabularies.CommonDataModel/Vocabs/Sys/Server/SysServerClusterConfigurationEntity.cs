using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysServerClusterConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SysServerClusterConfigurationEntityVocabulary()
        {
            VocabularyName = "Sys Server Cluster Configuration Entity";
            KeyPrefix = "commonDataModel.sysserverclusterconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SysServerClusterConfigurationEntity";

            AddGroup("SysServerClusterConfigurationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}