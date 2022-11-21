using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details", group =>
            {
                HotelGroup = group.Add(new VocabularyKey(nameof(HotelGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RentalCarProvider = group.Add(new VocabularyKey(nameof(RentalCarProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey HotelGroup { get; private set; }
        public VocabularyKey RentalCarProvider { get; private set; }
    }
}