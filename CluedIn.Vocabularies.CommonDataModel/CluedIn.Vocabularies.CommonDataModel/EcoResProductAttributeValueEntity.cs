using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeValueEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeValueEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductAttributeValueEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributevalueentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeValueEntity";

            AddGroup("Common Data Model EcoResProductAttributeValueEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeTypeName = group.Add(new VocabularyKey(nameof(AttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyValue = group.Add(new VocabularyKey(nameof(CurrencyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BooleanValue = group.Add(new VocabularyKey(nameof(BooleanValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateTimeValue = group.Add(new VocabularyKey(nameof(DateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DecimalValue = group.Add(new VocabularyKey(nameof(DecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntegerValue = group.Add(new VocabularyKey(nameof(IntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TextValue = group.Add(new VocabularyKey(nameof(TextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FloatUnitOfMeasure = group.Add(new VocabularyKey(nameof(FloatUnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntUnitOfMeasure = group.Add(new VocabularyKey(nameof(IntUnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductNumber { get; private set; }
public VocabularyKey AttributeTypeName { get; private set; }
public VocabularyKey AttributeName { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey CurrencyValue { get; private set; }
public VocabularyKey BooleanValue { get; private set; }
public VocabularyKey DateTimeValue { get; private set; }
public VocabularyKey DecimalValue { get; private set; }
public VocabularyKey IntegerValue { get; private set; }
public VocabularyKey TextValue { get; private set; }
public VocabularyKey FloatUnitOfMeasure { get; private set; }
public VocabularyKey IntUnitOfMeasure { get; private set; }
public VocabularyKey UnitOfMeasure { get; private set; }


    }
}