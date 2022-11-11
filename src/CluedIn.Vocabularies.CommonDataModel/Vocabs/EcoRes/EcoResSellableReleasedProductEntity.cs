using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResSellableReleasedProductEntityVocabulary : SimpleVocabulary
    {
        public EcoResSellableReleasedProductEntityVocabulary()
        {
            VocabularyName = "EcoResSellableReleasedProductEntity";
            KeyPrefix = "commonDataModel.ecoressellablereleasedproductentity";
            KeySeparator = ".";
            Grouping = "/EcoResSellableReleasedProductEntity";

            AddGroup("EcoResSellableReleasedProductEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitDecimalPrecision = group.Add(new VocabularyKey(nameof(SalesUnitDecimalPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStockedProduct = group.Add(new VocabularyKey(nameof(IsStockedProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesStopped = group.Add(new VocabularyKey(nameof(IsSalesStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCost = group.Add(new VocabularyKey(nameof(UnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldServiceProductType = group.Add(new VocabularyKey(nameof(FieldServiceProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitDecimalPrecision = group.Add(new VocabularyKey(nameof(InventoryUnitDecimalPrecision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnitSymbol = group.Add(new VocabularyKey(nameof(InventoryUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey SalesUnitDecimalPrecision { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey IsStockedProduct { get; private set; }
        public VocabularyKey IsSalesStopped { get; private set; }
        public VocabularyKey UnitCost { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey FieldServiceProductType { get; private set; }
        public VocabularyKey InventoryUnitDecimalPrecision { get; private set; }
        public VocabularyKey InventoryUnitSymbol { get; private set; }


    }
}