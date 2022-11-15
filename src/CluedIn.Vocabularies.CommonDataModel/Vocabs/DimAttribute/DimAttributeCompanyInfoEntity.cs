using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeCompanyInfoEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeCompanyInfoEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Company Info Entity";
            KeyPrefix = "commonDataModel.dimattributecompanyinfoentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeCompanyInfoEntity";

            AddGroup("DimAttributeCompanyInfoEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}