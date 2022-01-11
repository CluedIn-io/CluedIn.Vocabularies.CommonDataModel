using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormSubmissionVocabulary : SimpleVocabulary
    {
        public MarketingFormSubmissionVocabulary()
        {
            VocabularyName = "Common Data Model MarketingFormSubmission";
            KeyPrefix = "commonDataModel.marketingformsubmission";
            KeySeparator = ".";
            Grouping = "/MarketingFormSubmission";

            AddGroup("Common Data Model MarketingFormSubmission Details", group =>
            {
                customerjourneyidValue = group.Add(new VocabularyKey(nameof(customerjourneyidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
failuredescription = group.Add(new VocabularyKey(nameof(failuredescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
failuretechnicaldetails = group.Add(new VocabularyKey(nameof(failuretechnicaldetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
formName = group.Add(new VocabularyKey(nameof(formName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
contactMatchingResult = group.Add(new VocabularyKey(nameof(contactMatchingResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
websiteidValue = group.Add(new VocabularyKey(nameof(websiteidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingemailidValue = group.Add(new VocabularyKey(nameof(marketingemailidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingformidValue = group.Add(new VocabularyKey(nameof(marketingformidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingFormSubmissionId = group.Add(new VocabularyKey(nameof(marketingFormSubmissionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
marketingpageidValue = group.Add(new VocabularyKey(nameof(marketingpageidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
originalContactidValue = group.Add(new VocabularyKey(nameof(originalContactidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timestampSubmission = group.Add(new VocabularyKey(nameof(timestampSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sessionidValue = group.Add(new VocabularyKey(nameof(sessionidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
visitoridValue = group.Add(new VocabularyKey(nameof(visitoridValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
pageurl = group.Add(new VocabularyKey(nameof(pageurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
submittedValues = group.Add(new VocabularyKey(nameof(submittedValues), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
processingStep = group.Add(new VocabularyKey(nameof(processingStep), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey customerjourneyidValue { get; private set; }
public VocabularyKey failuredescription { get; private set; }
public VocabularyKey failuretechnicaldetails { get; private set; }
public VocabularyKey formName { get; private set; }
public VocabularyKey contactMatchingResult { get; private set; }
public VocabularyKey websiteidValue { get; private set; }
public VocabularyKey marketingemailidValue { get; private set; }
public VocabularyKey marketingformidValue { get; private set; }
public VocabularyKey marketingFormSubmissionId { get; private set; }
public VocabularyKey marketingpageidValue { get; private set; }
public VocabularyKey originalContactidValue { get; private set; }
public VocabularyKey timestampSubmission { get; private set; }
public VocabularyKey sessionidValue { get; private set; }
public VocabularyKey visitoridValue { get; private set; }
public VocabularyKey pageurl { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey submittedValues { get; private set; }
public VocabularyKey processingStep { get; private set; }


    }
}