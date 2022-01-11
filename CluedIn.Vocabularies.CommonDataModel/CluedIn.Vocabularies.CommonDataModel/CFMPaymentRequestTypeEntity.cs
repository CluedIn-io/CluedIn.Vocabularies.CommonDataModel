using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMPaymentRequestTypeEntityVocabulary : SimpleVocabulary
    {
        public CFMPaymentRequestTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFMPaymentRequestTypeEntity";
            KeyPrefix = "commonDataModel.cfmpaymentrequesttypeentity";
            KeySeparator = ".";
            Grouping = "/CFMPaymentRequestTypeEntity";

            AddGroup("Common Data Model CFMPaymentRequestTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentPriority = group.Add(new VocabularyKey(nameof(PaymentPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentRequestType = group.Add(new VocabularyKey(nameof(PaymentRequestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriorityCode = group.Add(new VocabularyKey(nameof(PriorityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Workflow = group.Add(new VocabularyKey(nameof(Workflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Direction { get; private set; }
public VocabularyKey PaymentPriority { get; private set; }
public VocabularyKey PaymentRequestType { get; private set; }
public VocabularyKey PriorityCode { get; private set; }
public VocabularyKey Workflow { get; private set; }


    }
}