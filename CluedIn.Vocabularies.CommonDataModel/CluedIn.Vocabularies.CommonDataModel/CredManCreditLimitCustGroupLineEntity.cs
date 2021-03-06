using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCreditLimitCustGroupLineEntityVocabulary : SimpleVocabulary
    {
        public CredManCreditLimitCustGroupLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManCreditLimitCustGroupLineEntity";
            KeyPrefix = "commonDataModel.credmancreditlimitcustgrouplineentity";
            KeySeparator = ".";
            Grouping = "/CredManCreditLimitCustGroupLineEntity";

            AddGroup("Common Data Model CredManCreditLimitCustGroupLineEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditLimitId = group.Add(new VocabularyKey(nameof(CreditLimitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Company { get; private set; }
public VocabularyKey CustAccount { get; private set; }
public VocabularyKey CreditLimitId { get; private set; }


    }
}