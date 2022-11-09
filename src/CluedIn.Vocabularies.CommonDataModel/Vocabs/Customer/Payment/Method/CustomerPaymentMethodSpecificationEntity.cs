using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerPaymentMethodSpecificationEntityVocabulary : SimpleVocabulary
    {
        public CustomerPaymentMethodSpecificationEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustomerPaymentMethodSpecificationEntity";
            KeyPrefix = "commonDataModel.customerpaymentmethodspecificationentity";
            KeySeparator = ".";
            Grouping = "/CustomerPaymentMethodSpecificationEntity";

            AddGroup("Common Data Model CustomerPaymentMethodSpecificationEntity Details", group =>
            {
                ClassId = group.Add(new VocabularyKey(nameof(ClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentMethodName = group.Add(new VocabularyKey(nameof(PaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClassName = group.Add(new VocabularyKey(nameof(ClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SpecParameters = group.Add(new VocabularyKey(nameof(SpecParameters), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentType = group.Add(new VocabularyKey(nameof(PaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentWay = group.Add(new VocabularyKey(nameof(PaymentWay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RemittanceSegment = group.Add(new VocabularyKey(nameof(RemittanceSegment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReturnSegment = group.Add(new VocabularyKey(nameof(ReturnSegment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ClassId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey PaymentMethodName { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ClassName { get; private set; }
public VocabularyKey SpecParameters { get; private set; }
public VocabularyKey PaymentType { get; private set; }
public VocabularyKey PaymentWay { get; private set; }
public VocabularyKey RemittanceSegment { get; private set; }
public VocabularyKey ReturnSegment { get; private set; }


    }
}