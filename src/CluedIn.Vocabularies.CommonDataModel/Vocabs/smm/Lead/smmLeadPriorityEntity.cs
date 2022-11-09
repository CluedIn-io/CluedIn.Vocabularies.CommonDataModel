using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmLeadPriorityEntityVocabulary : SimpleVocabulary
    {
        public smmLeadPriorityEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmLeadPriorityEntity";
            KeyPrefix = "commonDataModel.smmleadpriorityentity";
            KeySeparator = ".";
            Grouping = "/smmLeadPriorityEntity";

            AddGroup("Common Data Model smmLeadPriorityEntity Details", group =>
            {
                PriorityDescription = group.Add(new VocabularyKey(nameof(PriorityDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillCustomerServiceIssueHotAlert = group.Add(new VocabularyKey(nameof(WillCustomerServiceIssueHotAlert), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PriorityDescription { get; private set; }
public VocabularyKey WillCustomerServiceIssueHotAlert { get; private set; }
public VocabularyKey PriorityCode { get; private set; }


    }
}