using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class SpecificationAccessoryVocabulary : SimpleVocabulary
    {
        public SpecificationAccessoryVocabulary()
        {
            VocabularyName = "Specification Accessory";
            KeyPrefix = "commonDataModel.specificationaccessory.automotive";
            KeySeparator = ".";
            Grouping = "/SpecificationAccessory";

            AddGroup("SpecificationAccessory Details for Automotive", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalCode = group.Add(new VocabularyKey(nameof(ExternalCode), "External Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), "Sales Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SalesPriceBase = group.Add(new VocabularyKey(nameof(SalesPriceBase), "Sales Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    SpecificationAccessoryId = group.Add(new VocabularyKey(nameof(SpecificationAccessoryId), "Specification Accessory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExternalCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesPriceBase { get; private set; }
        public VocabularyKey SpecificationAccessoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}