using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsProductSpecificItemBatchAttributeEntityVocabulary : SimpleVocabulary
    {
        public PdsProductSpecificItemBatchAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsProductSpecificItemBatchAttributeEntity";
            KeyPrefix = "commonDataModel.pdsproductspecificitembatchattributeentity";
            KeySeparator = ".";
            Grouping = "/PdsProductSpecificItemBatchAttributeEntity";

            AddGroup("Common Data Model PdsProductSpecificItemBatchAttributeEntity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchAttributeCode = group.Add(new VocabularyKey(nameof(BatchAttributeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BatchAttributeRelation = group.Add(new VocabularyKey(nameof(BatchAttributeRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchAttributeId = group.Add(new VocabularyKey(nameof(ItemBatchAttributeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemBatchAttributeGroupId = group.Add(new VocabularyKey(nameof(ItemBatchAttributeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumTolerance = group.Add(new VocabularyKey(nameof(MinimumTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumTolerance = group.Add(new VocabularyKey(nameof(MaximumTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToleranceIncrement = group.Add(new VocabularyKey(nameof(ToleranceIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptimalValue = group.Add(new VocabularyKey(nameof(OptimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptimalText = group.Add(new VocabularyKey(nameof(OptimalText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptimalDate = group.Add(new VocabularyKey(nameof(OptimalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptimalEnumerate = group.Add(new VocabularyKey(nameof(OptimalEnumerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumIntegerTolerance = group.Add(new VocabularyKey(nameof(MinimumIntegerTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumIntegerTolerance = group.Add(new VocabularyKey(nameof(MaximumIntegerTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntegerToleranceIncrement = group.Add(new VocabularyKey(nameof(IntegerToleranceIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptimalInteger = group.Add(new VocabularyKey(nameof(OptimalInteger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumDecimalTolerance = group.Add(new VocabularyKey(nameof(MinimumDecimalTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumDecimalTolerance = group.Add(new VocabularyKey(nameof(MaximumDecimalTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DecimalToleranceIncrement = group.Add(new VocabularyKey(nameof(DecimalToleranceIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptimalDecimal = group.Add(new VocabularyKey(nameof(OptimalDecimal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToleranceFailingAction = group.Add(new VocabularyKey(nameof(ToleranceFailingAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPotencyAttribute = group.Add(new VocabularyKey(nameof(IsPotencyAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey BatchAttributeCode { get; private set; }
public VocabularyKey BatchAttributeRelation { get; private set; }
public VocabularyKey ItemBatchAttributeId { get; private set; }
public VocabularyKey ItemBatchAttributeGroupId { get; private set; }
public VocabularyKey MinimumTolerance { get; private set; }
public VocabularyKey MaximumTolerance { get; private set; }
public VocabularyKey ToleranceIncrement { get; private set; }
public VocabularyKey OptimalValue { get; private set; }
public VocabularyKey OptimalText { get; private set; }
public VocabularyKey OptimalDate { get; private set; }
public VocabularyKey OptimalEnumerate { get; private set; }
public VocabularyKey MinimumIntegerTolerance { get; private set; }
public VocabularyKey MaximumIntegerTolerance { get; private set; }
public VocabularyKey IntegerToleranceIncrement { get; private set; }
public VocabularyKey OptimalInteger { get; private set; }
public VocabularyKey MinimumDecimalTolerance { get; private set; }
public VocabularyKey MaximumDecimalTolerance { get; private set; }
public VocabularyKey DecimalToleranceIncrement { get; private set; }
public VocabularyKey OptimalDecimal { get; private set; }
public VocabularyKey ToleranceFailingAction { get; private set; }
public VocabularyKey IsPotencyAttribute { get; private set; }


    }
}