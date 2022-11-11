using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseMobileDeviceMenuEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuEntity";

            AddGroup("WHSWarehouseMobileDeviceMenuEntity Details", group =>
            {
                MenuName = group.Add(new VocabularyKey(nameof(MenuName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MenuDescription = group.Add(new VocabularyKey(nameof(MenuDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MenuName { get; private set; }
        public VocabularyKey MenuDescription { get; private set; }


    }
}