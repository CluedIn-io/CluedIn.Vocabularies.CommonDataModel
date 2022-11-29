using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class CurrencyVocabulary : SimpleVocabulary
    {
        public CurrencyVocabulary()
        {
            VocabularyName = "Currency";
            KeyPrefix = "commonDataModel.currency.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Currency";

            AddGroup("Currency Details for ApplicationCommon", group =>
            {
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Transaction Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CurrencySymbol = group.Add(new VocabularyKey(nameof(CurrencySymbol), "Currency Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CurrencyName = group.Add(new VocabularyKey(nameof(CurrencyName), "Currency Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ISOCurrencyCode = group.Add(new VocabularyKey(nameof(ISOCurrencyCode), "Currency Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CurrencyPrecision = group.Add(new VocabularyKey(nameof(CurrencyPrecision), "Currency Precision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CurrencySymbol { get; private set; }
        public VocabularyKey CurrencyName { get; private set; }
        public VocabularyKey ISOCurrencyCode { get; private set; }
        public VocabularyKey CurrencyPrecision { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
    }
}