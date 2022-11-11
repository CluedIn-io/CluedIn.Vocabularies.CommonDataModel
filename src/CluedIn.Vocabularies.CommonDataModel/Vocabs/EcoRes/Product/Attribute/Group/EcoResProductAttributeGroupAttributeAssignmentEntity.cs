using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeGroupAttributeAssignmentEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeGroupAttributeAssignmentEntityVocabulary()
        {
            VocabularyName = "EcoResProductAttributeGroupAttributeAssignmentEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributegroupattributeassignmententity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeGroupAttributeAssignmentEntity";

            AddGroup("EcoResProductAttributeGroupAttributeAssignmentEntity Details", group =>
            {
                ProductAttributeGroupName = group.Add(new VocabularyKey(nameof(ProductAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeName = group.Add(new VocabularyKey(nameof(ProductAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeTypeName = group.Add(new VocabularyKey(nameof(ProductAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyValue = group.Add(new VocabularyKey(nameof(CurrencyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BooleanValue = group.Add(new VocabularyKey(nameof(BooleanValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateTimeValue = group.Add(new VocabularyKey(nameof(DateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecimalValue = group.Add(new VocabularyKey(nameof(DecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegerValue = group.Add(new VocabularyKey(nameof(IntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextValue = group.Add(new VocabularyKey(nameof(TextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductAttributeRetailDisplayOrder = group.Add(new VocabularyKey(nameof(ProductAttributeRetailDisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductAttributeGroupName { get; private set; }
        public VocabularyKey ProductAttributeName { get; private set; }
        public VocabularyKey ProductAttributeTypeName { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CurrencyValue { get; private set; }
        public VocabularyKey BooleanValue { get; private set; }
        public VocabularyKey DateTimeValue { get; private set; }
        public VocabularyKey DecimalValue { get; private set; }
        public VocabularyKey IntegerValue { get; private set; }
        public VocabularyKey TextValue { get; private set; }
        public VocabularyKey ProductAttributeRetailDisplayOrder { get; private set; }


    }
}