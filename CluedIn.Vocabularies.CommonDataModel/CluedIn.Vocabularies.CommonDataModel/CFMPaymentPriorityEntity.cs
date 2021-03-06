using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMPaymentPriorityEntityVocabulary : SimpleVocabulary
    {
        public CFMPaymentPriorityEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFMPaymentPriorityEntity";
            KeyPrefix = "commonDataModel.cfmpaymentpriorityentity";
            KeySeparator = ".";
            Grouping = "/CFMPaymentPriorityEntity";

            AddGroup("Common Data Model CFMPaymentPriorityEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MatchingPriority = group.Add(new VocabularyKey(nameof(MatchingPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey PriorityCode { get; private set; }
public VocabularyKey MatchingPriority { get; private set; }


    }
}