using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailTestAttributeVocabulary : SimpleVocabulary
    {
        public MarketingEmailTestAttributeVocabulary()
        {
            VocabularyName = "Common Data Model MarketingEmailTestAttribute";
            KeyPrefix = "commonDataModel.marketingemailtestattribute";
            KeySeparator = ".";
            Grouping = "/MarketingEmailTestAttribute";

            AddGroup("Common Data Model MarketingEmailTestAttribute Details", group =>
            {
                marketingEmailTestAttributeId = group.Add(new VocabularyKey(nameof(marketingEmailTestAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
property = group.Add(new VocabularyKey(nameof(property), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
value = group.Add(new VocabularyKey(nameof(value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
variant = group.Add(new VocabularyKey(nameof(variant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey marketingEmailTestAttributeId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey property { get; private set; }
public VocabularyKey value { get; private set; }
public VocabularyKey variant { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}