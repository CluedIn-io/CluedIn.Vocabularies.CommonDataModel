using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeTaxBranchEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeTaxBranchEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Tax Branch Entity";
            KeyPrefix = "commonDataModel.dimattributetaxbranchentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeTaxBranchEntity";

            AddGroup("DimAttributeTaxBranchEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}