using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeCustTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeCustTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeCustTableEntity";
            KeyPrefix = "commonDataModel.dimattributecusttableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeCustTableEntity";

            AddGroup("Common Data Model DimAttributeCustTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}