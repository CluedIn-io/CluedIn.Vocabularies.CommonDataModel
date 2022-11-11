using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeVendGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeVendGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeVendGroupEntity";
            KeyPrefix = "commonDataModel.dimattributevendgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeVendGroupEntity";

            AddGroup("Common Data Model DimAttributeVendGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}