using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSalesTaxOverrideGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailSalesTaxOverrideGroupEntityVocabulary()
        {
            VocabularyName = "Retail Sales Tax Override Group Entity";
            KeyPrefix = "commonDataModel.retailsalestaxoverridegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailSalesTaxOverrideGroupEntity";

            AddGroup("RetailSalesTaxOverrideGroupEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}