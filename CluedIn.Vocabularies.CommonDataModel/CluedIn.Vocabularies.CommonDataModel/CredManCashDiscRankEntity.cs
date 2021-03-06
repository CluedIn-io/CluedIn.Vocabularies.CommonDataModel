using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCashDiscRankEntityVocabulary : SimpleVocabulary
    {
        public CredManCashDiscRankEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManCashDiscRankEntity";
            KeyPrefix = "commonDataModel.credmancashdiscrankentity";
            KeySeparator = ".";
            Grouping = "/CredManCashDiscRankEntity";

            AddGroup("Common Data Model CredManCashDiscRankEntity Details", group =>
            {
                CashDiscCode = group.Add(new VocabularyKey(nameof(CashDiscCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscRanking = group.Add(new VocabularyKey(nameof(CashDiscRanking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CashDiscCode { get; private set; }
public VocabularyKey CashDiscRanking { get; private set; }


    }
}