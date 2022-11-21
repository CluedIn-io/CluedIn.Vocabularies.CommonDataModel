using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeWrkCtrResourceGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeWrkCtrResourceGroupEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Wrk Ctr Resource Group Entity";
            KeyPrefix = "commonDataModel.dimattributewrkctrresourcegroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeWrkCtrResourceGroupEntity";

            AddGroup("DimAttributeWrkCtrResourceGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}