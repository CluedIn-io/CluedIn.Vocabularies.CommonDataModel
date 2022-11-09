using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeValueTypeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeValueTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductAttributeValueTypeEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributevaluetypeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeValueTypeEntity";

            AddGroup("Common Data Model EcoResProductAttributeValueTypeEntity Details", group =>
            {
                ProductAttributeTypeName = group.Add(new VocabularyKey(nameof(ProductAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValueType = group.Add(new VocabularyKey(nameof(ValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LowerCurrencyValue = group.Add(new VocabularyKey(nameof(LowerCurrencyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UpperCurrencyValue = group.Add(new VocabularyKey(nameof(UpperCurrencyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LowerDateTimeValue = group.Add(new VocabularyKey(nameof(LowerDateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UpperDateTimeValue = group.Add(new VocabularyKey(nameof(UpperDateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LowerDecimalValue = group.Add(new VocabularyKey(nameof(LowerDecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UpperDecimalValue = group.Add(new VocabularyKey(nameof(UpperDecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LowerIntegerValue = group.Add(new VocabularyKey(nameof(LowerIntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UpperIntegerValue = group.Add(new VocabularyKey(nameof(UpperIntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeTypeBounded = group.Add(new VocabularyKey(nameof(AttributeTypeBounded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductAttributeTypeName { get; private set; }
public VocabularyKey ValueType { get; private set; }
public VocabularyKey UnitSymbol { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey LowerCurrencyValue { get; private set; }
public VocabularyKey UpperCurrencyValue { get; private set; }
public VocabularyKey LowerDateTimeValue { get; private set; }
public VocabularyKey UpperDateTimeValue { get; private set; }
public VocabularyKey LowerDecimalValue { get; private set; }
public VocabularyKey UpperDecimalValue { get; private set; }
public VocabularyKey LowerIntegerValue { get; private set; }
public VocabularyKey UpperIntegerValue { get; private set; }
public VocabularyKey AttributeTypeBounded { get; private set; }


    }
}