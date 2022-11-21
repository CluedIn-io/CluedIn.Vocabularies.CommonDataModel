using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeCustGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeCustGroupEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Cust Group Entity";
            KeyPrefix = "commonDataModel.dimattributecustgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeCustGroupEntity";

            AddGroup("DimAttributeCustGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}