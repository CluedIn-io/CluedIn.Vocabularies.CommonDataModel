using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTestVocabulary : SimpleVocabulary
    {
        public MarketingEmailTestVocabulary()
        {
            VocabularyName = "Common Data Model MarketingEmailTest";
            KeyPrefix = "commonDataModel.marketingemailtest";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTest";

            AddGroup("Common Data Model MarketingEmailTest Details", group =>
            {
                marketingEmailTestId = group.Add(new VocabularyKey(nameof(marketingEmailTestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
testProperty = group.Add(new VocabularyKey(nameof(testProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
testPropertyCombinationType = group.Add(new VocabularyKey(nameof(testPropertyCombinationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
teststatus = group.Add(new VocabularyKey(nameof(teststatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey marketingEmailTestId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey testProperty { get; private set; }
public VocabularyKey testPropertyCombinationType { get; private set; }
public VocabularyKey teststatus { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}