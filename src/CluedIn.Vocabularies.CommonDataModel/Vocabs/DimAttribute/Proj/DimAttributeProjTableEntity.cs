using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeProjTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeProjTableEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Proj Table Entity";
            KeyPrefix = "commonDataModel.dimattributeprojtableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeProjTableEntity";

            AddGroup("DimAttributeProjTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}