using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class PropertyInstanceVocabulary : SimpleVocabulary
    {
        public PropertyInstanceVocabulary()
        {
            VocabularyName = "Property Instance";
            KeyPrefix = "commonDataModel.propertyinstance.foundationcommon";
            KeySeparator = ".";
            Grouping = "/PropertyInstance";

            AddGroup("PropertyInstance Details for FoundationCommon", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueInteger = group.Add(new VocabularyKey(nameof(ValueInteger), "Integer Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueDecimal = group.Add(new VocabularyKey(nameof(ValueDecimal), "Decimal Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueDouble = group.Add(new VocabularyKey(nameof(ValueDouble), "Double Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueString = group.Add(new VocabularyKey(nameof(ValueString), "String Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsValid = group.Add(new VocabularyKey(nameof(IsValid), "Is Valid", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ValueInteger { get; private set; }
        public VocabularyKey ValueDecimal { get; private set; }
        public VocabularyKey ValueDouble { get; private set; }
        public VocabularyKey ValueString { get; private set; }
        public VocabularyKey IsValid { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}