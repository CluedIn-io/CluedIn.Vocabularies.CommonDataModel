using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationDirectiveFailureEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationDirectiveFailureEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseLocationDirectiveFailureEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationdirectivefailureentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationDirectiveFailureEntity";

            AddGroup("WHSWarehouseLocationDirectiveFailureEntity Details", group =>
            {
                WillLocationDirectiveFailureStopWork = group.Add(new VocabularyKey(nameof(WillLocationDirectiveFailureStopWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WillLocationDirectiveFailureStopWork { get; private set; }
        public VocabularyKey WorkOrderType { get; private set; }


    }
}