using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BOMConfigurationGroupEntityVocabulary : SimpleVocabulary
    {
        public BOMConfigurationGroupEntityVocabulary()
        {
            VocabularyName = "BOMConfigurationGroupEntity";
            KeyPrefix = "commonDataModel.bomconfigurationgroupentity";
            KeySeparator = ".";
            Grouping = "/BOMConfigurationGroupEntity";

            AddGroup("BOMConfigurationGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}