using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SysServerClusterConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SysServerClusterConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SysServerClusterConfigurationEntity";
            KeyPrefix = "commonDataModel.sysserverclusterconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SysServerClusterConfigurationEntity";

            AddGroup("Common Data Model SysServerClusterConfigurationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}