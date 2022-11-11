using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeOMBusinessUnitEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeOMBusinessUnitEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeOMBusinessUnitEntity";
            KeyPrefix = "commonDataModel.dimattributeombusinessunitentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeOMBusinessUnitEntity";

            AddGroup("Common Data Model DimAttributeOMBusinessUnitEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}