using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for NonProfitCore", group =>
            {
			    Age = group.Add(new VocabularyKey(nameof(Age), "Age", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Anonymous = group.Add(new VocabularyKey(nameof(Anonymous), "Anonymous?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    BirthDay = group.Add(new VocabularyKey(nameof(BirthDay), "Birth Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BirthMonth = group.Add(new VocabularyKey(nameof(BirthMonth), "Birth Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BirthYear = group.Add(new VocabularyKey(nameof(BirthYear), "Birth Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ContactAccountNumber = group.Add(new VocabularyKey(nameof(ContactAccountNumber), "Contact Account Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Deceased = group.Add(new VocabularyKey(nameof(Deceased), "Deceased?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Ethnicity = group.Add(new VocabularyKey(nameof(Ethnicity), "Ethnicity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MaidenName = group.Add(new VocabularyKey(nameof(MaidenName), "Maiden Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryConstituentType = group.Add(new VocabularyKey(nameof(PrimaryConstituentType), "Primary Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Age { get; private set; }
        public VocabularyKey Anonymous { get; private set; }
        public VocabularyKey BirthDay { get; private set; }
        public VocabularyKey BirthMonth { get; private set; }
        public VocabularyKey BirthYear { get; private set; }
        public VocabularyKey ContactAccountNumber { get; private set; }
        public VocabularyKey Deceased { get; private set; }
        public VocabularyKey Ethnicity { get; private set; }
        public VocabularyKey MaidenName { get; private set; }
        public VocabularyKey PrimaryConstituentType { get; private set; }
    }
}