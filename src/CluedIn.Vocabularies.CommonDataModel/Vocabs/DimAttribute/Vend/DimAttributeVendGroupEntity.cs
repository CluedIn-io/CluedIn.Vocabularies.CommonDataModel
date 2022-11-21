using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeVendGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeVendGroupEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Vend Group Entity";
            KeyPrefix = "commonDataModel.dimattributevendgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeVendGroupEntity";

            AddGroup("DimAttributeVendGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}