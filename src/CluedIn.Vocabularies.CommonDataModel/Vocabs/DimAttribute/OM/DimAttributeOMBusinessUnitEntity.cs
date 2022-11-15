using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeOMBusinessUnitEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeOMBusinessUnitEntityVocabulary()
        {
            VocabularyName = "Dim Attribute OM Business Unit Entity";
            KeyPrefix = "commonDataModel.dimattributeombusinessunitentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeOMBusinessUnitEntity";

            AddGroup("DimAttributeOMBusinessUnitEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}