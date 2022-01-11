using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Common Data Model Account";
            KeyPrefix = "commonDataModel.account";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Common Data Model Account Details", group =>
            {
                hotelGroup = group.Add(new VocabularyKey(nameof(hotelGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
rentalCarProvider = group.Add(new VocabularyKey(nameof(rentalCarProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey hotelGroup { get; private set; }
public VocabularyKey rentalCarProvider { get; private set; }


    }
}