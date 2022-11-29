using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.eventmanagement";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for EventManagement", group =>
            {
			    HotelGroup = group.Add(new VocabularyKey(nameof(HotelGroup), "Hotel Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RentalCarProvider = group.Add(new VocabularyKey(nameof(RentalCarProvider), "Rental Car Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey HotelGroup { get; private set; }
        public VocabularyKey RentalCarProvider { get; private set; }
    }
}