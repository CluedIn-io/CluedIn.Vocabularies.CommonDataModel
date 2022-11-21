using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeInventTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeInventTableEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Invent Table Entity";
            KeyPrefix = "commonDataModel.dimattributeinventtableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeInventTableEntity";

            AddGroup("DimAttributeInventTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}