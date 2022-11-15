using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesQuotationTypeEntityVocabulary : SimpleVocabulary
    {
        public SalesQuotationTypeEntityVocabulary()
        {
            VocabularyName = "Sales Quotation Type Entity";
            KeyPrefix = "commonDataModel.salesquotationtypeentity";
            KeySeparator = ".";
            Grouping = "/SalesQuotationTypeEntity";

            AddGroup("SalesQuotationTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeDescription { get; private set; }
        public VocabularyKey TypeId { get; private set; }
    }
}