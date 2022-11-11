using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCustomWarehouseWorkTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSCustomWarehouseWorkTypeEntityVocabulary()
        {
            VocabularyName = "WHSCustomWarehouseWorkTypeEntity";
            KeyPrefix = "commonDataModel.whscustomwarehouseworktypeentity";
            KeySeparator = ".";
            Grouping = "/WHSCustomWarehouseWorkTypeEntity";

            AddGroup("WHSCustomWarehouseWorkTypeEntity Details", group =>
            {
                WillCustomWorkRequireDataInput = group.Add(new VocabularyKey(nameof(WillCustomWorkRequireDataInput), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MobileDeviceMenuLabel = group.Add(new VocabularyKey(nameof(MobileDeviceMenuLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkTypeCode = group.Add(new VocabularyKey(nameof(WorkTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkTypeDescription = group.Add(new VocabularyKey(nameof(WorkTypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomWorkTypeProcessorMethodName = group.Add(new VocabularyKey(nameof(CustomWorkTypeProcessorMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WillCustomWorkRequireDataInput { get; private set; }
        public VocabularyKey MobileDeviceMenuLabel { get; private set; }
        public VocabularyKey WorkTypeCode { get; private set; }
        public VocabularyKey WorkTypeDescription { get; private set; }
        public VocabularyKey CustomWorkTypeProcessorMethodName { get; private set; }


    }
}