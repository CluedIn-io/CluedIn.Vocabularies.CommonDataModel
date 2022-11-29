using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class PaymentAssetVocabulary : SimpleVocabulary
    {
        public PaymentAssetVocabulary()
        {
            VocabularyName = "Payment Asset";
            KeyPrefix = "commonDataModel.paymentasset.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/PaymentAsset";

            AddGroup("PaymentAsset Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AssetType = group.Add(new VocabularyKey(nameof(AssetType), "Asset Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookDate = group.Add(new VocabularyKey(nameof(BookDate), "Book Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentAssetCategory = group.Add(new VocabularyKey(nameof(PaymentAssetCategory), "Payment Asset Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentAssetId = group.Add(new VocabularyKey(nameof(PaymentAssetId), "Payment Asset", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentAssetSubcategory = group.Add(new VocabularyKey(nameof(PaymentAssetSubcategory), "Payment Asset Subcategory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Symbol = group.Add(new VocabularyKey(nameof(Symbol), "Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey AssetType { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentAssetCategory { get; private set; }
        public VocabularyKey PaymentAssetId { get; private set; }
        public VocabularyKey PaymentAssetSubcategory { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Symbol { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}