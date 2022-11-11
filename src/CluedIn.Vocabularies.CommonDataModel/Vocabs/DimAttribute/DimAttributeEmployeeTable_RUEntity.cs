using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeEmployeeTable_RUEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeEmployeeTable_RUEntityVocabulary()
        {
            VocabularyName = "DimAttributeEmployeeTable_RUEntity";
            KeyPrefix = "commonDataModel.dimattributeemployeetable_ruentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeEmployeeTable_RUEntity";

            AddGroup("DimAttributeEmployeeTable_RUEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}