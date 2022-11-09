using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMFundCustomerEntityVocabulary : SimpleVocabulary
    {
        public TAMFundCustomerEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMFundCustomerEntity";
            KeyPrefix = "commonDataModel.tamfundcustomerentity";
            KeySeparator = ".";
            Grouping = "/TAMFundCustomerEntity";

            AddGroup("Common Data Model TAMFundCustomerEntity Details", group =>
            {
                FundId = group.Add(new VocabularyKey(nameof(FundId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FundId { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}