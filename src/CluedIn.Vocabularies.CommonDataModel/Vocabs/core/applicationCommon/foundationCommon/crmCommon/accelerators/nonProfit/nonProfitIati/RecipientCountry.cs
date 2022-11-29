using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class RecipientCountryVocabulary : SimpleVocabulary
    {
        public RecipientCountryVocabulary()
        {
            VocabularyName = "Recipient Country";
            KeyPrefix = "commonDataModel.recipientcountry.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/RecipientCountry";

            AddGroup("RecipientCountry Details for NonProfitIati", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Percentage = group.Add(new VocabularyKey(nameof(Percentage), "Percentage", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Msiati_RecipientCountryId = group.Add(new VocabularyKey(nameof(Msiati_RecipientCountryId), "Recipient Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Percentage { get; private set; }
        public VocabularyKey Msiati_RecipientCountryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}