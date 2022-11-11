using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeHcmWorkerEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeHcmWorkerEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeHcmWorkerEntity";
            KeyPrefix = "commonDataModel.dimattributehcmworkerentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeHcmWorkerEntity";

            AddGroup("Common Data Model DimAttributeHcmWorkerEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}