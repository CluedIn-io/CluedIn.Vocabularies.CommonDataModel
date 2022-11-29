using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitVolunteers
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.nonprofitvolunteers";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for NonProfitVolunteers", group =>
            {
			    PrimaryConstituentType = group.Add(new VocabularyKey(nameof(PrimaryConstituentType), "Primary Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PrimaryConstituentType { get; private set; }
    }
}