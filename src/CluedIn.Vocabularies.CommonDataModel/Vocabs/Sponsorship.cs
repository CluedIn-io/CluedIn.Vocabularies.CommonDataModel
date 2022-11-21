using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SponsorshipVocabulary : SimpleVocabulary
    {
        public SponsorshipVocabulary()
        {
            VocabularyName = "Sponsorship";
            KeyPrefix = "commonDataModel.sponsorship";
            KeySeparator = ".";
            Grouping = "/Sponsorship";

            AddGroup("Sponsorship Details", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SponsorshipAmount = group.Add(new VocabularyKey(nameof(SponsorshipAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SponsorshipAmountBase = group.Add(new VocabularyKey(nameof(SponsorshipAmountBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SponsorshipCategory = group.Add(new VocabularyKey(nameof(SponsorshipCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SponsorshipId = group.Add(new VocabularyKey(nameof(SponsorshipId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SponsorshipType = group.Add(new VocabularyKey(nameof(SponsorshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SponsorshipAmount { get; private set; }
        public VocabularyKey SponsorshipAmountBase { get; private set; }
        public VocabularyKey SponsorshipCategory { get; private set; }
        public VocabularyKey SponsorshipId { get; private set; }
        public VocabularyKey SponsorshipType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}