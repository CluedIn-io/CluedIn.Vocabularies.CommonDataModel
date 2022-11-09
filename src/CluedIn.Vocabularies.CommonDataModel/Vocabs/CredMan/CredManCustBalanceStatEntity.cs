using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCustBalanceStatEntityVocabulary : SimpleVocabulary
    {
        public CredManCustBalanceStatEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManCustBalanceStatEntity";
            KeyPrefix = "commonDataModel.credmancustbalancestatentity";
            KeySeparator = ".";
            Grouping = "/CredManCustBalanceStatEntity";

            AddGroup("Common Data Model CredManCustBalanceStatEntity Details", group =>
            {
                Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BalanceDate = group.Add(new VocabularyKey(nameof(BalanceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Exposure = group.Add(new VocabularyKey(nameof(Exposure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Balance { get; private set; }
public VocabularyKey BalanceDate { get; private set; }
public VocabularyKey CreditLimit { get; private set; }
public VocabularyKey CustAccount { get; private set; }
public VocabularyKey Exposure { get; private set; }


    }
}