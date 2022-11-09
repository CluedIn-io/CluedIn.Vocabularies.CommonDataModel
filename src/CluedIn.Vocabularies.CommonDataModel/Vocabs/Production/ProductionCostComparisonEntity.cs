using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionCostComparisonEntityVocabulary : SimpleVocabulary
    {
        public ProductionCostComparisonEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductionCostComparisonEntity";
            KeyPrefix = "commonDataModel.productioncostcomparisonentity";
            KeySeparator = ".";
            Grouping = "/ProductionCostComparisonEntity";

            AddGroup("Common Data Model ProductionCostComparisonEntity Details", group =>
            {
                ManufacturedItemNumber = group.Add(new VocabularyKey(nameof(ManufacturedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderNumber = group.Add(new VocabularyKey(nameof(ProductionOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderEndDate = group.Add(new VocabularyKey(nameof(ProductionOrderEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostStatementLineLevel = group.Add(new VocabularyKey(nameof(CostStatementLineLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostResourceId = group.Add(new VocabularyKey(nameof(CostResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostingType = group.Add(new VocabularyKey(nameof(CostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostGroupType = group.Add(new VocabularyKey(nameof(CostGroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EstimatedProductionCostAmount = group.Add(new VocabularyKey(nameof(EstimatedProductionCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RealizedProductionCostAmount = group.Add(new VocabularyKey(nameof(RealizedProductionCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionVarianceAmount = group.Add(new VocabularyKey(nameof(ProductionVarianceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ManufacturedItemNumber { get; private set; }
public VocabularyKey ProductionOrderNumber { get; private set; }
public VocabularyKey ProductionSiteId { get; private set; }
public VocabularyKey ProductionOrderEndDate { get; private set; }
public VocabularyKey CostStatementLineLevel { get; private set; }
public VocabularyKey CostResourceId { get; private set; }
public VocabularyKey CostingType { get; private set; }
public VocabularyKey CostGroupId { get; private set; }
public VocabularyKey CostGroupType { get; private set; }
public VocabularyKey UnitSymbol { get; private set; }
public VocabularyKey EstimatedProductionCostAmount { get; private set; }
public VocabularyKey RealizedProductionCostAmount { get; private set; }
public VocabularyKey ProductionVarianceAmount { get; private set; }


    }
}