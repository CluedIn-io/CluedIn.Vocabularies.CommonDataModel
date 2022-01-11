using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentCalendarRuleEntityVocabulary : SimpleVocabulary
    {
        public PaymentCalendarRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymentCalendarRuleEntity";
            KeyPrefix = "commonDataModel.paymentcalendarruleentity";
            KeySeparator = ".";
            Grouping = "/PaymentCalendarRuleEntity";

            AddGroup("Common Data Model PaymentCalendarRuleEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModuleType = group.Add(new VocabularyKey(nameof(ModuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RuleType = group.Add(new VocabularyKey(nameof(RuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ThirdPartyDocumentBankAddressPriority = group.Add(new VocabularyKey(nameof(ThirdPartyDocumentBankAddressPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ThirdPartyPrimaryAddressPriority = group.Add(new VocabularyKey(nameof(ThirdPartyPrimaryAddressPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ThirdPartyDocumentAddressPriority = group.Add(new VocabularyKey(nameof(ThirdPartyDocumentAddressPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpecificPaymentCalendarName = group.Add(new VocabularyKey(nameof(SpecificPaymentCalendarName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpecificVendorPaymentMethod = group.Add(new VocabularyKey(nameof(SpecificVendorPaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpecificCustomerPaymentMethod = group.Add(new VocabularyKey(nameof(SpecificCustomerPaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpecificPaymentTerms = group.Add(new VocabularyKey(nameof(SpecificPaymentTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey InstanceRelationType { get; private set; }
public VocabularyKey ModuleType { get; private set; }
public VocabularyKey RuleType { get; private set; }
public VocabularyKey IsActive { get; private set; }
public VocabularyKey Priority { get; private set; }
public VocabularyKey ThirdPartyDocumentBankAddressPriority { get; private set; }
public VocabularyKey ThirdPartyPrimaryAddressPriority { get; private set; }
public VocabularyKey ThirdPartyDocumentAddressPriority { get; private set; }
public VocabularyKey SpecificPaymentCalendarName { get; private set; }
public VocabularyKey SpecificVendorPaymentMethod { get; private set; }
public VocabularyKey SpecificCustomerPaymentMethod { get; private set; }
public VocabularyKey SpecificPaymentTerms { get; private set; }


    }
}