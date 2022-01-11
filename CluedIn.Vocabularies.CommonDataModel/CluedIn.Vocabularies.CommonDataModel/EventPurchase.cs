using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EventPurchaseVocabulary : SimpleVocabulary
    {
        public EventPurchaseVocabulary()
        {
            VocabularyName = "Common Data Model EventPurchase";
            KeyPrefix = "commonDataModel.eventpurchase";
            KeySeparator = ".";
            Grouping = "/EventPurchase";

            AddGroup("Common Data Model EventPurchase Details", group =>
            {
                area = group.Add(new VocabularyKey(nameof(area), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
companySize = group.Add(new VocabularyKey(nameof(companySize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
eventPurchaseId = group.Add(new VocabularyKey(nameof(eventPurchaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
industry = group.Add(new VocabularyKey(nameof(industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
paid = group.Add(new VocabularyKey(nameof(paid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
processed = group.Add(new VocabularyKey(nameof(processed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
yearsInIndustry = group.Add(new VocabularyKey(nameof(yearsInIndustry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey area { get; private set; }
public VocabularyKey companySize { get; private set; }
public VocabularyKey eventPurchaseId { get; private set; }
public VocabularyKey industry { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey paid { get; private set; }
public VocabularyKey processed { get; private set; }
public VocabularyKey yearsInIndustry { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}