using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SponsorshipVocabulary : SimpleVocabulary
    {
        public SponsorshipVocabulary()
        {
            VocabularyName = "Common Data Model Sponsorship";
            KeyPrefix = "commonDataModel.sponsorship";
            KeySeparator = ".";
            Grouping = "/Sponsorship";

            AddGroup("Common Data Model Sponsorship Details", group =>
            {
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sponsorshipAmount = group.Add(new VocabularyKey(nameof(sponsorshipAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sponsorshipAmountBase = group.Add(new VocabularyKey(nameof(sponsorshipAmountBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sponsorshipCategory = group.Add(new VocabularyKey(nameof(sponsorshipCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sponsorshipId = group.Add(new VocabularyKey(nameof(sponsorshipId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sponsorshipType = group.Add(new VocabularyKey(nameof(sponsorshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey entityImage { get; private set; }
        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey sponsorshipAmount { get; private set; }
        public VocabularyKey sponsorshipAmountBase { get; private set; }
        public VocabularyKey sponsorshipCategory { get; private set; }
        public VocabularyKey sponsorshipId { get; private set; }
        public VocabularyKey sponsorshipType { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}