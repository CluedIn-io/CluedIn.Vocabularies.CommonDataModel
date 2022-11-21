using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeInventItemGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeInventItemGroupEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Invent Item Group Entity";
            KeyPrefix = "commonDataModel.dimattributeinventitemgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeInventItemGroupEntity";

            AddGroup("DimAttributeInventItemGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}