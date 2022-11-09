using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustInterestCdsEntityVocabulary : SimpleVocabulary
    {
        public CustInterestCdsEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustInterestCdsEntity";
            KeyPrefix = "commonDataModel.custinterestcdsentity";
            KeySeparator = ".";
            Grouping = "/CustInterestCdsEntity";

            AddGroup("Common Data Model CustInterestCdsEntity Details", group =>
            {
                InterestType = group.Add(new VocabularyKey(nameof(InterestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestCode = group.Add(new VocabularyKey(nameof(InterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Txt = group.Add(new VocabularyKey(nameof(Txt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InterestType { get; private set; }
public VocabularyKey InterestCode { get; private set; }
public VocabularyKey Txt { get; private set; }


    }
}