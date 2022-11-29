using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class SponsorshipVocabulary : SimpleVocabulary
    {
        public SponsorshipVocabulary()
        {
            VocabularyName = "Sponsorship";
            KeyPrefix = "commonDataModel.sponsorship.eventmanagement";
            KeySeparator = ".";
            Grouping = "/Sponsorship";

            AddGroup("Sponsorship Details for EventManagement", group =>
            {
			    SponsorshipId = group.Add(new VocabularyKey(nameof(SponsorshipId), "Sponsorship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SponsorshipAmount = group.Add(new VocabularyKey(nameof(SponsorshipAmount), "Sponsorship Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SponsorshipAmountBase = group.Add(new VocabularyKey(nameof(SponsorshipAmountBase), "Sponsorship Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SponsorshipCategory = group.Add(new VocabularyKey(nameof(SponsorshipCategory), "Sponsorship Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SponsorshipType = group.Add(new VocabularyKey(nameof(SponsorshipType), "Sponsorship Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SponsorshipId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey SponsorshipAmount { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SponsorshipAmountBase { get; private set; }
        public VocabularyKey SponsorshipCategory { get; private set; }
        public VocabularyKey SponsorshipType { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
    }
}