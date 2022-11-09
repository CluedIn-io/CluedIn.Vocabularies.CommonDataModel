using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmCustomerContactPersonCDSEntityVocabulary : SimpleVocabulary
    {
        public smmCustomerContactPersonCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmCustomerContactPersonCDSEntity";
            KeyPrefix = "commonDataModel.smmcustomercontactpersoncdsentity";
            KeySeparator = ".";
            Grouping = "/smmCustomerContactPersonCDSEntity";

            AddGroup("Common Data Model smmCustomerContactPersonCDSEntity Details", group =>
            {
                ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ContactPersonPartyNumber { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}