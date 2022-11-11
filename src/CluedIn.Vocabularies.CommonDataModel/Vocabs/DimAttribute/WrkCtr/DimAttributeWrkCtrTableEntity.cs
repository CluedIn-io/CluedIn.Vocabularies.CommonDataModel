using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeWrkCtrTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeWrkCtrTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeWrkCtrTableEntity";
            KeyPrefix = "commonDataModel.dimattributewrkctrtableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeWrkCtrTableEntity";

            AddGroup("Common Data Model DimAttributeWrkCtrTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}