using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxesMatrixEntityVocabulary : SimpleVocabulary
    {
        public TaxesMatrixEntityVocabulary()
        {
            VocabularyName = "Taxes Matrix Entity";
            KeyPrefix = "commonDataModel.taxesmatrixentity";
            KeySeparator = ".";
            Grouping = "/TaxesMatrixEntity";

            AddGroup("TaxesMatrixEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPGroupRecId = group.Add(new VocabularyKey(nameof(CFOPGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentGroupRecId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUsedForFreeTextInvoice = group.Add(new VocabularyKey(nameof(IsUsedForFreeTextInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUsedForServiceItems = group.Add(new VocabularyKey(nameof(IsUsedForServiceItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPGroupId = group.Add(new VocabularyKey(nameof(CFOPGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentGroupId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey CFOPGroupRecId { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey FiscalEstablishmentGroupRecId { get; private set; }
        public VocabularyKey IsUsedForFreeTextInvoice { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey IsUsedForServiceItems { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey CFOPGroupId { get; private set; }
        public VocabularyKey FiscalEstablishmentGroupId { get; private set; }
    }
}