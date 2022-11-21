using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesQuotationTemplateGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesQuotationTemplateGroupEntityVocabulary()
        {
            VocabularyName = "Sales Quotation Template Group Entity";
            KeyPrefix = "commonDataModel.salesquotationtemplategroupentity";
            KeySeparator = ".";
            Grouping = "/SalesQuotationTemplateGroupEntity";

            AddGroup("SalesQuotationTemplateGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}