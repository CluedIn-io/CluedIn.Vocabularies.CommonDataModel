using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceBillOfMaterialTemplateEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceBillOfMaterialTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model SMAServiceBillOfMaterialTemplateEntity";
            KeyPrefix = "commonDataModel.smaservicebillofmaterialtemplateentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceBillOfMaterialTemplateEntity";

            AddGroup("Common Data Model SMAServiceBillOfMaterialTemplateEntity Details", group =>
            {
                BOMId = group.Add(new VocabularyKey(nameof(BOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMName = group.Add(new VocabularyKey(nameof(BOMName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActiveSourceDate = group.Add(new VocabularyKey(nameof(ActiveSourceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMCopyRefId = group.Add(new VocabularyKey(nameof(BOMCopyRefId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BOMCopyRefType = group.Add(new VocabularyKey(nameof(BOMCopyRefType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceProductionOrderNumber = group.Add(new VocabularyKey(nameof(SourceProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceBOMId = group.Add(new VocabularyKey(nameof(SourceBOMId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceServiceBOMTemplateId = group.Add(new VocabularyKey(nameof(SourceServiceBOMTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BOMId { get; private set; }
public VocabularyKey BOMName { get; private set; }
public VocabularyKey ValidFromDate { get; private set; }
public VocabularyKey ValidToDate { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ActiveSourceDate { get; private set; }
public VocabularyKey BOMCopyRefId { get; private set; }
public VocabularyKey BOMCopyRefType { get; private set; }
public VocabularyKey SourceProductionOrderNumber { get; private set; }
public VocabularyKey SourceBOMId { get; private set; }
public VocabularyKey SourceServiceBOMTemplateId { get; private set; }


    }
}